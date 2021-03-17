using KafkaTool.Entities;
using KafkaTool.Interfaces;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KafkaTool
{
    public partial class MainForm : Form
    {
        private readonly IKafkaApp _kafkaApp;

        public MainForm(IKafkaApp kafkaApp)
        {
            _kafkaApp = kafkaApp;
            InitializeComponent();
        }
        private void Btn_Push_Massage_Click(object sender, EventArgs e)
        {
            string filePath = Txbx_File_Path.Text;
            string kafkaTopic = Txbx_Kafka_Topic.Text;
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

            Txbx_Result.Text = pushReuslt + Txbx_Result.Text;
        }

        private void Btn_Clear_Result_Message_Click(object sender, EventArgs e)
        {
            Txbx_Result.Text = "";
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

    }
}
