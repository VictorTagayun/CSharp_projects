
namespace Victor_NXP_DashBoard01
{
    partial class frmVictorNXP
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
            this.lblVictorinfo = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.comboBoxCommPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCloseFrm = new System.Windows.Forms.Button();
            this.txtSerialPort = new System.Windows.Forms.TextBox();
            this.linkLabelgithub = new System.Windows.Forms.LinkLabel();
            this.txtdebug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVictorinfo
            // 
            this.lblVictorinfo.AutoSize = true;
            this.lblVictorinfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictorinfo.Location = new System.Drawing.Point(137, 364);
            this.lblVictorinfo.Name = "lblVictorinfo";
            this.lblVictorinfo.Size = new System.Drawing.Size(288, 32);
            this.lblVictorinfo.TabIndex = 0;
            this.lblVictorinfo.Text = "victortagayun.github.io";
            this.lblVictorinfo.Visible = false;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(640, 10);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(71, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // comboBoxCommPorts
            // 
            this.comboBoxCommPorts.FormattingEnabled = true;
            this.comboBoxCommPorts.Location = new System.Drawing.Point(717, 12);
            this.comboBoxCommPorts.Name = "comboBoxCommPorts";
            this.comboBoxCommPorts.Size = new System.Drawing.Size(71, 21);
            this.comboBoxCommPorts.TabIndex = 2;
            this.comboBoxCommPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommPorts_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(640, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(71, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCloseFrm
            // 
            this.btnCloseFrm.Location = new System.Drawing.Point(688, 415);
            this.btnCloseFrm.Name = "btnCloseFrm";
            this.btnCloseFrm.Size = new System.Drawing.Size(100, 23);
            this.btnCloseFrm.TabIndex = 4;
            this.btnCloseFrm.Text = "Quit Application";
            this.btnCloseFrm.UseVisualStyleBackColor = true;
            this.btnCloseFrm.Click += new System.EventHandler(this.btnCloseFrm_Click);
            // 
            // txtSerialPort
            // 
            this.txtSerialPort.Enabled = false;
            this.txtSerialPort.Location = new System.Drawing.Point(717, 41);
            this.txtSerialPort.Name = "txtSerialPort";
            this.txtSerialPort.Size = new System.Drawing.Size(71, 20);
            this.txtSerialPort.TabIndex = 5;
            // 
            // linkLabelgithub
            // 
            this.linkLabelgithub.AutoSize = true;
            this.linkLabelgithub.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelgithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelgithub.Location = new System.Drawing.Point(12, 9);
            this.linkLabelgithub.Name = "linkLabelgithub";
            this.linkLabelgithub.Size = new System.Drawing.Size(406, 32);
            this.linkLabelgithub.TabIndex = 7;
            this.linkLabelgithub.TabStop = true;
            this.linkLabelgithub.Text = "victortagayun.github.io";
            this.linkLabelgithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtdebug
            // 
            this.txtdebug.Location = new System.Drawing.Point(45, 150);
            this.txtdebug.Multiline = true;
            this.txtdebug.Name = "txtdebug";
            this.txtdebug.Size = new System.Drawing.Size(650, 181);
            this.txtdebug.TabIndex = 8;
            // 
            // frmVictorNXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtdebug);
            this.Controls.Add(this.linkLabelgithub);
            this.Controls.Add(this.txtSerialPort);
            this.Controls.Add(this.btnCloseFrm);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.comboBoxCommPorts);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblVictorinfo);
            this.Name = "frmVictorNXP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "victortagayun.github.io by Victor Tagayun";
            this.Load += new System.EventHandler(this.frmVictorNXP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVictorinfo;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox comboBoxCommPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCloseFrm;
        private System.Windows.Forms.TextBox txtSerialPort;
        private System.Windows.Forms.LinkLabel linkLabelgithub;
        private System.Windows.Forms.TextBox txtdebug;
    }
}

