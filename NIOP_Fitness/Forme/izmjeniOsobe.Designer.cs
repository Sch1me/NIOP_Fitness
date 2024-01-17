namespace NIOP_Fitness.Forme
{
    partial class izmjeniOsobe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.OIBTxtBox = new System.Windows.Forms.TextBox();
            this.godineTxtBox = new System.Windows.Forms.TextBox();
            this.nazadButton = new System.Windows.Forms.Button();
            this.izmjeniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ime";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(308, 158);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 1;
            this.prezimeTextBox.Text = "Prezime";
            this.prezimeTextBox.TextChanged += new System.EventHandler(this.prezimeTextBox_TextChanged);
            // 
            // OIBTxtBox
            // 
            this.OIBTxtBox.Location = new System.Drawing.Point(308, 225);
            this.OIBTxtBox.Name = "OIBTxtBox";
            this.OIBTxtBox.Size = new System.Drawing.Size(100, 20);
            this.OIBTxtBox.TabIndex = 2;
            this.OIBTxtBox.Text = "OIB";
            this.OIBTxtBox.TextChanged += new System.EventHandler(this.OIBTxtBox_TextChanged);
            // 
            // godineTxtBox
            // 
            this.godineTxtBox.Location = new System.Drawing.Point(308, 286);
            this.godineTxtBox.Name = "godineTxtBox";
            this.godineTxtBox.Size = new System.Drawing.Size(100, 20);
            this.godineTxtBox.TabIndex = 3;
            this.godineTxtBox.Text = "Godine";
            this.godineTxtBox.TextChanged += new System.EventHandler(this.godineTxtBox_TextChanged);
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(327, 387);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(152, 51);
            this.nazadButton.TabIndex = 4;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // izmjeniButton
            // 
            this.izmjeniButton.Location = new System.Drawing.Point(61, 90);
            this.izmjeniButton.Name = "izmjeniButton";
            this.izmjeniButton.Size = new System.Drawing.Size(155, 216);
            this.izmjeniButton.TabIndex = 5;
            this.izmjeniButton.Text = "Izmjeni";
            this.izmjeniButton.UseVisualStyleBackColor = true;
            this.izmjeniButton.Click += new System.EventHandler(this.izmjeniButton_Click);
            // 
            // izmjeniOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.izmjeniButton);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.godineTxtBox);
            this.Controls.Add(this.OIBTxtBox);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.textBox1);
            this.Name = "izmjeniOsobe";
            this.Text = "izmjeniOsobe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox OIBTxtBox;
        private System.Windows.Forms.TextBox godineTxtBox;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button izmjeniButton;
    }
}