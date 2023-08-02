
namespace Hastane_Proje2
{
    partial class FrmHastaBilgiGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiGüncelle));
            this.llshastakayıtbaslık = new System.Windows.Forms.Label();
            this.btnbilgiguncelle = new System.Windows.Forms.Button();
            this.cmbhastacinsiyet = new System.Windows.Forms.ComboBox();
            this.msktxttelefon = new System.Windows.Forms.MaskedTextBox();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.lblhastacinsiyet = new System.Windows.Forms.Label();
            this.lblhastatelefon = new System.Windows.Forms.Label();
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
            this.llshastakayıtbaslık.Location = new System.Drawing.Point(198, 21);
            this.llshastakayıtbaslık.Name = "llshastakayıtbaslık";
            this.llshastakayıtbaslık.Size = new System.Drawing.Size(352, 42);
            this.llshastakayıtbaslık.TabIndex = 34;
            this.llshastakayıtbaslık.Text = "Hasta Bilgi Güncelle";
            // 
            // btnbilgiguncelle
            // 
            this.btnbilgiguncelle.Location = new System.Drawing.Point(428, 177);
            this.btnbilgiguncelle.Name = "btnbilgiguncelle";
            this.btnbilgiguncelle.Size = new System.Drawing.Size(137, 81);
            this.btnbilgiguncelle.TabIndex = 33;
            this.btnbilgiguncelle.Text = "Bilgi Güncelle";
            this.btnbilgiguncelle.UseVisualStyleBackColor = true;
            this.btnbilgiguncelle.Click += new System.EventHandler(this.btnbilgiguncelle_Click);
            // 
            // cmbhastacinsiyet
            // 
            this.cmbhastacinsiyet.FormattingEnabled = true;
            this.cmbhastacinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbhastacinsiyet.Location = new System.Drawing.Point(191, 320);
            this.cmbhastacinsiyet.Name = "cmbhastacinsiyet";
            this.cmbhastacinsiyet.Size = new System.Drawing.Size(196, 31);
            this.cmbhastacinsiyet.TabIndex = 5;
            // 
            // msktxttelefon
            // 
            this.msktxttelefon.Location = new System.Drawing.Point(188, 253);
            this.msktxttelefon.Mask = "(999) 000-0000";
            this.msktxttelefon.Name = "msktxttelefon";
            this.msktxttelefon.Size = new System.Drawing.Size(199, 30);
            this.msktxttelefon.TabIndex = 4;
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Location = new System.Drawing.Point(188, 145);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(199, 30);
            this.txthastasoyad.TabIndex = 2;
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(188, 92);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(199, 30);
            this.txthastaad.TabIndex = 1;
            // 
            // lblhastacinsiyet
            // 
            this.lblhastacinsiyet.AutoSize = true;
            this.lblhastacinsiyet.Location = new System.Drawing.Point(11, 320);
            this.lblhastacinsiyet.Name = "lblhastacinsiyet";
            this.lblhastacinsiyet.Size = new System.Drawing.Size(142, 23);
            this.lblhastacinsiyet.TabIndex = 28;
            this.lblhastacinsiyet.Text = "Hasta Cinsiyet:";
            // 
            // lblhastatelefon
            // 
            this.lblhastatelefon.AutoSize = true;
            this.lblhastatelefon.Location = new System.Drawing.Point(24, 260);
            this.lblhastatelefon.Name = "lblhastatelefon";
            this.lblhastatelefon.Size = new System.Drawing.Size(136, 23);
            this.lblhastatelefon.TabIndex = 27;
            this.lblhastatelefon.Text = "Hasta Telefon:";
            // 
            // lblhastasoyad
            // 
            this.lblhastasoyad.AutoSize = true;
            this.lblhastasoyad.Location = new System.Drawing.Point(26, 152);
            this.lblhastasoyad.Name = "lblhastasoyad";
            this.lblhastasoyad.Size = new System.Drawing.Size(129, 23);
            this.lblhastasoyad.TabIndex = 26;
            this.lblhastasoyad.Text = "Hasta Soyad:";
            // 
            // lblhastaad
            // 
            this.lblhastaad.AutoSize = true;
            this.lblhastaad.Location = new System.Drawing.Point(66, 99);
            this.lblhastaad.Name = "lblhastaad";
            this.lblhastaad.Size = new System.Drawing.Size(96, 23);
            this.lblhastaad.TabIndex = 25;
            this.lblhastaad.Text = "Hasta Ad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(188, 372);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(199, 30);
            this.txtsifre.TabIndex = 6;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(188, 206);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(199, 30);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(104, 375);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(57, 23);
            this.lblsifre.TabIndex = 22;
            this.lblsifre.Text = "Şifre:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(24, 206);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(129, 23);
            this.lbltc.TabIndex = 21;
            this.lbltc.Text = "TC Kimlik No:";
            // 
            // FrmHastaBilgiGüncelle
            // 
            this.AcceptButton = this.btnbilgiguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(647, 454);
            this.Controls.Add(this.llshastakayıtbaslık);
            this.Controls.Add(this.btnbilgiguncelle);
            this.Controls.Add(this.cmbhastacinsiyet);
            this.Controls.Add(this.msktxttelefon);
            this.Controls.Add(this.txthastasoyad);
            this.Controls.Add(this.txthastaad);
            this.Controls.Add(this.lblhastacinsiyet);
            this.Controls.Add(this.lblhastatelefon);
            this.Controls.Add(this.lblhastasoyad);
            this.Controls.Add(this.lblhastaad);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHastaBilgiGüncelle";
            this.Text = "FrmBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmHastaBilgiGüncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llshastakayıtbaslık;
        private System.Windows.Forms.Button btnbilgiguncelle;
        private System.Windows.Forms.ComboBox cmbhastacinsiyet;
        private System.Windows.Forms.MaskedTextBox msktxttelefon;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label lblhastacinsiyet;
        private System.Windows.Forms.Label lblhastatelefon;
        private System.Windows.Forms.Label lblhastasoyad;
        private System.Windows.Forms.Label lblhastaad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
    }
}