namespace KafkaTool.Settings
{
    public class KafkaSetting
    {
        public BrokerSetting Brokers { get; set; }
    }

    public class BrokerSetting
    {
        public string Dev { get; set; }
        public string Beta { get; set; }
    }
}
