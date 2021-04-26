using KafkaTool.Entities;
using KafkaTool.Interfaces;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaTool
{
    public partial class MainForm : Form
    {
        private readonly IKafkaPublisher _kafkaPublisher;
        private readonly IKafkaConsumer _kafkaConsumer;
        private CancellationTokenSource _consumerCts;
        private delegate void ConsumerReceivedMsg(object sender, ConsumerEventArgs e);

        public MainForm(IKafkaPublisher kafkaApp, IKafkaConsumer kafkaConsumer)
        {
            _kafkaPublisher = kafkaApp;
            _kafkaConsumer = kafkaConsumer;
            InitializeComponent();
        }

        private void Btn_Push_Massage_Click(object sender, EventArgs e)
        {
            string filePath = Txbx_File_Path.Text;
            string kafkaTopic = Txbx_Publish_Topic.Text;
            string pushReuslt = "";
            EnvType env = GetEnvType(Cmb_Env.Text);

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Hi, your file path is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(kafkaTopic))
            {
                MessageBox.Show("Hi, your kafka topic is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                pushReuslt = _kafkaPublisher.Publish(json, kafkaTopic, env);
            }

            Txbx_Publish_Result.Text = pushReuslt + Txbx_Publish_Result.Text;
        }

        private void Btn_Clear_Result_Message_Click(object sender, EventArgs e)
        {
            Txbx_Publish_Result.Text = "";
        }

        private void Txbx_File_Path_Leave(object sender, EventArgs e)
        {
            if (!File.Exists(Txbx_File_Path.Text))
            {
                Lbl_File_Status.Text = "File Path Not Valid!";
                Lbl_File_Status.ForeColor = Color.Red;
            }
            else
            {
                Lbl_File_Status.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cmb_Env.SelectedIndex = 0;
            string defaultFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
            Txbx_File_Path.Text = defaultFilePath;
        }

        private void Btn_Consume_Msg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txbx_Consume_Topic.Text))
            {
                MessageBox.Show("Hi, your kafka consumer topic is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txbx_GroupId.Text))
            {
                MessageBox.Show("Hi, your kafka consumer group id is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Btn_Consume_Msg.Text = "Consuming...";
            Btn_Consume_Msg.Enabled = false;
            Txbx_GroupId.Enabled = false;
            Txbx_Consume_Topic.Enabled = false;
            _ = Consume();
        }

        private async Task Consume()
        {
            _kafkaConsumer.ThresholdReached += OnConsumerReceiveMsg;
            _consumerCts = new CancellationTokenSource();
            string topic = Txbx_Consume_Topic.Text;
            string groupId = Txbx_GroupId.Text;
            EnvType env = GetEnvType(Cmb_Env.Text);

            var t = Task.Run(() => _kafkaConsumer.Consume(topic, groupId, env, _consumerCts.Token), _consumerCts.Token);

            try
            {
                await t;
            }
            catch (OperationCanceledException e)
            {
                Txbx_Consume_Result.Text = $"{nameof(OperationCanceledException)} thrown with message {e.Message}{Environment.NewLine}{Txbx_Consume_Result.Text}";
            }
            finally
            {
                _consumerCts.Dispose();
                _kafkaConsumer.ThresholdReached -= OnConsumerReceiveMsg;
                Btn_Consume_Msg.Text = "Consume Message";
                Btn_Consume_Msg.Enabled = true;
                Txbx_GroupId.Enabled = true;
                Txbx_Consume_Topic.Enabled = true;
            }
        }

        private EnvType GetEnvType(string env)
        {
            if (env.Contains("DEV"))
            {
                return EnvType.Dev;
            }
            else if (env.Contains("BETA"))
            {
                return EnvType.Beta;
            }
            else
            {
                return EnvType.Dev;
            }
        }

        private void OnConsumerReceiveMsg(object sender, ConsumerEventArgs e)
        {
            string msg = $"{Environment.NewLine}{e.Message}{Txbx_Consume_Result.Text}";

            if (Txbx_Consume_Result.InvokeRequired)
            {
                var onReceiveMsg = new ConsumerReceivedMsg(OnConsumerReceiveMsg);
                Txbx_Consume_Result.Invoke(onReceiveMsg, new object[] { sender, new ConsumerEventArgs() { Message = msg } });
            }
            else
            {
                Txbx_Consume_Result.Text = e.Message;
            }
        }

        private void Btn_Stop_Consume_Click(object sender, EventArgs e)
        {
            if(_consumerCts != null)
                _consumerCts.Cancel();
        }

        private void Btn_Clear_Consumer_Result_Message_Click(object sender, EventArgs e)
        {
            Txbx_Consume_Result.Text = "";
        }
    }
}
