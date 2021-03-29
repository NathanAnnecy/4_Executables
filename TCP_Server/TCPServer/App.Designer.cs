namespace TCPServer
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.label1 = new System.Windows.Forms.Label();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.timerMoteur = new System.Windows.Forms.Timer(this.components);
            this.PictureMoteur = new System.Windows.Forms.PictureBox();
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.lblvitesse = new System.Windows.Forms.Label();
            this.lbltension = new System.Windows.Forms.Label();
            this.lblcourant = new System.Windows.Forms.Label();
            this.ZDGrapheVitesse = new ZedGraph.ZedGraphControl();
            this.checkDynamique = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.checkstatique = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblconsigne = new System.Windows.Forms.Label();
            this.lblsrv = new System.Windows.Forms.Label();
            this.lblcharge = new System.Windows.Forms.Label();
            this.ZDGrapheTension = new ZedGraph.ZedGraphControl();
            this.lblT = new System.Windows.Forms.Label();
            this.lbltps = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxKp = new System.Windows.Forms.TextBox();
            this.txtboxKi = new System.Windows.Forms.TextBox();
            this.txtboxKd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMoteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "vitesse";
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(139, 12);
            this.txtVitesse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(100, 22);
            this.txtVitesse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "couple de charge";
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(139, 49);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 22);
            this.txtCharge.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "vitesse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "tension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "courant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Choix correcteur";
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGO.Location = new System.Drawing.Point(275, 30);
            this.btnGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 40;
            this.btnGO.Text = "GO!";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // timerMoteur
            // 
            this.timerMoteur.Interval = 1000;
            this.timerMoteur.Tick += new System.EventHandler(this.TimerMoteur_Tick);
            // 
            // PictureMoteur
            // 
            this.PictureMoteur.Image = ((System.Drawing.Image)(resources.GetObject("PictureMoteur.Image")));
            this.PictureMoteur.Location = new System.Drawing.Point(59, 336);
            this.PictureMoteur.Margin = new System.Windows.Forms.Padding(4);
            this.PictureMoteur.Name = "PictureMoteur";
            this.PictureMoteur.Size = new System.Drawing.Size(149, 145);
            this.PictureMoteur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMoteur.TabIndex = 41;
            this.PictureMoteur.TabStop = false;
            // 
            // timer10
            // 
            this.timer10.Tick += new System.EventHandler(this.Timer10_Tick);
            // 
            // lblvitesse
            // 
            this.lblvitesse.AutoSize = true;
            this.lblvitesse.Location = new System.Drawing.Point(527, 17);
            this.lblvitesse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvitesse.Name = "lblvitesse";
            this.lblvitesse.Size = new System.Drawing.Size(16, 17);
            this.lblvitesse.TabIndex = 43;
            this.lblvitesse.Text = "0";
            // 
            // lbltension
            // 
            this.lbltension.AutoSize = true;
            this.lbltension.Location = new System.Drawing.Point(527, 54);
            this.lbltension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltension.Name = "lbltension";
            this.lbltension.Size = new System.Drawing.Size(16, 17);
            this.lbltension.TabIndex = 44;
            this.lbltension.Text = "0";
            // 
            // lblcourant
            // 
            this.lblcourant.AutoSize = true;
            this.lblcourant.Location = new System.Drawing.Point(527, 98);
            this.lblcourant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourant.Name = "lblcourant";
            this.lblcourant.Size = new System.Drawing.Size(16, 17);
            this.lblcourant.TabIndex = 45;
            this.lblcourant.Text = "0";
            // 
            // ZDGrapheVitesse
            // 
            this.ZDGrapheVitesse.Location = new System.Drawing.Point(395, 175);
            this.ZDGrapheVitesse.Margin = new System.Windows.Forms.Padding(5);
            this.ZDGrapheVitesse.Name = "ZDGrapheVitesse";
            this.ZDGrapheVitesse.ScrollGrace = 0D;
            this.ZDGrapheVitesse.ScrollMaxX = 0D;
            this.ZDGrapheVitesse.ScrollMaxY = 0D;
            this.ZDGrapheVitesse.ScrollMaxY2 = 0D;
            this.ZDGrapheVitesse.ScrollMinX = 0D;
            this.ZDGrapheVitesse.ScrollMinY = 0D;
            this.ZDGrapheVitesse.ScrollMinY2 = 0D;
            this.ZDGrapheVitesse.Size = new System.Drawing.Size(415, 306);
            this.ZDGrapheVitesse.TabIndex = 0;
            // 
            // checkDynamique
            // 
            this.checkDynamique.AutoSize = true;
            this.checkDynamique.Location = new System.Drawing.Point(29, 118);
            this.checkDynamique.Name = "checkDynamique";
            this.checkDynamique.Size = new System.Drawing.Size(101, 21);
            this.checkDynamique.TabIndex = 47;
            this.checkDynamique.Text = "Dynamique";
            this.checkDynamique.UseVisualStyleBackColor = true;
            this.checkDynamique.CheckedChanged += new System.EventHandler(this.checkDynamique_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(275, 92);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkstatique
            // 
            this.checkstatique.AutoSize = true;
            this.checkstatique.Location = new System.Drawing.Point(164, 118);
            this.checkstatique.Name = "checkstatique";
            this.checkstatique.Size = new System.Drawing.Size(82, 21);
            this.checkstatique.TabIndex = 49;
            this.checkstatique.Text = "Statique";
            this.checkstatique.UseVisualStyleBackColor = true;
            this.checkstatique.CheckedChanged += new System.EventHandler(this.checkstatique_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1057, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(891, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "consigne";
            // 
            // lblconsigne
            // 
            this.lblconsigne.AutoSize = true;
            this.lblconsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsigne.Location = new System.Drawing.Point(525, 135);
            this.lblconsigne.Name = "lblconsigne";
            this.lblconsigne.Size = new System.Drawing.Size(24, 25);
            this.lblconsigne.TabIndex = 53;
            this.lblconsigne.Text = "0";
            // 
            // lblsrv
            // 
            this.lblsrv.AutoSize = true;
            this.lblsrv.Location = new System.Drawing.Point(636, 143);
            this.lblsrv.Name = "lblsrv";
            this.lblsrv.Size = new System.Drawing.Size(52, 17);
            this.lblsrv.TabIndex = 54;
            this.lblsrv.Text = "charge";
            // 
            // lblcharge
            // 
            this.lblcharge.AutoSize = true;
            this.lblcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcharge.Location = new System.Drawing.Point(713, 136);
            this.lblcharge.Name = "lblcharge";
            this.lblcharge.Size = new System.Drawing.Size(24, 25);
            this.lblcharge.TabIndex = 55;
            this.lblcharge.Text = "0";
            // 
            // ZDGrapheTension
            // 
            this.ZDGrapheTension.Location = new System.Drawing.Point(820, 175);
            this.ZDGrapheTension.Margin = new System.Windows.Forms.Padding(5);
            this.ZDGrapheTension.Name = "ZDGrapheTension";
            this.ZDGrapheTension.ScrollGrace = 0D;
            this.ZDGrapheTension.ScrollMaxX = 0D;
            this.ZDGrapheTension.ScrollMaxY = 0D;
            this.ZDGrapheTension.ScrollMaxY2 = 0D;
            this.ZDGrapheTension.ScrollMinX = 0D;
            this.ZDGrapheTension.ScrollMinY = 0D;
            this.ZDGrapheTension.ScrollMinY2 = 0D;
            this.ZDGrapheTension.Size = new System.Drawing.Size(414, 306);
            this.ZDGrapheTension.TabIndex = 56;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(636, 36);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(79, 17);
            this.lblT.TabIndex = 57;
            this.lblT.Text = "Temps(ms)";
            // 
            // lbltps
            // 
            this.lbltps.AutoSize = true;
            this.lbltps.Location = new System.Drawing.Point(721, 36);
            this.lbltps.Name = "lbltps";
            this.lbltps.Size = new System.Drawing.Size(16, 17);
            this.lbltps.TabIndex = 58;
            this.lbltps.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "KP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ki:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kd:";
            // 
            // txtboxKp
            // 
            this.txtboxKp.Location = new System.Drawing.Point(204, 11);
            this.txtboxKp.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxKp.Name = "txtboxKp";
            this.txtboxKp.Size = new System.Drawing.Size(48, 22);
            this.txtboxKp.TabIndex = 47;
            // 
            // txtboxKi
            // 
            this.txtboxKi.Location = new System.Drawing.Point(204, 39);
            this.txtboxKi.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxKi.Name = "txtboxKi";
            this.txtboxKi.Size = new System.Drawing.Size(48, 22);
            this.txtboxKi.TabIndex = 46;
            // 
            // txtboxKd
            // 
            this.txtboxKd.Location = new System.Drawing.Point(204, 66);
            this.txtboxKd.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxKd.Name = "txtboxKd";
            this.txtboxKd.Size = new System.Drawing.Size(48, 22);
            this.txtboxKd.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtboxKd);
            this.groupBox2.Controls.Add(this.txtboxKi);
            this.groupBox2.Controls.Add(this.txtboxKp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(13, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(360, 129);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boucle fermée";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 530);
            this.Controls.Add(this.lbltps);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.ZDGrapheTension);
            this.Controls.Add(this.lblcharge);
            this.Controls.Add(this.lblsrv);
            this.Controls.Add(this.lblconsigne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkstatique);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.checkDynamique);
            this.Controls.Add(this.ZDGrapheVitesse);
            this.Controls.Add(this.lblcourant);
            this.Controls.Add(this.lbltension);
            this.Controls.Add(this.lblvitesse);
            this.Controls.Add(this.PictureMoteur);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVitesse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "App";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureMoteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.PictureBox PictureMoteur;
        private System.Windows.Forms.Label lblcourant;
        public System.Windows.Forms.Label lblvitesse;
        public System.Windows.Forms.Label lbltension;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.CheckBox checkDynamique;
        public System.Windows.Forms.CheckBox checkstatique;
        public System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public ZedGraph.ZedGraphControl ZDGrapheVitesse;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblconsigne;
        public System.Windows.Forms.Label lblsrv;
        public System.Windows.Forms.Label lblcharge;
        public ZedGraph.ZedGraphControl ZDGrapheTension;
        public System.Windows.Forms.Timer timerMoteur;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lbltps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxKp;
        private System.Windows.Forms.TextBox txtboxKi;
        private System.Windows.Forms.TextBox txtboxKd;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}