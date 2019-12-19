namespace Proje_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_RastgeleMatrisOlustur = new System.Windows.Forms.Button();
            this.button_MatrisOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_RastgeleMatrisOlustur
            // 
            this.button_RastgeleMatrisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_RastgeleMatrisOlustur.Location = new System.Drawing.Point(139, 117);
            this.button_RastgeleMatrisOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RastgeleMatrisOlustur.Name = "button_RastgeleMatrisOlustur";
            this.button_RastgeleMatrisOlustur.Size = new System.Drawing.Size(481, 118);
            this.button_RastgeleMatrisOlustur.TabIndex = 1;
            this.button_RastgeleMatrisOlustur.Text = "Rastgele Matris Oluştur";
            this.button_RastgeleMatrisOlustur.UseVisualStyleBackColor = true;
            this.button_RastgeleMatrisOlustur.Click += new System.EventHandler(this.button_RastgeleMatrisOlustur_Click);
            // 
            // button_MatrisOlustur
            // 
            this.button_MatrisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MatrisOlustur.Location = new System.Drawing.Point(139, 256);
            this.button_MatrisOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_MatrisOlustur.Name = "button_MatrisOlustur";
            this.button_MatrisOlustur.Size = new System.Drawing.Size(481, 110);
            this.button_MatrisOlustur.TabIndex = 2;
            this.button_MatrisOlustur.Text = "Kullanici Girişli Matris Oluştur";
            this.button_MatrisOlustur.UseVisualStyleBackColor = true;
            this.button_MatrisOlustur.Click += new System.EventHandler(this.button_MatrisOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matris Oluşturma Yönetimi Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_MatrisOlustur);
            this.Controls.Add(this.button_RastgeleMatrisOlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RastgeleMatrisOlustur;
        private System.Windows.Forms.Button button_MatrisOlustur;
        private System.Windows.Forms.Label label1;
    }
}

