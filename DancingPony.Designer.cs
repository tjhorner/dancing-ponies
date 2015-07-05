namespace PonyDancer
{
    partial class DancingPony
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
            this.renderTick = new System.Windows.Forms.Timer(this.components);
            this.skinRandomizerTick = new System.Windows.Forms.Timer(this.components);
            this.ponyImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ponyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // renderTick
            // 
            this.renderTick.Interval = 50;
            this.renderTick.Tick += new System.EventHandler(this.renderTick_Tick);
            // 
            // skinRandomizerTick
            // 
            this.skinRandomizerTick.Interval = 30000;
            this.skinRandomizerTick.Tick += new System.EventHandler(this.skinRandomizerTick_Tick);
            // 
            // ponyImage
            // 
            this.ponyImage.BackColor = System.Drawing.Color.Lime;
            this.ponyImage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ponyImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ponyImage.Image = global::PonyDancer.Twilight.stand_right;
            this.ponyImage.Location = new System.Drawing.Point(0, 0);
            this.ponyImage.Name = "ponyImage";
            this.ponyImage.Size = new System.Drawing.Size(158, 162);
            this.ponyImage.TabIndex = 0;
            this.ponyImage.TabStop = false;
            // 
            // DancingPony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(158, 162);
            this.Controls.Add(this.ponyImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DancingPony";
            this.ShowInTaskbar = false;
            this.Text = "PonyForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.ponyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ponyImage;
        private System.Windows.Forms.Timer renderTick;
        private System.Windows.Forms.Timer skinRandomizerTick;
    }
}