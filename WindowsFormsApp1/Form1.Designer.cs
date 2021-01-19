namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonOpenPorts = new System.Windows.Forms.Button();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.labelToSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenPorts
            // 
            this.buttonOpenPorts.Location = new System.Drawing.Point(55, 37);
            this.buttonOpenPorts.Name = "buttonOpenPorts";
            this.buttonOpenPorts.Size = new System.Drawing.Size(178, 54);
            this.buttonOpenPorts.TabIndex = 0;
            this.buttonOpenPorts.Text = "open all ports";
            this.buttonOpenPorts.UseVisualStyleBackColor = true;
            this.buttonOpenPorts.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(55, 148);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(178, 53);
            this.buttonSendData.TabIndex = 1;
            this.buttonSendData.Text = "send data to all ports";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.Location = new System.Drawing.Point(113, 109);
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(120, 21);
            this.textBoxSendData.TabIndex = 2;
            // 
            // labelToSend
            // 
            this.labelToSend.AutoSize = true;
            this.labelToSend.Location = new System.Drawing.Point(57, 112);
            this.labelToSend.Name = "labelToSend";
            this.labelToSend.Size = new System.Drawing.Size(53, 12);
            this.labelToSend.TabIndex = 3;
            this.labelToSend.Text = "Sending:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelToSend);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.buttonOpenPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPorts;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.TextBox textBoxSendData;
        private System.Windows.Forms.Label labelToSend;
    }
}

