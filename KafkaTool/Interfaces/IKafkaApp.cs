using KafkaTool.Entities;

namespace KafkaTool.Interfaces
{
    public interface IKafkaApp
    {
        string Publish(string msg, string topicName, EnvType env);
    }
}
