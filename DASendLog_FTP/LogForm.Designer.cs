namespace DASendLog_FTP
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_PictureList = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_PrintScreen = new System.Windows.Forms.Button();
            this.button_SelectPicture = new System.Windows.Forms.Button();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Report = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_UID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerPicture = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "為方便客服人員後續聯絡，請填寫下列基本資料，";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身分證號：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "並儘可能描述清楚使用問題，以利問題快速排除，謝謝！";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox_PictureList);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button_PrintScreen);
            this.groupBox1.Controls.Add(this.button_SelectPicture);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Controls.Add(this.textBox_Report);
            this.groupBox1.Controls.Add(this.textBox_Mail);
            this.groupBox1.Controls.Add(this.textBox_Phone);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.textBox_UID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 445);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "回報問題內容";
            // 
            // checkedListBox_PictureList
            // 
            this.checkedListBox_PictureList.FormattingEnabled = true;
            this.checkedListBox_PictureList.Location = new System.Drawing.Point(89, 305);
            this.checkedListBox_PictureList.Name = "checkedListBox_PictureList";
            this.checkedListBox_PictureList.Size = new System.Drawing.Size(284, 89);
            this.checkedListBox_PictureList.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "並請不要做任截剪，以利客服人員分析問題，謝謝！";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "請盡可能附上問題當下之「整個電腦畫面截圖」，";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(373, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // button_PrintScreen
            // 
            this.button_PrintScreen.Location = new System.Drawing.Point(6, 370);
            this.button_PrintScreen.Name = "button_PrintScreen";
            this.button_PrintScreen.Size = new System.Drawing.Size(75, 23);
            this.button_PrintScreen.TabIndex = 7;
            this.button_PrintScreen.Text = "執行截圖";
            this.button_PrintScreen.UseVisualStyleBackColor = true;
            this.button_PrintScreen.Click += new System.EventHandler(this.button_PrintScreen_Click);
            // 
            // button_SelectPicture
            // 
            this.button_SelectPicture.Location = new System.Drawing.Point(8, 305);
            this.button_SelectPicture.Name = "button_SelectPicture";
            this.button_SelectPicture.Size = new System.Drawing.Size(75, 23);
            this.button_SelectPicture.TabIndex = 6;
            this.button_SelectPicture.Text = "選擇截圖";
            this.button_SelectPicture.UseVisualStyleBackColor = true;
            this.button_SelectPicture.Click += new System.EventHandler(this.button_SelectPicture_Click);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(286, 414);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(90, 23);
            this.button_Send.TabIndex = 9;
            this.button_Send.Text = "送出問題回報";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Report
            // 
            this.textBox_Report.Location = new System.Drawing.Point(77, 74);
            this.textBox_Report.Multiline = true;
            this.textBox_Report.Name = "textBox_Report";
            this.textBox_Report.Size = new System.Drawing.Size(296, 161);
            this.textBox_Report.TabIndex = 5;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(273, 48);
            this.textBox_Mail.MaxLength = 256;
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(100, 22);
            this.textBox_Mail.TabIndex = 4;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(273, 22);
            this.textBox_Phone.MaxLength = 20;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 22);
            this.textBox_Phone.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(77, 48);
            this.textBox_Name.MaxLength = 20;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_UID
            // 
            this.textBox_UID.Location = new System.Drawing.Point(77, 22);
            this.textBox_UID.MaxLength = 20;
            this.textBox_UID.Name = "textBox_UID";
            this.textBox_UID.Size = new System.Drawing.Size(100, 22);
            this.textBox_UID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "問題描述：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "電子郵件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "電　　話：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "姓　　名：";
            // 
            // timerPicture
            // 
            this.timerPicture.Interval = 500;
            this.timerPicture.Tick += new System.EventHandler(this.timerPicture_Tick);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "傳送者用者記錄";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_SelectPicture;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_Report;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_UID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBox_PictureList;
        private System.Windows.Forms.Button button_PrintScreen;
        private System.Windows.Forms.Timer timerPicture;
    }
}

