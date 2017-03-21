using System;
using System.Windows.Forms;

namespace LCS.DevDrops1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TuplesButton_Click(object sender, EventArgs e)
        {
            var result = this.SumOddsAndEvens(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            MessageBox.Show(string.Format("Pares: {0}\nImpares: {1} ", result.somaPares, result.somaImpares));
        }

        private (int somaPares, int somaImpares) SumOddsAndEvens(int[] numbers)
        {
            int somaPares = 0, somaImpares = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    somaPares += number;
                else
                    somaImpares += number;
            }

            return (somaPares, somaImpares);
        }

        //private void TuplesButton_Click(object sender, EventArgs e)
        //{
        //    var result = this.SumOddsAndEvens(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        //    MessageBox.Show(string.Format("Pares: {0}\nImpares: {1} ", result.Item1, result.Item2));
        //}

        //private Tuple<int, int> SumOddsAndEvens(int[] numbers)
        //{
        //    int somaPares = 0, somaImpares = 0;
        //    foreach (var number in numbers)
        //    {
        //        if (number % 2 == 0)
        //            somaPares += number;
        //        else
        //            somaImpares += number;
        //    }

        //    return new Tuple<int, int>(somaPares, somaImpares);
        //}
    }
}
