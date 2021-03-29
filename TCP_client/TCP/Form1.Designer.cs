namespace TCPClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Askcurrent = new System.Windows.Forms.Button();
            this.Askvoltage = new System.Windows.Forms.Button();
            this.Askspeed = new System.Windows.Forms.Button();
            this.checkstatique = new System.Windows.Forms.CheckBox();
            this.checkdynamique = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttorque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtspeed = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(272, 37);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "10.7.178.236:9700";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(514, 379);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(46, 91);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(410, 276);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(272, 395);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 22);
            this.txtMessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(616, 379);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Askcurrent);
            this.groupBox1.Controls.Add(this.Askvoltage);
            this.groupBox1.Controls.Add(this.Askspeed);
            this.groupBox1.Controls.Add(this.checkstatique);
            this.groupBox1.Controls.Add(this.checkdynamique);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttorque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtspeed);
            this.groupBox1.Location = new System.Drawing.Point(504, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Askcurrent
            // 
            this.Askcurrent.Location = new System.Drawing.Point(25, 84);
            this.Askcurrent.Name = "Askcurrent";
            this.Askcurrent.Size = new System.Drawing.Size(75, 23);
            this.Askcurrent.TabIndex = 9;
            this.Askcurrent.Text = "current";
            this.Askcurrent.UseVisualStyleBackColor = true;
            this.Askcurrent.Click += new System.EventHandler(this.Askcurrent_Click);
            // 
            // Askvoltage
            // 
            this.Askvoltage.Location = new System.Drawing.Point(25, 55);
            this.Askvoltage.Name = "Askvoltage";
            this.Askvoltage.Size = new System.Drawing.Size(75, 23);
            this.Askvoltage.TabIndex = 12;
            this.Askvoltage.Text = "voltage";
            this.Askvoltage.UseVisualStyleBackColor = true;
            this.Askvoltage.Click += new System.EventHandler(this.Askvoltage_Click);
            // 
            // Askspeed
            // 
            this.Askspeed.Location = new System.Drawing.Point(25, 17);
            this.Askspeed.Name = "Askspeed";
            this.Askspeed.Size = new System.Drawing.Size(75, 23);
            this.Askspeed.TabIndex = 8;
            this.Askspeed.Text = "speed";
            this.Askspeed.UseVisualStyleBackColor = true;
            this.Askspeed.Click += new System.EventHandler(this.Askspeed_Click);
            // 
            // checkstatique
            // 
            this.checkstatique.AutoSize = true;
            this.checkstatique.Location = new System.Drawing.Point(179, 73);
            this.checkstatique.Name = "checkstatique";
            this.checkstatique.Size = new System.Drawing.Size(80, 21);
            this.checkstatique.TabIndex = 11;
            this.checkstatique.Text = "statique";
            this.checkstatique.UseVisualStyleBackColor = true;
            this.checkstatique.CheckedChanged += new System.EventHandler(this.checkstatique_CheckedChanged);
            // 
            // checkdynamique
            // 
            this.checkdynamique.AutoSize = true;
            this.checkdynamique.Location = new System.Drawing.Point(180, 19);
            this.checkdynamique.Name = "checkdynamique";
            this.checkdynamique.Size = new System.Drawing.Size(99, 21);
            this.checkdynamique.TabIndex = 8;
            this.checkdynamique.Text = "dynamique";
            this.checkdynamique.UseVisualStyleBackColor = true;
            this.checkdynamique.CheckedChanged += new System.EventHandler(this.checkdynamique_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "resisting torque";
            // 
            // txttorque
            // 
            this.txttorque.Location = new System.Drawing.Point(25, 192);
            this.txttorque.Name = "txttorque";
            this.txttorque.Size = new System.Drawing.Size(100, 22);
            this.txttorque.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "speed";
            // 
            // txtspeed
            // 
            this.txtspeed.Location = new System.Drawing.Point(25, 143);
            this.txtspeed.Name = "txtspeed";
            this.txtspeed.Size = new System.Drawing.Size(100, 22);
            this.txtspeed.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttorque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtspeed;
        private System.Windows.Forms.CheckBox checkstatique;
        private System.Windows.Forms.CheckBox checkdynamique;
        private System.Windows.Forms.Button Askvoltage;
        private System.Windows.Forms.Button Askspeed;
        private System.Windows.Forms.Button Askcurrent;
    }
}

