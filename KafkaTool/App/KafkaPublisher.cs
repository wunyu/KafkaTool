using Confluent.Kafka;
using KafkaTool.Entities;
using KafkaTool.Interfaces;
using KafkaTool.Settings;
using Microsoft.Extensions.Options;
using System;

namespace KafkaTool.App
{
    public class KafkaPublisher : IKafkaPublisher
    {
        private readonly AppSetting _appSetting;

        public KafkaPublisher(IOptions<AppSetting> appSetting)
        {
            _appSetting = appSetting.Value;
        }

        public string Publish(string msg, string topicName, EnvType env)
        {
            string statusResult = "";
            string broker = "";
            string devBroker = _appSetting.KafkaSetting.Brokers.Dev;
            string betaBroker = _appSetting.KafkaSetting.Brokers.Beta;
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

            var config = new ProducerConfig()
            {
                BootstrapServers = broker,
                SocketTimeoutMs = 10000,
                RequestTimeoutMs = 5000,
                BatchNumMessages = 1,
                QueueBufferingMaxMessages = 1
            };

            try
            {
                statusResult += DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + Environment.NewLine + Environment.NewLine;
                statusResult += "---Start Sending Msg..." + Environment.NewLine;
                //statusResult += $"---Broker: {_broker}" + Environment.NewLine;
                statusResult += "---Env: " + env.ToString() + Environment.NewLine;
                statusResult += $"---Topic : {topicName}" + Environment.NewLine;
                //statusResult += $"---Message : {msg}" + Environment.NewLine;

                using (var producer = new ProducerBuilder<Null, string>(config).Build())
                {
                    producer.Produce(new TopicPartition(topicName, new Partition(0)), new Message<Null, string> { Value = msg });
                    producer.Flush();
                    statusResult += Environment.NewLine + "Succeed!" + Environment.NewLine;
                    statusResult += "-----------------------------------------" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                statusResult += Environment.NewLine + "Fail!" + Environment.NewLine;
                statusResult += $"Exception: {ex.Message} SendMessagToKafka => Broker: {broker} Topic : {topicName}, Message : {msg}" + Environment.NewLine;
            }

            return statusResult;
        }
    }
}
