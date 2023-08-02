
namespace Hastane_Proje2
{
    partial class FrmDoktorBilgiDüzenle
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
            this.llshastakayıtbaslık = new System.Windows.Forms.Label();
            this.btnbilgiguncelle = new System.Windows.Forms.Button();
            this.txtdoktorsoyad = new System.Windows.Forms.TextBox();
            this.txtdoktorad = new System.Windows.Forms.TextBox();
            this.lblhastasoyad = new System.Windows.Forms.Label();
            this.lblhastaad = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llshastakayıtbaslık
            // 
            this.llshastakayıtbaslık.AutoSize = true;
            this.llshastakayıtbaslık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llshastakayıtbaslık.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llshastakayıtbaslık.Location = new System.Drawing.Point(83, 18);
            this.llshastakayıtbaslık.Name = "llshastakayıtbaslık";
            this.llshastakayıtbaslık.Size = new System.Drawing.Size(365, 42);
            this.llshastakayıtbaslık.TabIndex = 48;
            this.llshastakayıtbaslık.Text = "Doktor Bilgi Güncelle";
            // 
            // btnbilgiguncelle
            // 
            this.btnbilgiguncelle.Location = new System.Drawing.Point(420, 151);
            this.btnbilgiguncelle.Name = "btnbilgiguncelle";
            this.btnbilgiguncelle.Size = new System.Drawing.Size(137, 81);
            this.btnbilgiguncelle.TabIndex = 47;
            this.btnbilgiguncelle.Text = "Bilgi Güncelle";
            this.btnbilgiguncelle.UseVisualStyleBackColor = true;
            this.btnbilgiguncelle.Click += new System.EventHandler(this.btnbilgiguncelle_Click);
            // 
            // txtdoktorsoyad
            // 
            this.txtdoktorsoyad.Location = new System.Drawing.Point(182, 148);
            this.txtdoktorsoyad.Name = "txtdoktorsoyad";
            this.txtdoktorsoyad.Size = new System.Drawing.Size(199, 30);
            this.txtdoktorsoyad.TabIndex = 44;
            // 
            // txtdoktorad
            // 
            this.txtdoktorad.Location = new System.Drawing.Point(182, 95);
            this.txtdoktorad.Name = "txtdoktorad";
            this.txtdoktorad.Size = new System.Drawing.Size(199, 30);
            this.txtdoktorad.TabIndex = 43;
            // 
            // lblhastasoyad
            // 
            this.lblhastasoyad.AutoSize = true;
            this.lblhastasoyad.Location = new System.Drawing.Point(20, 155);
            this.lblhastasoyad.Name = "lblhastasoyad";
            this.lblhastasoyad.Size = new System.Drawing.Size(137, 23);
            this.lblhastasoyad.TabIndex = 40;
            this.lblhastasoyad.Text = "Doktor Soyad:";
            // 
            // lblhastaad
            // 
            this.lblhastaad.AutoSize = true;
            this.lblhastaad.Location = new System.Drawing.Point(53, 102);
            this.lblhastaad.Name = "lblhastaad";
            this.lblhastaad.Size = new System.Drawing.Size(104, 23);
            this.lblhastaad.TabIndex = 39;
            this.lblhastaad.Text = "Doktor Ad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(182, 264);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(199, 30);
            this.txtsifre.TabIndex = 38;
            // 
            // msktc
            // 
            this.msktc.Enabled = false;
            this.msktc.Location = new System.Drawing.Point(182, 209);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(199, 30);
            this.msktc.TabIndex = 37;
            this.msktc.ValidatingType = typeof(int);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(100, 267);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(57, 23);
            this.lblsifre.TabIndex = 36;
            this.lblsifre.Text = "Şifre:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(28, 209);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(129, 23);
            this.lbltc.TabIndex = 35;
            this.lbltc.Text = "TC Kimlik No:";
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 328);
            this.Controls.Add(this.llshastakayıtbaslık);
            this.Controls.Add(this.btnbilgiguncelle);
            this.Controls.Add(this.txtdoktorsoyad);
            this.Controls.Add(this.txtdoktorad);
            this.Controls.Add(this.lblhastasoyad);
            this.Controls.Add(this.lblhastaad);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llshastakayıtbaslık;
        private System.Windows.Forms.Button btnbilgiguncelle;
        private System.Windows.Forms.TextBox txtdoktorsoyad;
        private System.Windows.Forms.TextBox txtdoktorad;
        private System.Windows.Forms.Label lblhastasoyad;
        private System.Windows.Forms.Label lblhastaad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
    }
}