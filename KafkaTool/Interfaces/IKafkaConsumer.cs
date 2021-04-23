using KafkaTool.Entities;
using System;

namespace KafkaTool.Interfaces
{
    public interface IKafkaConsumer
    {
        event EventHandler<ConsumerEventArgs> ThresholdReached;
        void Consume(string topic, string groupId, EnvType env);
    }
}

