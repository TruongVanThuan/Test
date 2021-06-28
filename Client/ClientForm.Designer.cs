
namespace Client
{
    partial class ClientForm
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
            this.textportPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textboxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textboxStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textportPort
            // 
            this.textportPort.Location = new System.Drawing.Point(200, 37);
            this.textportPort.Name = "textportPort";
            this.textportPort.Size = new System.Drawing.Size(42, 20);
            this.textportPort.TabIndex = 5;
            this.textportPort.Text = "8901";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // textboxHost
            // 
            this.textboxHost.Location = new System.Drawing.Point(62, 37);
            this.textboxHost.Name = "textboxHost";
            this.textboxHost.Size = new System.Drawing.Size(100, 20);
            this.textboxHost.TabIndex = 6;
            this.textboxHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(248, 35);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textboxMessage
            // 
            this.textboxMessage.Location = new System.Drawing.Point(62, 64);
            this.textboxMessage.Multiline = true;
            this.textboxMessage.Name = "textboxMessage";
            this.textboxMessage.Size = new System.Drawing.Size(361, 61);
            this.textboxMessage.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(348, 131);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textboxStatus
            // 
            this.textboxStatus.Location = new System.Drawing.Point(62, 160);
            this.textboxStatus.Multiline = true;
            this.textboxStatus.Name = "textboxStatus";
            this.textboxStatus.Size = new System.Drawing.Size(361, 127);
            this.textboxStatus.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 313);
            this.Controls.Add(this.textboxStatus);
            this.Controls.Add(this.textboxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textportPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxHost);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textportPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textboxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textboxStatus;
    }
}

