namespace KurConvert
{
    partial class Kur
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
            this.cmbEnteredUnit = new System.Windows.Forms.ComboBox();
            this.txtEnteredValue = new System.Windows.Forms.TextBox();
            this.cmbResultUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculater = new System.Windows.Forms.Button();
            this.lblEnteredUnitPrice = new System.Windows.Forms.Label();
            this.lblResultUnitiPrice = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEnteredUnit
            // 
            this.cmbEnteredUnit.FormattingEnabled = true;
            this.cmbEnteredUnit.Location = new System.Drawing.Point(157, 104);
            this.cmbEnteredUnit.Name = "cmbEnteredUnit";
            this.cmbEnteredUnit.Size = new System.Drawing.Size(192, 21);
            this.cmbEnteredUnit.TabIndex = 0;
            // 
            // txtEnteredValue
            // 
            this.txtEnteredValue.Location = new System.Drawing.Point(51, 105);
            this.txtEnteredValue.Name = "txtEnteredValue";
            this.txtEnteredValue.Size = new System.Drawing.Size(100, 20);
            this.txtEnteredValue.TabIndex = 2;
            // 
            // cmbResultUnit
            // 
            this.cmbResultUnit.FormattingEnabled = true;
            this.cmbResultUnit.Location = new System.Drawing.Point(491, 101);
            this.cmbResultUnit.Name = "cmbResultUnit";
            this.cmbResultUnit.Size = new System.Drawing.Size(171, 21);
            this.cmbResultUnit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(355, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // btnCalculater
            // 
            this.btnCalculater.Location = new System.Drawing.Point(301, 191);
            this.btnCalculater.Name = "btnCalculater";
            this.btnCalculater.Size = new System.Drawing.Size(78, 38);
            this.btnCalculater.TabIndex = 6;
            this.btnCalculater.Text = "HESAPLA";
            this.btnCalculater.UseVisualStyleBackColor = true;
            this.btnCalculater.Click += new System.EventHandler(this.btnCalculater_Click);
            // 
            // lblEnteredUnitPrice
            // 
            this.lblEnteredUnitPrice.AutoEllipsis = true;
            this.lblEnteredUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnteredUnitPrice.Location = new System.Drawing.Point(157, 40);
            this.lblEnteredUnitPrice.Name = "lblEnteredUnitPrice";
            this.lblEnteredUnitPrice.Size = new System.Drawing.Size(192, 25);
            this.lblEnteredUnitPrice.TabIndex = 7;
            // 
            // lblResultUnitiPrice
            // 
            this.lblResultUnitiPrice.AutoEllipsis = true;
            this.lblResultUnitiPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResultUnitiPrice.Location = new System.Drawing.Point(491, 40);
            this.lblResultUnitiPrice.Name = "lblResultUnitiPrice";
            this.lblResultUnitiPrice.Size = new System.Drawing.Size(159, 25);
            this.lblResultUnitiPrice.TabIndex = 8;
            // 
            // lblResultValue
            // 
            this.lblResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResultValue.Location = new System.Drawing.Point(385, 101);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(100, 23);
            this.lblResultValue.TabIndex = 9;
            this.lblResultValue.Text = "Sonuc::::";
            // 
            // Kur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultValue);
            this.Controls.Add(this.lblResultUnitiPrice);
            this.Controls.Add(this.lblEnteredUnitPrice);
            this.Controls.Add(this.btnCalculater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResultUnit);
            this.Controls.Add(this.txtEnteredValue);
            this.Controls.Add(this.cmbEnteredUnit);
            this.Name = "Kur";
            this.Text = "Kur Dönüşümü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEnteredUnit;
        private System.Windows.Forms.TextBox txtEnteredValue;
        private System.Windows.Forms.ComboBox cmbResultUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculater;
        private System.Windows.Forms.Label lblEnteredUnitPrice;
        private System.Windows.Forms.Label lblResultUnitiPrice;
        private System.Windows.Forms.Label lblResultValue;
    }
}

