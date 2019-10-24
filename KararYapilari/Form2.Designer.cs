namespace KararYapilari
{
    partial class Form2
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
            this.btnSatisIslemleri = new System.Windows.Forms.Button();
            this.btnMarketKontrolu = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnGirisBilgisiKontrolu = new System.Windows.Forms.Button();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSatisIslemleri
            // 
            this.btnSatisIslemleri.Location = new System.Drawing.Point(45, 310);
            this.btnSatisIslemleri.Name = "btnSatisIslemleri";
            this.btnSatisIslemleri.Size = new System.Drawing.Size(262, 49);
            this.btnSatisIslemleri.TabIndex = 9;
            this.btnSatisIslemleri.Text = "SATIŞ İŞLEMLERİ";
            this.btnSatisIslemleri.UseVisualStyleBackColor = true;
            // 
            // btnMarketKontrolu
            // 
            this.btnMarketKontrolu.Location = new System.Drawing.Point(45, 245);
            this.btnMarketKontrolu.Name = "btnMarketKontrolu";
            this.btnMarketKontrolu.Size = new System.Drawing.Size(262, 51);
            this.btnMarketKontrolu.TabIndex = 8;
            this.btnMarketKontrolu.Text = "MARKET KONTROLU";
            this.btnMarketKontrolu.UseVisualStyleBackColor = true;
            this.btnMarketKontrolu.Click += new System.EventHandler(this.BtnMarketKontrolu_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Location = new System.Drawing.Point(45, 174);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(262, 57);
            this.btnNotKontrolu.TabIndex = 7;
            this.btnNotKontrolu.Text = "NOT KONTROLU";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.BtnNotKontrolu_Click);
            // 
            // btnGirisBilgisiKontrolu
            // 
            this.btnGirisBilgisiKontrolu.Location = new System.Drawing.Point(45, 58);
            this.btnGirisBilgisiKontrolu.Name = "btnGirisBilgisiKontrolu";
            this.btnGirisBilgisiKontrolu.Size = new System.Drawing.Size(264, 52);
            this.btnGirisBilgisiKontrolu.TabIndex = 6;
            this.btnGirisBilgisiKontrolu.Text = "GİRİŞ BİLGİSİ KONTROLU";
            this.btnGirisBilgisiKontrolu.UseVisualStyleBackColor = true;
            this.btnGirisBilgisiKontrolu.Click += new System.EventHandler(this.BtnGirisBilgisiKontrolu_Click);
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(45, 32);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(264, 20);
            this.txtDeger2.TabIndex = 5;
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(45, 6);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(264, 20);
            this.txtDeger1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "GİRİŞ BİLGİSİ KONTROLU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeger1);
            this.Controls.Add(this.btnSatisIslemleri);
            this.Controls.Add(this.btnMarketKontrolu);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnGirisBilgisiKontrolu);
            this.Controls.Add(this.txtDeger2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatisIslemleri;
        private System.Windows.Forms.Button btnMarketKontrolu;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnGirisBilgisiKontrolu;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.TextBox txtDeger1;
        private System.Windows.Forms.Button button1;
    }
}