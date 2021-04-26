using KafkaTool.Entities;
using System;
using System.Threading;

namespace KafkaTool.Interfaces
{
    public interface IKafkaConsumer
    {
        event EventHandler<ConsumerEventArgs> ThresholdReached;
        void Consume(string topic, string groupId, EnvType env, CancellationToken ct);
    }
}

