﻿namespace Test_online
{
    partial class FRunTest
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
            this.clb_title = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btn_next_topic = new System.Windows.Forms.Button();
            this.btn_last_topic = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btn_ascert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_topic = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_title
            // 
            this.clb_title.FormattingEnabled = true;
            this.clb_title.Location = new System.Drawing.Point(12, 12);
            this.clb_title.Name = "clb_title";
            this.clb_title.Size = new System.Drawing.Size(120, 356);
            this.clb_title.TabIndex = 1;
            this.clb_title.SelectedIndexChanged += new System.EventHandler(this.clb_title_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(484, 170);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(225, 239);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(484, 239);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // btn_next_topic
            // 
            this.btn_next_topic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_topic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_next_topic.Location = new System.Drawing.Point(413, 286);
            this.btn_next_topic.Name = "btn_next_topic";
            this.btn_next_topic.Size = new System.Drawing.Size(86, 30);
            this.btn_next_topic.TabIndex = 7;
            this.btn_next_topic.Text = "下一题";
            this.btn_next_topic.UseVisualStyleBackColor = true;
            this.btn_next_topic.Click += new System.EventHandler(this.btn_next_topic_Click);
            // 
            // btn_last_topic
            // 
            this.btn_last_topic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last_topic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_last_topic.Location = new System.Drawing.Point(277, 286);
            this.btn_last_topic.Name = "btn_last_topic";
            this.btn_last_topic.Size = new System.Drawing.Size(86, 30);
            this.btn_last_topic.TabIndex = 8;
            this.btn_last_topic.Text = "上一题";
            this.btn_last_topic.UseVisualStyleBackColor = true;
            this.btn_last_topic.Click += new System.EventHandler(this.btn_last_topic_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(262, 170);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(550, 170);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 16);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(262, 237);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 16);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(550, 237);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 16);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btn_ascert
            // 
            this.btn_ascert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ascert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ascert.Location = new System.Drawing.Point(551, 286);
            this.btn_ascert.Name = "btn_ascert";
            this.btn_ascert.Size = new System.Drawing.Size(86, 30);
            this.btn_ascert.TabIndex = 13;
            this.btn_ascert.Text = "确定答案";
            this.btn_ascert.UseVisualStyleBackColor = true;
            this.btn_ascert.Click += new System.EventHandler(this.btn_ascert_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(550, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "提交试卷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_topic
            // 
            this.tb_topic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_topic.Location = new System.Drawing.Point(208, 55);
            this.tb_topic.Multiline = true;
            this.tb_topic.Name = "tb_topic";
            this.tb_topic.ReadOnly = true;
            this.tb_topic.Size = new System.Drawing.Size(460, 93);
            this.tb_topic.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "考试剩余时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(380, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "分钟";
            // 
            // FRunTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_topic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ascert);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_last_topic);
            this.Controls.Add(this.btn_next_topic);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clb_title);
            this.Name = "FRunTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRunTest_FormClosed);
            this.Load += new System.EventHandler(this.FRunTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_title;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btn_next_topic;
        private System.Windows.Forms.Button btn_last_topic;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btn_ascert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_topic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}