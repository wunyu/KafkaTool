using KafkaTool.Entities;

namespace KafkaTool.Interfaces
{
    public interface IKafkaPublisher
    {
        string Publish(string msg, string topicName, EnvType env);
    }
}
