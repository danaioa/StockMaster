namespace StockMaster
{
    partial class LoginForm
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
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAdaugareH = new System.Windows.Forms.Button();
            this.btnStergeH = new System.Windows.Forms.Button();
            this.btnSalvareHotel = new System.Windows.Forms.Button();
            this.lbIdentificator = new System.Windows.Forms.Label();
            this.lblNumeAfacere = new System.Windows.Forms.Label();
            this.lnlNumeAdmin = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblParolaAdmin = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtIdentificator = new System.Windows.Forms.TextBox();
            this.txtNumeAfacere = new System.Windows.Forms.TextBox();
            this.txtNumeAdmin = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtParolaAdmin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUtilizator.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizator.ForeColor = System.Drawing.Color.Purple;
            this.lblUtilizator.Location = new System.Drawing.Point(83, 92);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(81, 17);
            this.lblUtilizator.TabIndex = 0;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(202, 92);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(201, 22);
            this.txtUtilizator.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(194, 142);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(209, 22);
            this.txtParola.TabIndex = 2;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblParola.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.Purple;
            this.lblParola.Location = new System.Drawing.Point(86, 148);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(57, 17);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnLogin.Location = new System.Drawing.Point(519, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAdaugareH
            // 
            this.btnAdaugareH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugareH.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btnAdaugareH.Location = new System.Drawing.Point(57, 190);
            this.btnAdaugareH.Name = "btnAdaugareH";
            this.btnAdaugareH.Size = new System.Drawing.Size(151, 28);
            this.btnAdaugareH.TabIndex = 5;
            this.btnAdaugareH.Text = "Adauga Hotel ";
            this.btnAdaugareH.UseVisualStyleBackColor = true;
            this.btnAdaugareH.Visible = false;
            this.btnAdaugareH.Click += new System.EventHandler(this.btnAdaugareH_Click);
            // 
            // btnStergeH
            // 
            this.btnStergeH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStergeH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergeH.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btnStergeH.Location = new System.Drawing.Point(262, 190);
            this.btnStergeH.Name = "btnStergeH";
            this.btnStergeH.Size = new System.Drawing.Size(151, 28);
            this.btnStergeH.TabIndex = 6;
            this.btnStergeH.Text = "Sterge Hotel ";
            this.btnStergeH.UseVisualStyleBackColor = false;
            this.btnStergeH.Visible = false;
            // 
            // btnSalvareHotel
            // 
            this.btnSalvareHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvareHotel.ForeColor = System.Drawing.Color.Purple;
            this.btnSalvareHotel.Location = new System.Drawing.Point(554, 389);
            this.btnSalvareHotel.Name = "btnSalvareHotel";
            this.btnSalvareHotel.Size = new System.Drawing.Size(160, 35);
            this.btnSalvareHotel.TabIndex = 7;
            this.btnSalvareHotel.Text = "Salvare";
            this.btnSalvareHotel.UseVisualStyleBackColor = true;
            this.btnSalvareHotel.Visible = false;
            this.btnSalvareHotel.Click += new System.EventHandler(this.btnSalvareHotel_Click);
            // 
            // lbIdentificator
            // 
            this.lbIdentificator.AutoSize = true;
            this.lbIdentificator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbIdentificator.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbIdentificator.ForeColor = System.Drawing.Color.Purple;
            this.lbIdentificator.Location = new System.Drawing.Point(33, 236);
            this.lbIdentificator.Name = "lbIdentificator";
            this.lbIdentificator.Size = new System.Drawing.Size(151, 19);
            this.lbIdentificator.TabIndex = 8;
            this.lbIdentificator.Text = "Identificator Afacere ";
            this.lbIdentificator.Visible = false;
            // 
            // lblNumeAfacere
            // 
            this.lblNumeAfacere.AutoSize = true;
            this.lblNumeAfacere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumeAfacere.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumeAfacere.ForeColor = System.Drawing.Color.Purple;
            this.lblNumeAfacere.Location = new System.Drawing.Point(53, 261);
            this.lblNumeAfacere.Name = "lblNumeAfacere";
            this.lblNumeAfacere.Size = new System.Drawing.Size(109, 19);
            this.lblNumeAfacere.TabIndex = 9;
            this.lblNumeAfacere.Text = "Nume Afacere ";
            this.lblNumeAfacere.Visible = false;
            // 
            // lnlNumeAdmin
            // 
            this.lnlNumeAdmin.AutoSize = true;
            this.lnlNumeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lnlNumeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnlNumeAdmin.ForeColor = System.Drawing.Color.Purple;
            this.lnlNumeAdmin.Location = new System.Drawing.Point(69, 298);
            this.lnlNumeAdmin.Name = "lnlNumeAdmin";
            this.lnlNumeAdmin.Size = new System.Drawing.Size(94, 16);
            this.lnlNumeAdmin.TabIndex = 10;
            this.lnlNumeAdmin.Text = "Nume Admin";
            this.lnlNumeAdmin.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserName.ForeColor = System.Drawing.Color.Purple;
            this.lblUserName.Location = new System.Drawing.Point(72, 330);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 16);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Username";
            this.lblUserName.Visible = false;
            // 
            // lblParolaAdmin
            // 
            this.lblParolaAdmin.AutoSize = true;
            this.lblParolaAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblParolaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParolaAdmin.ForeColor = System.Drawing.Color.Purple;
            this.lblParolaAdmin.Location = new System.Drawing.Point(72, 367);
            this.lblParolaAdmin.Name = "lblParolaAdmin";
            this.lblParolaAdmin.Size = new System.Drawing.Size(53, 16);
            this.lblParolaAdmin.TabIndex = 12;
            this.lblParolaAdmin.Text = "Parola";
            this.lblParolaAdmin.Visible = false;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblemail.ForeColor = System.Drawing.Color.Purple;
            this.lblemail.Location = new System.Drawing.Point(72, 399);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 16);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "Email";
            this.lblemail.Visible = false;
            // 
            // txtIdentificator
            // 
            this.txtIdentificator.Location = new System.Drawing.Point(236, 230);
            this.txtIdentificator.Name = "txtIdentificator";
            this.txtIdentificator.Size = new System.Drawing.Size(191, 22);
            this.txtIdentificator.TabIndex = 14;
            this.txtIdentificator.Visible = false;
            // 
            // txtNumeAfacere
            // 
            this.txtNumeAfacere.Location = new System.Drawing.Point(236, 258);
            this.txtNumeAfacere.Name = "txtNumeAfacere";
            this.txtNumeAfacere.Size = new System.Drawing.Size(191, 22);
            this.txtNumeAfacere.TabIndex = 15;
            this.txtNumeAfacere.Visible = false;
            // 
            // txtNumeAdmin
            // 
            this.txtNumeAdmin.Location = new System.Drawing.Point(236, 298);
            this.txtNumeAdmin.Name = "txtNumeAdmin";
            this.txtNumeAdmin.Size = new System.Drawing.Size(191, 22);
            this.txtNumeAdmin.TabIndex = 16;
            this.txtNumeAdmin.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(236, 330);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 22);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.Visible = false;
            // 
            // txtParolaAdmin
            // 
            this.txtParolaAdmin.Location = new System.Drawing.Point(236, 367);
            this.txtParolaAdmin.Name = "txtParolaAdmin";
            this.txtParolaAdmin.Size = new System.Drawing.Size(191, 22);
            this.txtParolaAdmin.TabIndex = 18;
            this.txtParolaAdmin.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(236, 399);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 22);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Visible = false;
            // 
            // lblSM
            // 
            this.lblSM.AutoSize = true;
            this.lblSM.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSM.ForeColor = System.Drawing.Color.Purple;
            this.lblSM.Location = new System.Drawing.Point(339, 29);
            this.lblSM.Name = "lblSM";
            this.lblSM.Size = new System.Drawing.Size(153, 37);
            this.lblSM.TabIndex = 20;
            this.lblSM.Text = "StockMaster";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSM);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtParolaAdmin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNumeAdmin);
            this.Controls.Add(this.txtNumeAfacere);
            this.Controls.Add(this.txtIdentificator);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblParolaAdmin);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lnlNumeAdmin);
            this.Controls.Add(this.lblNumeAfacere);
            this.Controls.Add(this.lbIdentificator);
            this.Controls.Add(this.btnSalvareHotel);
            this.Controls.Add(this.btnStergeH);
            this.Controls.Add(this.btnAdaugareH);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblUtilizator);
            this.Name = "LoginForm";
            this.Text = "Introdu utilizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAdaugareH;
        private System.Windows.Forms.Button btnStergeH;
        private System.Windows.Forms.Button btnSalvareHotel;
        private System.Windows.Forms.Label lbIdentificator;
        private System.Windows.Forms.Label lblNumeAfacere;
        private System.Windows.Forms.Label lnlNumeAdmin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblParolaAdmin;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtIdentificator;
        private System.Windows.Forms.TextBox txtNumeAfacere;
        private System.Windows.Forms.TextBox txtNumeAdmin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtParolaAdmin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSM;
    }
}