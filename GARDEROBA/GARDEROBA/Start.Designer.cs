namespace GARDEROBA
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.exit = new System.Windows.Forms.Button();
            this.Dalej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(681, 526);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 38);
            this.exit.TabIndex = 0;
            this.exit.Text = "Wyjdź";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Dalej
            // 
            this.Dalej.Location = new System.Drawing.Point(787, 526);
            this.Dalej.Name = "Dalej";
            this.Dalej.Size = new System.Drawing.Size(100, 38);
            this.Dalej.TabIndex = 1;
            this.Dalej.Text = "Rozpocznij";
            this.Dalej.UseVisualStyleBackColor = true;
            this.Dalej.Click += new System.EventHandler(this.Dalej_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 576);
            this.Controls.Add(this.Dalej);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Dalej;
    }
}