
namespace Hastane_Proje2
{
    partial class FrmRandevuListesi
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
            this.dgrdvRandevuList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvRandevuList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdvRandevuList
            // 
            this.dgrdvRandevuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvRandevuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdvRandevuList.Location = new System.Drawing.Point(0, 0);
            this.dgrdvRandevuList.Name = "dgrdvRandevuList";
            this.dgrdvRandevuList.RowHeadersWidth = 51;
            this.dgrdvRandevuList.RowTemplate.Height = 24;
            this.dgrdvRandevuList.Size = new System.Drawing.Size(750, 400);
            this.dgrdvRandevuList.TabIndex = 0;
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.dgrdvRandevuList);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRandevuListesi";
            this.Text = "FrmRandevuListesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvRandevuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdvRandevuList;
    }
}