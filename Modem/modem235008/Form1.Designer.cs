namespace modem235008
{
    partial class Form1
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
            this.PortsBtn = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.COMBox = new System.Windows.Forms.ComboBox();
            this.EnterCB = new System.Windows.Forms.CheckBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortsBtn
            // 
            this.PortsBtn.Location = new System.Drawing.Point(12, 12);
            this.PortsBtn.Name = "PortsBtn";
            this.PortsBtn.Size = new System.Drawing.Size(75, 23);
            this.PortsBtn.TabIndex = 0;
            this.PortsBtn.Text = "Ports";
            this.PortsBtn.UseVisualStyleBackColor = true;
            this.PortsBtn.Click += new System.EventHandler(this.PortsBtn_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 54);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(173, 20);
            this.messageBox.TabIndex = 1;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(110, 12);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // COMBox
            // 
            this.COMBox.FormattingEnabled = true;
            this.COMBox.Items.AddRange(new object[] {
            "TestItem"});
            this.COMBox.Location = new System.Drawing.Point(217, 53);
            this.COMBox.Name = "COMBox";
            this.COMBox.Size = new System.Drawing.Size(121, 21);
            this.COMBox.TabIndex = 3;
            this.COMBox.SelectedIndexChanged += new System.EventHandler(this.COMBox_SelectedIndexChanged);
            // 
            // EnterCB
            // 
            this.EnterCB.AutoSize = true;
            this.EnterCB.Location = new System.Drawing.Point(315, 18);
            this.EnterCB.Name = "EnterCB";
            this.EnterCB.Size = new System.Drawing.Size(51, 17);
            this.EnterCB.TabIndex = 4;
            this.EnterCB.Text = "Enter";
            this.EnterCB.UseVisualStyleBackColor = true;
            this.EnterCB.CheckedChanged += new System.EventHandler(this.EnterCB_CheckedChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(217, 12);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "SendFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.EnterCB);
            this.Controls.Add(this.COMBox);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.PortsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PortsBtn;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.ComboBox COMBox;
        private System.Windows.Forms.CheckBox EnterCB;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button button1;
    }
}

