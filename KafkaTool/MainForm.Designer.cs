
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
            this.Btn_Push_Msg = new System.Windows.Forms.Button();
            this.Lbl_Env = new System.Windows.Forms.Label();
            this.Txbx_File_Path = new System.Windows.Forms.TextBox();
            this.Lbl_File_Path = new System.Windows.Forms.Label();
            this.Txbx_Publish_Result = new System.Windows.Forms.TextBox();
            this.Lbl_Publish_Result = new System.Windows.Forms.Label();
            this.Btn_Clear_Result_Message = new System.Windows.Forms.Button();
            this.Lbl_File_Status = new System.Windows.Forms.Label();
            this.Lbl_Publish_Topic = new System.Windows.Forms.Label();
            this.Txbx_Publish_Topic = new System.Windows.Forms.TextBox();
            this.Cmb_Env = new System.Windows.Forms.ComboBox();
            this.Gb_publish = new System.Windows.Forms.GroupBox();
            this.Lbl_Consume_Topic = new System.Windows.Forms.Label();
            this.Txbx_Consune_Topic = new System.Windows.Forms.TextBox();
            this.Btn_Consume_Msg = new System.Windows.Forms.Button();
            this.Txbx_Consume_Result = new System.Windows.Forms.TextBox();
            this.Lbl_Consume_Result = new System.Windows.Forms.Label();
            this.Btn_Stop_Consume = new System.Windows.Forms.Button();
            this.Txbx_GroupId = new System.Windows.Forms.TextBox();
            this.Lbl_Consume_GroupId = new System.Windows.Forms.Label();
            this.Gb_publish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Push_Msg
            // 
            this.Btn_Push_Msg.Location = new System.Drawing.Point(16, 122);
            this.Btn_Push_Msg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Push_Msg.Name = "Btn_Push_Msg";
            this.Btn_Push_Msg.Size = new System.Drawing.Size(553, 27);
            this.Btn_Push_Msg.TabIndex = 0;
            this.Btn_Push_Msg.Text = "Push Message";
            this.Btn_Push_Msg.UseVisualStyleBackColor = true;
            this.Btn_Push_Msg.Click += new System.EventHandler(this.Btn_Push_Massage_Click);
            // 
            // Lbl_Env
            // 
            this.Lbl_Env.AutoSize = true;
            this.Lbl_Env.Location = new System.Drawing.Point(19, 18);
            this.Lbl_Env.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Env.Name = "Lbl_Env";
            this.Lbl_Env.Size = new System.Drawing.Size(81, 15);
            this.Lbl_Env.TabIndex = 1;
            this.Lbl_Env.Text = "Environment: ";
            // 
            // Txbx_File_Path
            // 
            this.Txbx_File_Path.Location = new System.Drawing.Point(104, 30);
            this.Txbx_File_Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_File_Path.Name = "Txbx_File_Path";
            this.Txbx_File_Path.Size = new System.Drawing.Size(465, 23);
            this.Txbx_File_Path.TabIndex = 2;
            this.Txbx_File_Path.Leave += new System.EventHandler(this.Txbx_File_Path_Leave);
            // 
            // Lbl_File_Path
            // 
            this.Lbl_File_Path.AutoSize = true;
            this.Lbl_File_Path.Location = new System.Drawing.Point(13, 34);
            this.Lbl_File_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_File_Path.Name = "Lbl_File_Path";
            this.Lbl_File_Path.Size = new System.Drawing.Size(55, 15);
            this.Lbl_File_Path.TabIndex = 3;
            this.Lbl_File_Path.Text = "File Path:";
            // 
            // Txbx_Publish_Result
            // 
            this.Txbx_Publish_Result.Location = new System.Drawing.Point(16, 185);
            this.Txbx_Publish_Result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_Publish_Result.Multiline = true;
            this.Txbx_Publish_Result.Name = "Txbx_Publish_Result";
            this.Txbx_Publish_Result.ReadOnly = true;
            this.Txbx_Publish_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txbx_Publish_Result.Size = new System.Drawing.Size(552, 363);
            this.Txbx_Publish_Result.TabIndex = 6;
            // 
            // Lbl_Publish_Result
            // 
            this.Lbl_Publish_Result.AutoSize = true;
            this.Lbl_Publish_Result.Location = new System.Drawing.Point(13, 167);
            this.Lbl_Publish_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Publish_Result.Name = "Lbl_Publish_Result";
            this.Lbl_Publish_Result.Size = new System.Drawing.Size(42, 15);
            this.Lbl_Publish_Result.TabIndex = 7;
            this.Lbl_Publish_Result.Text = "Result:";
            // 
            // Btn_Clear_Result_Message
            // 
            this.Btn_Clear_Result_Message.Location = new System.Drawing.Point(396, 555);
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
            this.Lbl_File_Status.Location = new System.Drawing.Point(88, 83);
            this.Lbl_File_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_File_Status.Name = "Lbl_File_Status";
            this.Lbl_File_Status.Size = new System.Drawing.Size(0, 15);
            this.Lbl_File_Status.TabIndex = 9;
            // 
            // Lbl_Publish_Topic
            // 
            this.Lbl_Publish_Topic.AutoSize = true;
            this.Lbl_Publish_Topic.Location = new System.Drawing.Point(13, 82);
            this.Lbl_Publish_Topic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Publish_Topic.Name = "Lbl_Publish_Topic";
            this.Lbl_Publish_Topic.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Publish_Topic.TabIndex = 10;
            this.Lbl_Publish_Topic.Text = "Topic:";
            // 
            // Txbx_Publish_Topic
            // 
            this.Txbx_Publish_Topic.Location = new System.Drawing.Point(104, 79);
            this.Txbx_Publish_Topic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_Publish_Topic.Name = "Txbx_Publish_Topic";
            this.Txbx_Publish_Topic.Size = new System.Drawing.Size(465, 23);
            this.Txbx_Publish_Topic.TabIndex = 11;
            // 
            // Cmb_Env
            // 
            this.Cmb_Env.FormattingEnabled = true;
            this.Cmb_Env.Items.AddRange(new object[] {
            "DEV",
            "BETA"});
            this.Cmb_Env.Location = new System.Drawing.Point(110, 15);
            this.Cmb_Env.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cmb_Env.Name = "Cmb_Env";
            this.Cmb_Env.Size = new System.Drawing.Size(140, 23);
            this.Cmb_Env.TabIndex = 12;
            // 
            // Gb_publish
            // 
            this.Gb_publish.Controls.Add(this.Txbx_Publish_Topic);
            this.Gb_publish.Controls.Add(this.Lbl_Publish_Topic);
            this.Gb_publish.Controls.Add(this.Lbl_File_Status);
            this.Gb_publish.Controls.Add(this.Btn_Clear_Result_Message);
            this.Gb_publish.Controls.Add(this.Lbl_Publish_Result);
            this.Gb_publish.Controls.Add(this.Txbx_Publish_Result);
            this.Gb_publish.Controls.Add(this.Lbl_File_Path);
            this.Gb_publish.Controls.Add(this.Txbx_File_Path);
            this.Gb_publish.Controls.Add(this.Btn_Push_Msg);
            this.Gb_publish.Location = new System.Drawing.Point(12, 50);
            this.Gb_publish.Name = "Gb_publish";
            this.Gb_publish.Size = new System.Drawing.Size(593, 596);
            this.Gb_publish.TabIndex = 13;
            this.Gb_publish.TabStop = false;
            this.Gb_publish.Text = "Publisher";
            // 
            // Lbl_Consume_Topic
            // 
            this.Lbl_Consume_Topic.AutoSize = true;
            this.Lbl_Consume_Topic.Location = new System.Drawing.Point(637, 132);
            this.Lbl_Consume_Topic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consume_Topic.Name = "Lbl_Consume_Topic";
            this.Lbl_Consume_Topic.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Consume_Topic.TabIndex = 13;
            this.Lbl_Consume_Topic.Text = "Topic:";
            // 
            // Txbx_Consune_Topic
            // 
            this.Txbx_Consune_Topic.Location = new System.Drawing.Point(701, 129);
            this.Txbx_Consune_Topic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_Consune_Topic.Name = "Txbx_Consune_Topic";
            this.Txbx_Consune_Topic.Size = new System.Drawing.Size(464, 23);
            this.Txbx_Consune_Topic.TabIndex = 13;
            // 
            // Btn_Consume_Msg
            // 
            this.Btn_Consume_Msg.Location = new System.Drawing.Point(634, 172);
            this.Btn_Consume_Msg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Consume_Msg.Name = "Btn_Consume_Msg";
            this.Btn_Consume_Msg.Size = new System.Drawing.Size(256, 27);
            this.Btn_Consume_Msg.TabIndex = 12;
            this.Btn_Consume_Msg.Text = "Consume Message";
            this.Btn_Consume_Msg.UseVisualStyleBackColor = true;
            this.Btn_Consume_Msg.Click += new System.EventHandler(this.Btn_Consume_Msg_Click);
            // 
            // Txbx_Consume_Result
            // 
            this.Txbx_Consume_Result.Location = new System.Drawing.Point(634, 235);
            this.Txbx_Consume_Result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_Consume_Result.Multiline = true;
            this.Txbx_Consume_Result.Name = "Txbx_Consume_Result";
            this.Txbx_Consume_Result.ReadOnly = true;
            this.Txbx_Consume_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txbx_Consume_Result.Size = new System.Drawing.Size(552, 363);
            this.Txbx_Consume_Result.TabIndex = 12;
            // 
            // Lbl_Consume_Result
            // 
            this.Lbl_Consume_Result.AutoSize = true;
            this.Lbl_Consume_Result.Location = new System.Drawing.Point(634, 217);
            this.Lbl_Consume_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consume_Result.Name = "Lbl_Consume_Result";
            this.Lbl_Consume_Result.Size = new System.Drawing.Size(42, 15);
            this.Lbl_Consume_Result.TabIndex = 12;
            this.Lbl_Consume_Result.Text = "Result:";
            // 
            // Btn_Stop_Consume
            // 
            this.Btn_Stop_Consume.Location = new System.Drawing.Point(909, 172);
            this.Btn_Stop_Consume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Stop_Consume.Name = "Btn_Stop_Consume";
            this.Btn_Stop_Consume.Size = new System.Drawing.Size(256, 27);
            this.Btn_Stop_Consume.TabIndex = 14;
            this.Btn_Stop_Consume.Text = "Stop Consume";
            this.Btn_Stop_Consume.UseVisualStyleBackColor = true;
            this.Btn_Stop_Consume.Click += new System.EventHandler(this.Btn_Stop_Consume_Click);
            // 
            // Txbx_GroupId
            // 
            this.Txbx_GroupId.Location = new System.Drawing.Point(701, 80);
            this.Txbx_GroupId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txbx_GroupId.Name = "Txbx_GroupId";
            this.Txbx_GroupId.Size = new System.Drawing.Size(464, 23);
            this.Txbx_GroupId.TabIndex = 15;
            // 
            // Lbl_Consume_GroupId
            // 
            this.Lbl_Consume_GroupId.AutoSize = true;
            this.Lbl_Consume_GroupId.Location = new System.Drawing.Point(637, 83);
            this.Lbl_Consume_GroupId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consume_GroupId.Name = "Lbl_Consume_GroupId";
            this.Lbl_Consume_GroupId.Size = new System.Drawing.Size(56, 15);
            this.Lbl_Consume_GroupId.TabIndex = 16;
            this.Lbl_Consume_GroupId.Text = "Group Id:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 658);
            this.Controls.Add(this.Lbl_Consume_GroupId);
            this.Controls.Add(this.Txbx_GroupId);
            this.Controls.Add(this.Btn_Stop_Consume);
            this.Controls.Add(this.Lbl_Consume_Result);
            this.Controls.Add(this.Txbx_Consume_Result);
            this.Controls.Add(this.Btn_Consume_Msg);
            this.Controls.Add(this.Cmb_Env);
            this.Controls.Add(this.Txbx_Consune_Topic);
            this.Controls.Add(this.Lbl_Consume_Topic);
            this.Controls.Add(this.Gb_publish);
            this.Controls.Add(this.Lbl_Env);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MyKafkaTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gb_publish.ResumeLayout(false);
            this.Gb_publish.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Push_Msg;
        private System.Windows.Forms.Label Lbl_Env;
        private System.Windows.Forms.TextBox Txbx_File_Path;
        private System.Windows.Forms.Label Lbl_File_Path;
        private System.Windows.Forms.TextBox Txbx_Publish_Result;
        private System.Windows.Forms.Label Lbl_Publish_Result;
        private System.Windows.Forms.Button Btn_Clear_Result_Message;
        private System.Windows.Forms.Label Lbl_File_Status;
        private System.Windows.Forms.Label Lbl_Publish_Topic;
        private System.Windows.Forms.TextBox Txbx_Publish_Topic;
        private System.Windows.Forms.ComboBox Cmb_Env;
        private System.Windows.Forms.GroupBox Gb_publish;
        private System.Windows.Forms.Label Lbl_Consume_Topic;
        private System.Windows.Forms.TextBox Txbx_Consune_Topic;
        private System.Windows.Forms.Button Btn_Consume_Msg;
        private System.Windows.Forms.TextBox Txbx_Consume_Result;
        private System.Windows.Forms.Label Lbl_Consume_Result;
        private System.Windows.Forms.Button Btn_Stop_Consume;
        private System.Windows.Forms.TextBox Txbx_GroupId;
        private System.Windows.Forms.Label Lbl_Consume_GroupId;
    }
}

