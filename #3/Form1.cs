using System;
using System.Drawing;
using System.Windows.Forms;

namespace LCS.DevDrops3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            object a = "10";
            if (!(a is string b)) return;
            MessageBox.Show(b);
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            this.SwitchTest(this.SwitchTextBox.Text);
        }

        private void SwitchTest(object obj)
        {
            if (!(obj is null))
            {
                int i;
                if (int.TryParse(obj.ToString(), out i))
                    MessageBox.Show("Valor é um inteiro " + i);
            }

            switch (obj)
            {
                case null:
                    MessageBox.Show("Nada foi digitado");
                    break;
                case string a when int.TryParse(a, out int b):
                    MessageBox.Show("Valor é um inteiro " + b);
                    break;
                case int a:
                    MessageBox.Show("integer " + a);
                    break;
                case double a:
                    MessageBox.Show("double " + a);
                    break;
                default:
                    MessageBox.Show("Default");
                    break;
            }
        }
    }
}
