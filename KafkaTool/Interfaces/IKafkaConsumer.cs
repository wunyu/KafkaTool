using KafkaTool.Entities;
using System;
using System.Threading;

namespace KafkaTool.Interfaces
{
    public interface IKafkaConsumer
    {
        event EventHandler<ConsumerEventArgs> OnReceivedMsgHandler;
        void Consume(string topic, string groupId, EnvType env, CancellationToken ct);
    }
}

