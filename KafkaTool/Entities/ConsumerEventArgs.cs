using System;

namespace KafkaTool.Entities
{
    public class ConsumerEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
