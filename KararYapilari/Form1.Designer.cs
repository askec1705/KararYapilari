namespace KararYapilari
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnAdminKontrolu = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnTekCiftKontrolu = new System.Windows.Forms.Button();
            this.btnDegerKontrolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 13);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(438, 20);
            this.txtDeger.TabIndex = 0;
            // 
            // btnAdminKontrolu
            // 
            this.btnAdminKontrolu.Location = new System.Drawing.Point(12, 39);
            this.btnAdminKontrolu.Name = "btnAdminKontrolu";
            this.btnAdminKontrolu.Size = new System.Drawing.Size(438, 59);
            this.btnAdminKontrolu.TabIndex = 1;
            this.btnAdminKontrolu.Text = "ADMIN KONTROLU";
            this.btnAdminKontrolu.UseVisualStyleBackColor = true;
            this.btnAdminKontrolu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Location = new System.Drawing.Point(12, 105);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(436, 64);
            this.btnNotKontrolu.TabIndex = 2;
            this.btnNotKontrolu.Text = "NOT KONTROLU";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.BtnNotKontrolu_Click);
            // 
            // btnTekCiftKontrolu
            // 
            this.btnTekCiftKontrolu.Location = new System.Drawing.Point(12, 176);
            this.btnTekCiftKontrolu.Name = "btnTekCiftKontrolu";
            this.btnTekCiftKontrolu.Size = new System.Drawing.Size(436, 58);
            this.btnTekCiftKontrolu.TabIndex = 3;
            this.btnTekCiftKontrolu.Text = "TEK-ÇİFT KONTROLU";
            this.btnTekCiftKontrolu.UseVisualStyleBackColor = true;
            this.btnTekCiftKontrolu.Click += new System.EventHandler(this.BtnTekCiftKontrolu_Click);
            // 
            // btnDegerKontrolu
            // 
            this.btnDegerKontrolu.Location = new System.Drawing.Point(12, 241);
            this.btnDegerKontrolu.Name = "btnDegerKontrolu";
            this.btnDegerKontrolu.Size = new System.Drawing.Size(436, 56);
            this.btnDegerKontrolu.TabIndex = 4;
            this.btnDegerKontrolu.Text = "DEGER KONTROLU";
            this.btnDegerKontrolu.UseVisualStyleBackColor = true;
            this.btnDegerKontrolu.Click += new System.EventHandler(this.BtnDegerKontrolu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 309);
            this.Controls.Add(this.btnDegerKontrolu);
            this.Controls.Add(this.btnTekCiftKontrolu);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnAdminKontrolu);
            this.Controls.Add(this.txtDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnAdminKontrolu;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnTekCiftKontrolu;
        private System.Windows.Forms.Button btnDegerKontrolu;
    }
}

