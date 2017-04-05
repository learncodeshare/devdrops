namespace LCS.DevDrops3
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
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.SwitchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(13, 13);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(259, 23);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Executar";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // SwitchButton
            // 
            this.SwitchButton.Location = new System.Drawing.Point(12, 42);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(259, 23);
            this.SwitchButton.TabIndex = 0;
            this.SwitchButton.Text = "Switch";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // SwitchTextBox
            // 
            this.SwitchTextBox.Location = new System.Drawing.Point(13, 72);
            this.SwitchTextBox.Name = "SwitchTextBox";
            this.SwitchTextBox.Size = new System.Drawing.Size(258, 20);
            this.SwitchTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.SwitchTextBox);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.TextBox SwitchTextBox;
    }
}

