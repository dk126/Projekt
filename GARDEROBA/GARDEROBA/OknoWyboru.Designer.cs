namespace GARDEROBA
{
    partial class OknoWyboru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoWyboru));
            this.Wyjdz = new System.Windows.Forms.Button();
            this.Kreacja = new System.Windows.Forms.GroupBox();
            this.Casual = new System.Windows.Forms.RadioButton();
            this.specjalnyDzien = new System.Windows.Forms.RadioButton();
            this.pogoda = new System.Windows.Forms.GroupBox();
            this.Zimno = new System.Windows.Forms.RadioButton();
            this.Cieplo = new System.Windows.Forms.RadioButton();
            this.Dalej = new System.Windows.Forms.Button();
            this.Kreacja.SuspendLayout();
            this.pogoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wyjdz
            // 
            this.Wyjdz.Location = new System.Drawing.Point(681, 526);
            this.Wyjdz.Name = "Wyjdz";
            this.Wyjdz.Size = new System.Drawing.Size(100, 38);
            this.Wyjdz.TabIndex = 0;
            this.Wyjdz.Text = "Wyjdź";
            this.Wyjdz.UseVisualStyleBackColor = true;
            this.Wyjdz.Click += new System.EventHandler(this.Wyjdz_Click);
            // 
            // Kreacja
            // 
            this.Kreacja.BackColor = System.Drawing.Color.Transparent;
            this.Kreacja.Controls.Add(this.Casual);
            this.Kreacja.Controls.Add(this.specjalnyDzien);
            this.Kreacja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Kreacja.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Kreacja.Location = new System.Drawing.Point(125, 93);
            this.Kreacja.Margin = new System.Windows.Forms.Padding(2);
            this.Kreacja.Name = "Kreacja";
            this.Kreacja.Padding = new System.Windows.Forms.Padding(2);
            this.Kreacja.Size = new System.Drawing.Size(219, 84);
            this.Kreacja.TabIndex = 3;
            this.Kreacja.TabStop = false;
            this.Kreacja.Text = "Jakiej kreacji potrzebujesz?";
            // 
            // Casual
            // 
            this.Casual.AutoSize = true;
            this.Casual.Location = new System.Drawing.Point(20, 52);
            this.Casual.Name = "Casual";
            this.Casual.Size = new System.Drawing.Size(94, 20);
            this.Casual.TabIndex = 4;
            this.Casual.TabStop = true;
            this.Casual.Text = "Na codzień";
            this.Casual.UseVisualStyleBackColor = true;
            // 
            // specjalnyDzien
            // 
            this.specjalnyDzien.AutoSize = true;
            this.specjalnyDzien.Location = new System.Drawing.Point(20, 26);
            this.specjalnyDzien.Name = "specjalnyDzien";
            this.specjalnyDzien.Size = new System.Drawing.Size(147, 20);
            this.specjalnyDzien.TabIndex = 1;
            this.specjalnyDzien.TabStop = true;
            this.specjalnyDzien.Text = "Na specjalną okazję";
            this.specjalnyDzien.UseVisualStyleBackColor = true;
            // 
            // pogoda
            // 
            this.pogoda.BackColor = System.Drawing.Color.Transparent;
            this.pogoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pogoda.Controls.Add(this.Zimno);
            this.pogoda.Controls.Add(this.Cieplo);
            this.pogoda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.pogoda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pogoda.Location = new System.Drawing.Point(417, 93);
            this.pogoda.Margin = new System.Windows.Forms.Padding(2);
            this.pogoda.Name = "pogoda";
            this.pogoda.Padding = new System.Windows.Forms.Padding(2);
            this.pogoda.Size = new System.Drawing.Size(219, 84);
            this.pogoda.TabIndex = 4;
            this.pogoda.TabStop = false;
            this.pogoda.Text = "Jaka jest dziś pogoda ? ";
            // 
            // Zimno
            // 
            this.Zimno.AutoSize = true;
            this.Zimno.Location = new System.Drawing.Point(6, 54);
            this.Zimno.Name = "Zimno";
            this.Zimno.Size = new System.Drawing.Size(118, 20);
            this.Zimno.TabIndex = 1;
            this.Zimno.TabStop = true;
            this.Zimno.Text = "Zimno ( < 15°C )";
            this.Zimno.UseVisualStyleBackColor = true;
            // 
            // Cieplo
            // 
            this.Cieplo.AutoSize = true;
            this.Cieplo.Location = new System.Drawing.Point(6, 26);
            this.Cieplo.Name = "Cieplo";
            this.Cieplo.Size = new System.Drawing.Size(123, 20);
            this.Cieplo.TabIndex = 0;
            this.Cieplo.TabStop = true;
            this.Cieplo.Text = "Ciepło ( > 15°C )";
            this.Cieplo.UseVisualStyleBackColor = true;
            // 
            // Dalej
            // 
            this.Dalej.Location = new System.Drawing.Point(787, 526);
            this.Dalej.Name = "Dalej";
            this.Dalej.Size = new System.Drawing.Size(100, 38);
            this.Dalej.TabIndex = 5;
            this.Dalej.Text = "Przejdź dalej";
            this.Dalej.UseVisualStyleBackColor = true;
            this.Dalej.Click += new System.EventHandler(this.Dalej_Click);
            // 
            // OknoWyboru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 576);
            this.Controls.Add(this.Dalej);
            this.Controls.Add(this.pogoda);
            this.Controls.Add(this.Kreacja);
            this.Controls.Add(this.Wyjdz);
            this.DoubleBuffered = true;
            this.Name = "OknoWyboru";
            this.Text = "OknoWyboru";
            this.Load += new System.EventHandler(this.OknoWyboru_Load);
            this.Kreacja.ResumeLayout(false);
            this.Kreacja.PerformLayout();
            this.pogoda.ResumeLayout(false);
            this.pogoda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wyjdz;
        private System.Windows.Forms.GroupBox Kreacja;
        private System.Windows.Forms.RadioButton Casual;
        private System.Windows.Forms.RadioButton specjalnyDzien;
        private System.Windows.Forms.GroupBox pogoda;
        private System.Windows.Forms.RadioButton Zimno;
        private System.Windows.Forms.RadioButton Cieplo;
        private System.Windows.Forms.Button Dalej;
    }
}