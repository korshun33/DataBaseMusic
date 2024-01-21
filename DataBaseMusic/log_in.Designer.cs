namespace DataBaseMusic
{
    partial class log_in
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
            this.labelavto = new System.Windows.Forms.Label();
            this.labellog = new System.Windows.Forms.Label();
            this.labelpas = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.buttonent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelavto
            // 
            this.labelavto.AutoSize = true;
            this.labelavto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelavto.Location = new System.Drawing.Point(260, 20);
            this.labelavto.Name = "labelavto";
            this.labelavto.Size = new System.Drawing.Size(325, 46);
            this.labelavto.TabIndex = 0;
            this.labelavto.Text = "АВТОРИЗАЦИЯ";
            // 
            // labellog
            // 
            this.labellog.AutoSize = true;
            this.labellog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labellog.Location = new System.Drawing.Point(200, 143);
            this.labellog.Name = "labellog";
            this.labellog.Size = new System.Drawing.Size(96, 31);
            this.labellog.TabIndex = 1;
            this.labellog.Text = "Логин:";
            // 
            // labelpas
            // 
            this.labelpas.AutoSize = true;
            this.labelpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelpas.Location = new System.Drawing.Point(180, 205);
            this.labelpas.Name = "labelpas";
            this.labelpas.Size = new System.Drawing.Size(116, 31);
            this.labelpas.TabIndex = 2;
            this.labelpas.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_login.Location = new System.Drawing.Point(327, 153);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(236, 26);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_password.Location = new System.Drawing.Point(327, 215);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(236, 26);
            this.textBox_password.TabIndex = 4;
            // 
            // buttonent
            // 
            this.buttonent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonent.Location = new System.Drawing.Point(368, 300);
            this.buttonent.Name = "buttonent";
            this.buttonent.Size = new System.Drawing.Size(120, 30);
            this.buttonent.TabIndex = 5;
            this.buttonent.Text = "ВОЙТИ";
            this.buttonent.UseVisualStyleBackColor = true;
            this.buttonent.Click += new System.EventHandler(this.buttonent_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.buttonent);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.labelpas);
            this.Controls.Add(this.labellog);
            this.Controls.Add(this.labelavto);
            this.Name = "log_in";
            this.Text = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelavto;
        private System.Windows.Forms.Label labellog;
        private System.Windows.Forms.Label labelpas;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button buttonent;
    }
}