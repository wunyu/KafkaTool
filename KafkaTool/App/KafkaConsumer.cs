using Confluent.Kafka;
using KafkaTool.Entities;
using KafkaTool.Interfaces;
using KafkaTool.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Threading;

namespace KafkaTool.App
{
    public class KafkaConsumer : IKafkaConsumer
    {
        private readonly AppSetting _appSetting;
        public event EventHandler<ConsumerEventArgs> ThresholdReached;

        public KafkaConsumer(IOptions<AppSetting> appSetting)
        {
            _appSetting = appSetting?.Value;
        }

        public void Consume(string topic, string groupId, EnvType env, CancellationToken ct)
        {
            string broker = "";
            string devBroker = _appSetting.KafkaSetting.Brokers.Dev;
            string betaBroker = _appSetting.KafkaSetting.Brokers.Beta;
            string errorMsg = "";
            string consumeMsg = "";

            switch (env)
            {
                case EnvType.Beta:
                    broker = betaBroker;
                    break;
                case EnvType.Dev:
                default:
                    broker = devBroker;
                    break;
            }

            var config = new ConsumerConfig
            {
                BootstrapServers = broker,
                GroupId = groupId,
                EnableAutoCommit = false,
                StatisticsIntervalMs = 5000,
                SessionTimeoutMs = 6000,
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnablePartitionEof = true
            };

            using (var consumer = new ConsumerBuilder<Ignore, string>(config)
            .SetErrorHandler((_, e) => errorMsg += $"NotifierService error: {e.Reason}")
            .Build())
            {
                consumer.Subscribe(topic);
                //consumer.Assign(new TopicPartition(topic, 0));

                try
                {
                    while (true)
                    {
                        var consumeResult = consumer.Consume(ct);
                        try
                        {
                            if (consumeResult.IsPartitionEOF)
                                continue;

                            consumeMsg = consumeResult.Message.Timestamp.UtcDateTime.ToString() + ": " + consumeResult.Message.Value;
                            Console.WriteLine(consumeMsg);

                            ConsumerEventArgs args = new ConsumerEventArgs() { Message = consumeMsg };

                            OnReceivedMsg(args);
                            consumer.Commit(consumeResult);
                        }
                        catch (ConsumeException e)
                        {
                            consumer.Commit(consumeResult);
                            errorMsg += $"ConsumeException error: {e.Message}";
                            ConsumerEventArgs args = new ConsumerEventArgs() { Message = errorMsg };
                            OnReceivedMsg(args);
                        }
                    }
                }
                catch (OperationCanceledException ex)
                {
                    errorMsg += $"OperationCanceledException: {ex.Message}";
                    consumer.Close();
                }
                catch (Exception ex)
                {
                    errorMsg += $"Exception: {ex.Message}";
                    consumer.Close();
                }
                finally
                {
                    errorMsg += $" Consumer stop.";
                    ConsumerEventArgs args = new ConsumerEventArgs() { Message = errorMsg };
                    OnReceivedMsg(args);
                }
            }
        }

        protected virtual void OnReceivedMsg(ConsumerEventArgs e)
        {
            EventHandler<ConsumerEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
