using Confluent.Kafka;
using KafkaTool.App;
using KafkaTool.Entities;
using KafkaTool.Interfaces;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KafkaTool
{
    public partial class MainForm : Form
    {
        private readonly IKafkaApp _kafkaApp;
        private readonly IKafkaConsumer _kafkaConsumer;
        private delegate void test(object sender, ConsumerEventArgs e);

        public MainForm(IKafkaApp kafkaApp, IKafkaConsumer kafkaConsumer)
        {
            _kafkaApp = kafkaApp;
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
                pushReuslt = _kafkaApp.Publish(json, kafkaTopic, env);
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
            Btn_Consume_Msg.Enabled = false;
            _kafkaConsumer.ThresholdReached += c_ThresholdReached;
            string topic = Txbx_Consune_Topic.Text;
            string groupId = Txbx_GroupId.Text;
            EnvType env = GetEnvType(Cmb_Env.Text);

            Thread consumerTread = new Thread(() => _kafkaConsumer.Consume(topic, groupId, env));
            consumerTread.Start();
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

        private void c_ThresholdReached(object sender, ConsumerEventArgs e)
        {
            string msg = $"{Environment.NewLine}{e.Message}{Txbx_Consume_Result.Text}";

            if (Txbx_Consume_Result.InvokeRequired)
            {
                var d = new test(c_ThresholdReached);
                Txbx_Consume_Result.Invoke(d, new object[] { sender, new ConsumerEventArgs() { Message = msg } });
            }
            else
            {
                Txbx_Consume_Result.Text = e.Message;
            }
        }

        private void Btn_Stop_Consume_Click(object sender, EventArgs e)
        {
            Btn_Consume_Msg.Enabled = true;
        }
    }
}
