namespace MessageHive_TestUtil
{
    partial class Conversation
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
            System.Windows.Forms.Button btnSend;
            this.richTextHistory = new System.Windows.Forms.RichTextBox();
            this.richTextEditor = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRID = new System.Windows.Forms.TextBox();
            btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(397, 396);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "发送";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // richTextHistory
            // 
            this.richTextHistory.Location = new System.Drawing.Point(6, 20);
            this.richTextHistory.Name = "richTextHistory";
            this.richTextHistory.Size = new System.Drawing.Size(448, 210);
            this.richTextHistory.TabIndex = 0;
            this.richTextHistory.Text = "";
            // 
            // richTextEditor
            // 
            this.richTextEditor.Location = new System.Drawing.Point(12, 254);
            this.richTextEditor.Name = "richTextEditor";
            this.richTextEditor.Size = new System.Drawing.Size(460, 136);
            this.richTextEditor.TabIndex = 1;
            this.richTextEditor.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextHistory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会话";
            // 
            // textRID
            // 
            this.textRID.Location = new System.Drawing.Point(12, 397);
            this.textRID.Name = "textRID";
            this.textRID.Size = new System.Drawing.Size(100, 21);
            this.textRID.TabIndex = 4;
            // 
            // Conversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 428);
            this.Controls.Add(this.textRID);
            this.Controls.Add(btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextEditor);
            this.Name = "Conversation";
            this.Text = "Conversation";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.RichTextBox richTextHistory;
        private System.Windows.Forms.RichTextBox richTextEditor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRID;
    }
}