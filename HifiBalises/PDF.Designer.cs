namespace HifiBalises
{
    partial class PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PdfBalises = new AxAcroPDFLib.AxAcroPDF();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PdfBalises)).BeginInit();
            this.SuspendLayout();
            // 
            // PdfBalises
            // 
            this.PdfBalises.Enabled = true;
            this.PdfBalises.Location = new System.Drawing.Point(0, 35);
            this.PdfBalises.Margin = new System.Windows.Forms.Padding(2);
            this.PdfBalises.Name = "PdfBalises";
            this.PdfBalises.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PdfBalises.OcxState")));
            this.PdfBalises.Size = new System.Drawing.Size(701, 503);
            this.PdfBalises.TabIndex = 1;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(0, 7);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(111, 23);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "Imprimer";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(587, 7);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(702, 560);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.PdfBalises);
            this.Name = "PDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aperçu avant impression";
            ((System.ComponentModel.ISupportInitialize)(this.PdfBalises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxAcroPDFLib.AxAcroPDF PdfBalises;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnClose;
    }
}