using System.Drawing;

namespace Sha_and_RSA
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSha = new System.Windows.Forms.Panel();
            this.buttonSha = new System.Windows.Forms.Button();
            this.menuConteiner = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRsaMenu = new System.Windows.Forms.Button();
            this.btnKeygenerator = new System.Windows.Forms.Button();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.btnSignMessage = new System.Windows.Forms.Button();
            this.btnVerifySignature = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelSha.SuspendLayout();
            this.menuConteiner.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 39);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimize.Location = new System.Drawing.Point(1042, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 39);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMaximize.Location = new System.Drawing.Point(1072, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 39);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(45, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(283, 28);
            this.title.TabIndex = 1;
            this.title.Text = "Hash Algorithms | Sha and RSA";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(1102, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanel1.Controls.Add(this.panelSha);
            this.flowLayoutPanel1.Controls.Add(this.menuConteiner);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 584);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panelSha
            // 
            this.panelSha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panelSha.Controls.Add(this.buttonSha);
            this.panelSha.Location = new System.Drawing.Point(0, 0);
            this.panelSha.Margin = new System.Windows.Forms.Padding(0);
            this.panelSha.Name = "panelSha";
            this.panelSha.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelSha.Size = new System.Drawing.Size(210, 55);
            this.panelSha.TabIndex = 5;
            // 
            // buttonSha
            // 
            this.buttonSha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonSha.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.buttonSha.FlatAppearance.BorderSize = 0;
            this.buttonSha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSha.ForeColor = System.Drawing.Color.Black;
            this.buttonSha.Image = ((System.Drawing.Image)(resources.GetObject("buttonSha.Image")));
            this.buttonSha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSha.Location = new System.Drawing.Point(3, 0);
            this.buttonSha.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSha.Name = "buttonSha";
            this.buttonSha.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSha.Size = new System.Drawing.Size(204, 52);
            this.buttonSha.TabIndex = 5;
            this.buttonSha.Text = "        Sha256";
            this.buttonSha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSha.UseVisualStyleBackColor = false;
            this.buttonSha.Click += new System.EventHandler(this.buttonSha_Click);
            // 
            // menuConteiner
            // 
            this.menuConteiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.menuConteiner.Controls.Add(this.buttonRsaMenu);
            this.menuConteiner.Controls.Add(this.btnKeygenerator);
            this.menuConteiner.Controls.Add(this.btnEncryption);
            this.menuConteiner.Controls.Add(this.btnDecryption);
            this.menuConteiner.Controls.Add(this.btnSignMessage);
            this.menuConteiner.Controls.Add(this.btnVerifySignature);
            this.menuConteiner.Location = new System.Drawing.Point(0, 55);
            this.menuConteiner.Margin = new System.Windows.Forms.Padding(0);
            this.menuConteiner.Name = "menuConteiner";
            this.menuConteiner.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuConteiner.Size = new System.Drawing.Size(210, 52);
            this.menuConteiner.TabIndex = 6;
            this.menuConteiner.Paint += new System.Windows.Forms.PaintEventHandler(this.menuConteiner_Paint);
            // 
            // buttonRsaMenu
            // 
            this.buttonRsaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonRsaMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.buttonRsaMenu.FlatAppearance.BorderSize = 0;
            this.buttonRsaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRsaMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRsaMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonRsaMenu.Image")));
            this.buttonRsaMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRsaMenu.Location = new System.Drawing.Point(8, 3);
            this.buttonRsaMenu.Name = "buttonRsaMenu";
            this.buttonRsaMenu.Size = new System.Drawing.Size(198, 52);
            this.buttonRsaMenu.TabIndex = 9;
            this.buttonRsaMenu.Text = "RSA";
            this.buttonRsaMenu.UseVisualStyleBackColor = false;
            this.buttonRsaMenu.Click += new System.EventHandler(this.buttonRsaMenu_Click);
            // 
            // btnKeygenerator
            // 
            this.btnKeygenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnKeygenerator.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnKeygenerator.FlatAppearance.BorderSize = 0;
            this.btnKeygenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeygenerator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeygenerator.Image = ((System.Drawing.Image)(resources.GetObject("btnKeygenerator.Image")));
            this.btnKeygenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeygenerator.Location = new System.Drawing.Point(5, 58);
            this.btnKeygenerator.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeygenerator.Name = "btnKeygenerator";
            this.btnKeygenerator.Size = new System.Drawing.Size(198, 52);
            this.btnKeygenerator.TabIndex = 6;
            this.btnKeygenerator.Text = "Key Generator";
            this.btnKeygenerator.UseVisualStyleBackColor = false;
            this.btnKeygenerator.Click += new System.EventHandler(this.btnKeygenerator_Click);
            // 
            // btnEncryption
            // 
            this.btnEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEncryption.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnEncryption.FlatAppearance.BorderSize = 0;
            this.btnEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncryption.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryption.Image")));
            this.btnEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryption.Location = new System.Drawing.Point(5, 110);
            this.btnEncryption.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(198, 52);
            this.btnEncryption.TabIndex = 10;
            this.btnEncryption.Text = "Encriyption";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDecryption.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnDecryption.FlatAppearance.BorderSize = 0;
            this.btnDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecryption.Image = ((System.Drawing.Image)(resources.GetObject("btnDecryption.Image")));
            this.btnDecryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryption.Location = new System.Drawing.Point(5, 162);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(198, 52);
            this.btnDecryption.TabIndex = 11;
            this.btnDecryption.Text = "Decryption ";
            this.btnDecryption.UseVisualStyleBackColor = false;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // btnSignMessage
            // 
            this.btnSignMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSignMessage.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSignMessage.FlatAppearance.BorderSize = 0;
            this.btnSignMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnSignMessage.Image")));
            this.btnSignMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignMessage.Location = new System.Drawing.Point(5, 214);
            this.btnSignMessage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignMessage.Name = "btnSignMessage";
            this.btnSignMessage.Size = new System.Drawing.Size(198, 52);
            this.btnSignMessage.TabIndex = 12;
            this.btnSignMessage.Text = "Sign Message";
            this.btnSignMessage.UseVisualStyleBackColor = false;
            this.btnSignMessage.Click += new System.EventHandler(this.btnSignMessage_Click);
            // 
            // btnVerifySignature
            // 
            this.btnVerifySignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnVerifySignature.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnVerifySignature.FlatAppearance.BorderSize = 0;
            this.btnVerifySignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifySignature.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerifySignature.Image = ((System.Drawing.Image)(resources.GetObject("btnVerifySignature.Image")));
            this.btnVerifySignature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifySignature.Location = new System.Drawing.Point(5, 266);
            this.btnVerifySignature.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerifySignature.Name = "btnVerifySignature";
            this.btnVerifySignature.Size = new System.Drawing.Size(198, 52);
            this.btnVerifySignature.TabIndex = 13;
            this.btnVerifySignature.Text = "Verify Signature";
            this.btnVerifySignature.UseVisualStyleBackColor = false;
            this.btnVerifySignature.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 1;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 584);
            this.panel2.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(922, 584);
            this.panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(108, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sha256 and Rsa Hash Algorithms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1132, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelSha.ResumeLayout(false);
            this.menuConteiner.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelSha;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner;
        private System.Windows.Forms.Button buttonSha;
        private System.Windows.Forms.Button buttonRsaMenu;
        private System.Windows.Forms.Button btnKeygenerator;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnSignMessage;
        private System.Windows.Forms.Button btnVerifySignature;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label label1;
    }
}

