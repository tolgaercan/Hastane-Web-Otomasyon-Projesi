
namespace Hastane_Proje2
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblhastaad = new System.Windows.Forms.Label();
            this.lblhastasoyad = new System.Windows.Forms.Label();
            this.lblhastatelefon = new System.Windows.Forms.Label();
            this.lblhastacinsiyet = new System.Windows.Forms.Label();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.msktxttelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbhastacinsiyet = new System.Windows.Forms.ComboBox();
            this.btnkayıtyap = new System.Windows.Forms.Button();
            this.llshastakayıtbaslık = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(179, 384);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(199, 34);
            this.txtsifre.TabIndex = 6;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(179, 218);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(199, 34);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(95, 387);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(68, 27);
            this.lblsifre.TabIndex = 8;
            this.lblsifre.Text = "Şifre:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(15, 218);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(158, 27);
            this.lbltc.TabIndex = 7;
            this.lbltc.Text = "TC Kimlik No:";
            // 
            // lblhastaad
            // 
            this.lblhastaad.AutoSize = true;
            this.lblhastaad.Location = new System.Drawing.Point(57, 111);
            this.lblhastaad.Name = "lblhastaad";
            this.lblhastaad.Size = new System.Drawing.Size(116, 27);
            this.lblhastaad.TabIndex = 11;
            this.lblhastaad.Text = "Hasta Ad:";
            // 
            // lblhastasoyad
            // 
            this.lblhastasoyad.AutoSize = true;
            this.lblhastasoyad.Location = new System.Drawing.Point(17, 164);
            this.lblhastasoyad.Name = "lblhastasoyad";
            this.lblhastasoyad.Size = new System.Drawing.Size(156, 27);
            this.lblhastasoyad.TabIndex = 12;
            this.lblhastasoyad.Text = "Hasta Soyad:";
            // 
            // lblhastatelefon
            // 
            this.lblhastatelefon.AutoSize = true;
            this.lblhastatelefon.Location = new System.Drawing.Point(15, 272);
            this.lblhastatelefon.Name = "lblhastatelefon";
            this.lblhastatelefon.Size = new System.Drawing.Size(165, 27);
            this.lblhastatelefon.TabIndex = 13;
            this.lblhastatelefon.Text = "Hasta Telefon:";
            // 
            // lblhastacinsiyet
            // 
            this.lblhastacinsiyet.AutoSize = true;
            this.lblhastacinsiyet.Location = new System.Drawing.Point(2, 332);
            this.lblhastacinsiyet.Name = "lblhastacinsiyet";
            this.lblhastacinsiyet.Size = new System.Drawing.Size(173, 27);
            this.lblhastacinsiyet.TabIndex = 14;
            this.lblhastacinsiyet.Text = "Hasta Cinsiyet:";
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(179, 104);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(199, 34);
            this.txthastaad.TabIndex = 1;
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Location = new System.Drawing.Point(179, 157);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(199, 34);
            this.txthastasoyad.TabIndex = 2;
            // 
            // msktxttelefon
            // 
            this.msktxttelefon.Location = new System.Drawing.Point(179, 265);
            this.msktxttelefon.Mask = "(999) 000-0000";
            this.msktxttelefon.Name = "msktxttelefon";
            this.msktxttelefon.Size = new System.Drawing.Size(199, 34);
            this.msktxttelefon.TabIndex = 4;
            // 
            // cmbhastacinsiyet
            // 
            this.cmbhastacinsiyet.FormattingEnabled = true;
            this.cmbhastacinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbhastacinsiyet.Location = new System.Drawing.Point(182, 332);
            this.cmbhastacinsiyet.Name = "cmbhastacinsiyet";
            this.cmbhastacinsiyet.Size = new System.Drawing.Size(196, 34);
            this.cmbhastacinsiyet.TabIndex = 5;
            // 
            // btnkayıtyap
            // 
            this.btnkayıtyap.Location = new System.Drawing.Point(488, 218);
            this.btnkayıtyap.Name = "btnkayıtyap";
            this.btnkayıtyap.Size = new System.Drawing.Size(137, 81);
            this.btnkayıtyap.TabIndex = 19;
            this.btnkayıtyap.Text = "Kayıt Yap";
            this.btnkayıtyap.UseVisualStyleBackColor = true;
            this.btnkayıtyap.Click += new System.EventHandler(this.btnkayıtyap_Click);
            // 
            // llshastakayıtbaslık
            // 
            this.llshastakayıtbaslık.AutoSize = true;
            this.llshastakayıtbaslık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llshastakayıtbaslık.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llshastakayıtbaslık.Location = new System.Drawing.Point(271, 32);
            this.llshastakayıtbaslık.Name = "llshastakayıtbaslık";
            this.llshastakayıtbaslık.Size = new System.Drawing.Size(210, 42);
            this.llshastakayıtbaslık.TabIndex = 20;
            this.llshastakayıtbaslık.Text = "Hasta Kayıt";
            // 
            // FrmHastaKayıt
            // 
            this.AcceptButton = this.btnkayıtyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.llshastakayıtbaslık);
            this.Controls.Add(this.btnkayıtyap);
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
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayıt";
            this.Text = "FrmHastaKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblhastaad;
        private System.Windows.Forms.Label lblhastasoyad;
        private System.Windows.Forms.Label lblhastatelefon;
        private System.Windows.Forms.Label lblhastacinsiyet;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.MaskedTextBox msktxttelefon;
        private System.Windows.Forms.ComboBox cmbhastacinsiyet;
        private System.Windows.Forms.Button btnkayıtyap;
        private System.Windows.Forms.Label llshastakayıtbaslık;
    }
}