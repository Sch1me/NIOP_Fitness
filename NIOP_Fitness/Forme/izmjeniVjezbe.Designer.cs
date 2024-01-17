namespace NIOP_Fitness.Forme
{
    partial class izmjeniVjezbe
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
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.ponavljanjaTextBox = new System.Windows.Forms.TextBox();
            this.serijeTextBox = new System.Windows.Forms.TextBox();
            this.vrstaVjezbeTextBox = new System.Windows.Forms.TextBox();
            this.nazadButton = new System.Windows.Forms.Button();
            this.izmjeniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(300, 70);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(203, 20);
            this.imeTextBox.TabIndex = 0;
            this.imeTextBox.Text = "Ime vjezbe";
            this.imeTextBox.TextChanged += new System.EventHandler(this.imeTextBox_TextChanged);
            // 
            // ponavljanjaTextBox
            // 
            this.ponavljanjaTextBox.Location = new System.Drawing.Point(300, 127);
            this.ponavljanjaTextBox.Name = "ponavljanjaTextBox";
            this.ponavljanjaTextBox.Size = new System.Drawing.Size(203, 20);
            this.ponavljanjaTextBox.TabIndex = 1;
            this.ponavljanjaTextBox.Text = "Broj ponavljanja";
            this.ponavljanjaTextBox.TextChanged += new System.EventHandler(this.ponavljanjaTextBox_TextChanged);
            // 
            // serijeTextBox
            // 
            this.serijeTextBox.Location = new System.Drawing.Point(300, 188);
            this.serijeTextBox.Name = "serijeTextBox";
            this.serijeTextBox.Size = new System.Drawing.Size(203, 20);
            this.serijeTextBox.TabIndex = 2;
            this.serijeTextBox.Text = "Broj serija";
            this.serijeTextBox.TextChanged += new System.EventHandler(this.serijeTextBox_TextChanged);
            // 
            // vrstaVjezbeTextBox
            // 
            this.vrstaVjezbeTextBox.Location = new System.Drawing.Point(300, 257);
            this.vrstaVjezbeTextBox.Name = "vrstaVjezbeTextBox";
            this.vrstaVjezbeTextBox.Size = new System.Drawing.Size(203, 20);
            this.vrstaVjezbeTextBox.TabIndex = 3;
            this.vrstaVjezbeTextBox.Text = "Vrsta vjezbe";
            this.vrstaVjezbeTextBox.TextChanged += new System.EventHandler(this.vrstaVjezbeTextBox_TextChanged);
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(415, 383);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(142, 55);
            this.nazadButton.TabIndex = 4;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // izmjeniButton
            // 
            this.izmjeniButton.Location = new System.Drawing.Point(44, 70);
            this.izmjeniButton.Name = "izmjeniButton";
            this.izmjeniButton.Size = new System.Drawing.Size(198, 207);
            this.izmjeniButton.TabIndex = 5;
            this.izmjeniButton.Text = "Izmjeni";
            this.izmjeniButton.UseVisualStyleBackColor = true;
            this.izmjeniButton.Click += new System.EventHandler(this.izmjeniButton_Click);
            // 
            // izmjeniVjezbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.izmjeniButton);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.vrstaVjezbeTextBox);
            this.Controls.Add(this.serijeTextBox);
            this.Controls.Add(this.ponavljanjaTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Name = "izmjeniVjezbe";
            this.Text = "izmjeniVjezbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox ponavljanjaTextBox;
        private System.Windows.Forms.TextBox serijeTextBox;
        private System.Windows.Forms.TextBox vrstaVjezbeTextBox;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button izmjeniButton;
    }
}