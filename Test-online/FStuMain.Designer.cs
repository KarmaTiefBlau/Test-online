namespace Test_online
{
    partial class FStuMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgv_examList = new System.Windows.Forms.DataGridView();
            this.btn_text = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgv_examList
            // 
            this.dgv_examList.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_examList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_examList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_examList.Location = new System.Drawing.Point(12, 50);
            this.dgv_examList.Name = "dgv_examList";
            this.dgv_examList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_examList.RowTemplate.Height = 23;
            this.dgv_examList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_examList.Size = new System.Drawing.Size(673, 178);
            this.dgv_examList.TabIndex = 1;
            this.dgv_examList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_examList_CellContentClick);
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.SystemColors.Info;
            this.btn_text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_text.Location = new System.Drawing.Point(249, 265);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(112, 43);
            this.btn_text.TabIndex = 2;
            this.btn_text.Text = "开始考试";
            this.btn_text.UseVisualStyleBackColor = false;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // FStuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(694, 380);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.dgv_examList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FStuMain";
            this.Text = "FStuMain";
            this.Load += new System.EventHandler(this.FStuMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgv_examList;
        private System.Windows.Forms.Button btn_text;
    }
}