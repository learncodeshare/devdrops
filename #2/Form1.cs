using System;
using System.Windows.Forms;

namespace LCS.DevDrops2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exemple1Button_Click(object sender, EventArgs e)
        {
            //Guid novoId;
            var valor = "123456789456123";

            if (Guid.TryParse(valor, out Guid novoId))
                this.ResultTextBox.Text = string.Format("Conversão com Sucesso, valor: {0} é um Guid válido", novoId.ToString()); 
            else
                this.ResultTextBox.Text = string.Format("Erro na Conversão, valor: {0} inválido", valor);
        }

        private void Exemple2Button_Click(object sender, EventArgs e)
        {
            //int novoNumero;
            var valor = "123456";

            if (int.TryParse(valor, out int novoNumero))
                this.ResultTextBox.Text = string.Format("Conversão com Sucesso, valor: {0} é um inteiro", novoNumero);
            else
                this.ResultTextBox.Text = string.Format("Erro na Conversão, valor: {0} inválido", valor);
        }

        private void Exemple3Button_Click(object sender, EventArgs e)
        {
            //int total;
            var v1 = 10;
            var v2 = 0;

            if (this.TryDivisao(v1, v2, out int total))
                this.ResultTextBox.Text = string.Format("Total ({0} / {1}): {2}", v1, v2, total);
            else
                this.ResultTextBox.Text = "Erro na Divisão, valores inválidos";
        }

        private bool TryDivisao(int v1, int v2, out int total)
        {
            try
            {
                total = v1 / v2;
                return true;
            }
            catch
            {
                total = -1;
                return false;
            }
        }
    }
}
