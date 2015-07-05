namespace PonyDancer
{
    partial class PonyManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PonyManager));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.posManager = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.windowBox = new System.Windows.Forms.ComboBox();
            this.clearWindowButton = new System.Windows.Forms.Button();
            this.progressBarEx1 = new ProgressBarEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(265, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hide CP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifier
            // 
            this.notifier.Icon = ((System.Drawing.Icon)(resources.GetObject("notifier.Icon")));
            this.notifier.Text = "Dancing Ponies";
            this.notifier.Visible = true;
            this.notifier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifier_MouseClick);
            // 
            // posManager
            // 
            this.posManager.Enabled = true;
            this.posManager.Interval = 1;
            this.posManager.Tick += new System.EventHandler(this.posManager_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBarEx1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearWindowButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.windowBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ride on Window";
            // 
            // windowBox
            // 
            this.windowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowBox.FormattingEnabled = true;
            this.windowBox.Location = new System.Drawing.Point(10, 32);
            this.windowBox.Name = "windowBox";
            this.windowBox.Size = new System.Drawing.Size(219, 21);
            this.windowBox.TabIndex = 5;
            this.windowBox.SelectionChangeCommitted += new System.EventHandler(this.windowBox_SelectionChangeCommitted);
            // 
            // clearWindowButton
            // 
            this.clearWindowButton.Location = new System.Drawing.Point(235, 32);
            this.clearWindowButton.Name = "clearWindowButton";
            this.clearWindowButton.Size = new System.Drawing.Size(105, 21);
            this.clearWindowButton.TabIndex = 7;
            this.clearWindowButton.Text = "Clear and Refresh";
            this.clearWindowButton.UseVisualStyleBackColor = true;
            this.clearWindowButton.Click += new System.EventHandler(this.clearWindowButton_Click);
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarEx1.Location = new System.Drawing.Point(3, 16);
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.Size = new System.Drawing.Size(341, 32);
            this.progressBarEx1.TabIndex = 3;
            // 
            // PonyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 172);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PonyManager";
            this.Text = "Dancing Ponies CP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBarEx progressBarEx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifier;
        private System.Windows.Forms.Timer posManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox windowBox;
        private System.Windows.Forms.Button clearWindowButton;
    }
}

