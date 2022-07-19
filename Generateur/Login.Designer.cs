
namespace Generateur
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.id = new System.Windows.Forms.TextBox();
            this.MotdePasse = new System.Windows.Forms.TextBox();
            this.Identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CLOUD = new System.Windows.Forms.Label();
            this.InfoLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(150, 185);
            this.id.Name = "id";
            this.id.PasswordChar = '*';
            this.id.Size = new System.Drawing.Size(312, 30);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // MotdePasse
            // 
            this.MotdePasse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MotdePasse.Location = new System.Drawing.Point(150, 221);
            this.MotdePasse.Name = "MotdePasse";
            this.MotdePasse.PasswordChar = '*';
            this.MotdePasse.Size = new System.Drawing.Size(312, 30);
            this.MotdePasse.TabIndex = 1;
            this.MotdePasse.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.BackColor = System.Drawing.Color.Transparent;
            this.Identifiant.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Identifiant.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Identifiant.Location = new System.Drawing.Point(121, 192);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(23, 19);
            this.Identifiant.TabIndex = 2;
            this.Identifiant.Text = "Id";
            this.Identifiant.Click += new System.EventHandler(this.Identifiant_Click);
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.BackColor = System.Drawing.Color.Transparent;
            this.mdp.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdp.ForeColor = System.Drawing.Color.MediumOrchid;
            this.mdp.Location = new System.Drawing.Point(31, 228);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(113, 19);
            this.mdp.TabIndex = 3;
            this.mdp.Text = "Mot de passe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(209, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Se Connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Extranet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CLOUD
            // 
            this.CLOUD.AutoSize = true;
            this.CLOUD.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CLOUD.ForeColor = System.Drawing.Color.MediumOrchid;
            this.CLOUD.Location = new System.Drawing.Point(19, 47);
            this.CLOUD.Name = "CLOUD";
            this.CLOUD.Size = new System.Drawing.Size(123, 46);
            this.CLOUD.TabIndex = 6;
            this.CLOUD.Text = "Cloud";
            this.CLOUD.Click += new System.EventHandler(this.CLOUD_Click);
            // 
            // InfoLog
            // 
            this.InfoLog.AutoSize = true;
            this.InfoLog.Location = new System.Drawing.Point(215, 329);
            this.InfoLog.Name = "InfoLog";
            this.InfoLog.Size = new System.Drawing.Size(0, 20);
            this.InfoLog.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 433);
            this.Controls.Add(this.InfoLog);
            this.Controls.Add(this.CLOUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.MotdePasse);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox MotdePasse;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CLOUD;
        private System.Windows.Forms.Label InfoLog;
    }
}