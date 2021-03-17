
namespace KafkaTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Push_Massage = new System.Windows.Forms.Button();
            this.Lbl_Env = new System.Windows.Forms.Label();
            this.Txbx_File_Path = new System.Windows.Forms.TextBox();
            this.Lbl_File_Path = new System.Windows.Forms.Label();
            this.Txbx_Result = new System.Windows.Forms.TextBox();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Btn_Clear_Result_Message = new System.Windows.Forms.Button();
            this.Lbl_File_Status = new System.Windows.Forms.Label();
            this.Lbl_Kafka_Topic = new System.Windows.Forms.Label();
            this.Txbx_Kafka_Topic = new System.Windows.Forms.TextBox();
            this.Cmb_Env = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_Push_Massage
            // 
            this.Btn_Push_Massage.Location = new System.Drawing.Point(31, 155);
            this.Btn_Push_Massage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Push_Massage.Name = "Btn_Push_Massage";
            this.Btn_Push_Massage.Size = new System.Drawing.Size(553, 27);
            this.Btn_Push_Massage.TabIndex = 0;
            this.Btn_Push_Massage.Text = "Push Message";
            this.Btn_Push_Massage.UseVisualStyleBackColor = true;
            this.Btn_Push_Massage.Click += new System.EventHandler(this.Btn_Push_Massage_Click);
            // 
            // Lbl_Env
            // 
            this.Lbl_Env.AutoSize = true;
            this.Lbl_Env.Location = new System.Drawing.Point(28, 25);
            this.Lbl_Env.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Env.Name = "Lbl_Env";
            this.Lbl_Env.Size = new System.Drawing.Size(81, 15);
            this.Lbl_Env.TabIndex = 1;
            this.Lbl_Env.Text = "Environment: ";
            // 
            // Txbx_File_Path
            // 
            this.Txbx_File_Path.Location = new System.Drawing.Point(119, 63);
            this.Txbx_File_Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_File_Path.Name = "Txbx_File_Path";
            this.Txbx_File_Path.Size = new System.Drawing.Size(465, 23);
            this.Txbx_File_Path.TabIndex = 2;
            this.Txbx_File_Path.Leave += new System.EventHandler(this.Txbx_File_Path_Leave);
            // 
            // Lbl_File_Path
            // 
            this.Lbl_File_Path.AutoSize = true;
            this.Lbl_File_Path.Location = new System.Drawing.Point(28, 67);
            this.Lbl_File_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_File_Path.Name = "Lbl_File_Path";
            this.Lbl_File_Path.Size = new System.Drawing.Size(55, 15);
            this.Lbl_File_Path.TabIndex = 3;
            this.Lbl_File_Path.Text = "File Path:";
            // 
            // Txbx_Result
            // 
            this.Txbx_Result.Location = new System.Drawing.Point(31, 218);
            this.Txbx_Result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_Result.Multiline = true;
            this.Txbx_Result.Name = "Txbx_Result";
            this.Txbx_Result.ReadOnly = true;
            this.Txbx_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txbx_Result.Size = new System.Drawing.Size(552, 363);
            this.Txbx_Result.TabIndex = 6;
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Location = new System.Drawing.Point(28, 200);
            this.Lbl_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(42, 15);
            this.Lbl_Result.TabIndex = 7;
            this.Lbl_Result.Text = "Result:";
            // 
            // Btn_Clear_Result_Message
            // 
            this.Btn_Clear_Result_Message.Location = new System.Drawing.Point(411, 588);
            this.Btn_Clear_Result_Message.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Clear_Result_Message.Name = "Btn_Clear_Result_Message";
            this.Btn_Clear_Result_Message.Size = new System.Drawing.Size(174, 27);
            this.Btn_Clear_Result_Message.TabIndex = 8;
            this.Btn_Clear_Result_Message.Text = "Clear Result Message";
            this.Btn_Clear_Result_Message.UseVisualStyleBackColor = true;
            this.Btn_Clear_Result_Message.Click += new System.EventHandler(this.Btn_Clear_Result_Message_Click);
            // 
            // Lbl_File_Status
            // 
            this.Lbl_File_Status.AutoSize = true;
            this.Lbl_File_Status.Location = new System.Drawing.Point(99, 90);
            this.Lbl_File_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_File_Status.Name = "Lbl_File_Status";
            this.Lbl_File_Status.Size = new System.Drawing.Size(0, 15);
            this.Lbl_File_Status.TabIndex = 9;
            // 
            // Lbl_Kafka_Topic
            // 
            this.Lbl_Kafka_Topic.AutoSize = true;
            this.Lbl_Kafka_Topic.Location = new System.Drawing.Point(28, 115);
            this.Lbl_Kafka_Topic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Kafka_Topic.Name = "Lbl_Kafka_Topic";
            this.Lbl_Kafka_Topic.Size = new System.Drawing.Size(70, 15);
            this.Lbl_Kafka_Topic.TabIndex = 10;
            this.Lbl_Kafka_Topic.Text = "Kafka Topic:";
            // 
            // Txbx_Kafka_Topic
            // 
            this.Txbx_Kafka_Topic.Location = new System.Drawing.Point(119, 112);
            this.Txbx_Kafka_Topic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_Kafka_Topic.Name = "Txbx_Kafka_Topic";
            this.Txbx_Kafka_Topic.Size = new System.Drawing.Size(465, 23);
            this.Txbx_Kafka_Topic.TabIndex = 11;
            // 
            // Cmb_Env
            // 
            this.Cmb_Env.FormattingEnabled = true;
            this.Cmb_Env.Items.AddRange(new object[] {
            "DEV",
            "BETA"});
            this.Cmb_Env.Location = new System.Drawing.Point(119, 22);
            this.Cmb_Env.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cmb_Env.Name = "Cmb_Env";
            this.Cmb_Env.Size = new System.Drawing.Size(140, 23);
            this.Cmb_Env.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 648);
            this.Controls.Add(this.Cmb_Env);
            this.Controls.Add(this.Txbx_Kafka_Topic);
            this.Controls.Add(this.Lbl_Kafka_Topic);
            this.Controls.Add(this.Lbl_File_Status);
            this.Controls.Add(this.Btn_Clear_Result_Message);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.Txbx_Result);
            this.Controls.Add(this.Lbl_File_Path);
            this.Controls.Add(this.Txbx_File_Path);
            this.Controls.Add(this.Lbl_Env);
            this.Controls.Add(this.Btn_Push_Massage);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MyKafkaTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Push_Massage;
        private System.Windows.Forms.Label Lbl_Env;
        private System.Windows.Forms.TextBox Txbx_File_Path;
        private System.Windows.Forms.Label Lbl_File_Path;
        private System.Windows.Forms.TextBox Txbx_Result;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.Button Btn_Clear_Result_Message;
        private System.Windows.Forms.Label Lbl_File_Status;
        private System.Windows.Forms.Label Lbl_Kafka_Topic;
        private System.Windows.Forms.TextBox Txbx_Kafka_Topic;
        private System.Windows.Forms.ComboBox Cmb_Env;
    }
}

