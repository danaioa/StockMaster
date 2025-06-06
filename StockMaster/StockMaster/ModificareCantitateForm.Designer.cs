namespace StockMaster
{
    partial class ModificareCantitateForm
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
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.btnSalvareDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(397, 62);
            this.txtCantitate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(132, 22);
            this.txtCantitate.TabIndex = 0;
            this.txtCantitate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSalvareDate
            // 
            this.btnSalvareDate.BackColor = System.Drawing.Color.Thistle;
            this.btnSalvareDate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvareDate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnSalvareDate.Location = new System.Drawing.Point(577, 57);
            this.btnSalvareDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvareDate.Name = "btnSalvareDate";
            this.btnSalvareDate.Size = new System.Drawing.Size(100, 28);
            this.btnSalvareDate.TabIndex = 1;
            this.btnSalvareDate.Text = "Salvează";
            this.btnSalvareDate.UseVisualStyleBackColor = false;
            this.btnSalvareDate.Click += new System.EventHandler(this.btnSalvareDate_Click);
            // 
            // ModificareCantitateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalvareDate);
            this.Controls.Add(this.txtCantitate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificareCantitateForm";
            this.Text = "ModificareCantitateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Button btnSalvareDate;
    }
}