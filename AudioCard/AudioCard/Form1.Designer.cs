namespace AudioCard
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoundClick = new System.Windows.Forms.Button();
            this.fileDialogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoundClick
            // 
            this.SoundClick.Location = new System.Drawing.Point(12, 41);
            this.SoundClick.Name = "SoundClick";
            this.SoundClick.Size = new System.Drawing.Size(124, 23);
            this.SoundClick.TabIndex = 0;
            this.SoundClick.Text = "Click to Sound";
            this.SoundClick.UseVisualStyleBackColor = true;
            this.SoundClick.Click += new System.EventHandler(this.SoundClick_Click);
            // 
            // fileDialogBtn
            // 
            this.fileDialogBtn.Location = new System.Drawing.Point(12, 12);
            this.fileDialogBtn.Name = "fileDialogBtn";
            this.fileDialogBtn.Size = new System.Drawing.Size(124, 23);
            this.fileDialogBtn.TabIndex = 1;
            this.fileDialogBtn.Text = "ChooseFile";
            this.fileDialogBtn.UseVisualStyleBackColor = true;
            this.fileDialogBtn.Click += new System.EventHandler(this.fileDialogBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileDialogBtn);
            this.Controls.Add(this.SoundClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoundClick;
        private System.Windows.Forms.Button fileDialogBtn;
    }
}

