namespace LCS.DevDrops1
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
            this.TuplesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TuplesButton
            // 
            this.TuplesButton.Location = new System.Drawing.Point(12, 12);
            this.TuplesButton.Name = "TuplesButton";
            this.TuplesButton.Size = new System.Drawing.Size(260, 23);
            this.TuplesButton.TabIndex = 0;
            this.TuplesButton.Text = "Tuples";
            this.TuplesButton.UseVisualStyleBackColor = true;
            this.TuplesButton.Click += new System.EventHandler(this.TuplesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 52);
            this.Controls.Add(this.TuplesButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TuplesButton;
    }
}

