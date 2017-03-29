namespace LCS.DevDrops2
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
            this.Exemple1Button = new System.Windows.Forms.Button();
            this.Exemple2Button = new System.Windows.Forms.Button();
            this.Exemple3Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exemple1Button
            // 
            this.Exemple1Button.Location = new System.Drawing.Point(13, 13);
            this.Exemple1Button.Name = "Exemple1Button";
            this.Exemple1Button.Size = new System.Drawing.Size(668, 23);
            this.Exemple1Button.TabIndex = 0;
            this.Exemple1Button.Text = "Exemplo 1";
            this.Exemple1Button.UseVisualStyleBackColor = true;
            this.Exemple1Button.Click += new System.EventHandler(this.Exemple1Button_Click);
            // 
            // Exemple2Button
            // 
            this.Exemple2Button.Location = new System.Drawing.Point(12, 42);
            this.Exemple2Button.Name = "Exemple2Button";
            this.Exemple2Button.Size = new System.Drawing.Size(668, 23);
            this.Exemple2Button.TabIndex = 0;
            this.Exemple2Button.Text = "Exemplo 2";
            this.Exemple2Button.UseVisualStyleBackColor = true;
            this.Exemple2Button.Click += new System.EventHandler(this.Exemple2Button_Click);
            // 
            // Exemple3Button
            // 
            this.Exemple3Button.Location = new System.Drawing.Point(12, 71);
            this.Exemple3Button.Name = "Exemple3Button";
            this.Exemple3Button.Size = new System.Drawing.Size(668, 23);
            this.Exemple3Button.TabIndex = 0;
            this.Exemple3Button.Text = "Exemplo 3";
            this.Exemple3Button.UseVisualStyleBackColor = true;
            this.Exemple3Button.Click += new System.EventHandler(this.Exemple3Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(13, 118);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(667, 20);
            this.ResultTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 160);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exemple3Button);
            this.Controls.Add(this.Exemple2Button);
            this.Controls.Add(this.Exemple1Button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn. Code. Share! DevDrops2 - Out Variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exemple1Button;
        private System.Windows.Forms.Button Exemple2Button;
        private System.Windows.Forms.Button Exemple3Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

