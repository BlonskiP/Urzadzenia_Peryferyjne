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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SoundClick = new System.Windows.Forms.Button();
            this.fileDialogBtn = new System.Windows.Forms.Button();
            this.StopSound_btn = new System.Windows.Forms.Button();
            this.DirectSound_lb = new System.Windows.Forms.Label();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaPlayer_lb = new System.Windows.Forms.Label();
            this.startMicro = new System.Windows.Forms.Button();
            this.endMicro = new System.Windows.Forms.Button();
            this.MciPlayBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
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
            this.fileDialogBtn.Location = new System.Drawing.Point(12, 415);
            this.fileDialogBtn.Name = "fileDialogBtn";
            this.fileDialogBtn.Size = new System.Drawing.Size(124, 23);
            this.fileDialogBtn.TabIndex = 1;
            this.fileDialogBtn.Text = "ChooseFile";
            this.fileDialogBtn.UseVisualStyleBackColor = true;
            this.fileDialogBtn.Click += new System.EventHandler(this.fileDialogBtn_Click);
            // 
            // StopSound_btn
            // 
            this.StopSound_btn.Location = new System.Drawing.Point(12, 70);
            this.StopSound_btn.Name = "StopSound_btn";
            this.StopSound_btn.Size = new System.Drawing.Size(124, 23);
            this.StopSound_btn.TabIndex = 2;
            this.StopSound_btn.Text = "Stop Playing";
            this.StopSound_btn.UseVisualStyleBackColor = true;
            this.StopSound_btn.Click += new System.EventHandler(this.StopSound_btn_Click);
            // 
            // DirectSound_lb
            // 
            this.DirectSound_lb.AutoSize = true;
            this.DirectSound_lb.Location = new System.Drawing.Point(12, 25);
            this.DirectSound_lb.Name = "DirectSound_lb";
            this.DirectSound_lb.Size = new System.Drawing.Size(67, 13);
            this.DirectSound_lb.TabIndex = 3;
            this.DirectSound_lb.Text = "SoundPlayer";
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(210, 51);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(146, 42);
            this.mediaPlayer.TabIndex = 4;
            this.mediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MediaPlayer_lb
            // 
            this.MediaPlayer_lb.AutoSize = true;
            this.MediaPlayer_lb.Location = new System.Drawing.Point(207, 25);
            this.MediaPlayer_lb.Name = "MediaPlayer_lb";
            this.MediaPlayer_lb.Size = new System.Drawing.Size(68, 13);
            this.MediaPlayer_lb.TabIndex = 5;
            this.MediaPlayer_lb.Text = "Media Player";
            // 
            // startMicro
            // 
            this.startMicro.Location = new System.Drawing.Point(395, 41);
            this.startMicro.Name = "startMicro";
            this.startMicro.Size = new System.Drawing.Size(75, 23);
            this.startMicro.TabIndex = 6;
            this.startMicro.Text = "Nagrywaj";
            this.startMicro.UseVisualStyleBackColor = true;
            this.startMicro.Click += new System.EventHandler(this.button1_Click);
            // 
            // endMicro
            // 
            this.endMicro.Location = new System.Drawing.Point(395, 70);
            this.endMicro.Name = "endMicro";
            this.endMicro.Size = new System.Drawing.Size(75, 23);
            this.endMicro.TabIndex = 7;
            this.endMicro.Text = "Zakończ";
            this.endMicro.UseVisualStyleBackColor = true;
            this.endMicro.Click += new System.EventHandler(this.button2_Click);
            // 
            // MciPlayBtn
            // 
            this.MciPlayBtn.Location = new System.Drawing.Point(382, 186);
            this.MciPlayBtn.Name = "MciPlayBtn";
            this.MciPlayBtn.Size = new System.Drawing.Size(108, 23);
            this.MciPlayBtn.TabIndex = 8;
            this.MciPlayBtn.Text = "playSound Mci";
            this.MciPlayBtn.UseVisualStyleBackColor = true;
            this.MciPlayBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Resume";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MciPlayBtn);
            this.Controls.Add(this.endMicro);
            this.Controls.Add(this.startMicro);
            this.Controls.Add(this.MediaPlayer_lb);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.DirectSound_lb);
            this.Controls.Add(this.StopSound_btn);
            this.Controls.Add(this.fileDialogBtn);
            this.Controls.Add(this.SoundClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SoundClick;
        private System.Windows.Forms.Button fileDialogBtn;
        private System.Windows.Forms.Button StopSound_btn;
        private System.Windows.Forms.Label DirectSound_lb;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label MediaPlayer_lb;
        private System.Windows.Forms.Button startMicro;
        private System.Windows.Forms.Button endMicro;
        private System.Windows.Forms.Button MciPlayBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

