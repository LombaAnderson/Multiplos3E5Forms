using System;
using System.Drawing;
using System.Windows.Forms;


namespace Multiplos3E5Forms
{
    public partial class Multiplos3E5 : Form
    {
        public Multiplos3E5()
        {
            InitializeComponent();
        }

        private void btn_clique_Click(object sender, EventArgs e)
        {
            var input = txt_Input.Text;

            int num = Convert.ToInt32(input);
             
            if (num % 3 == 0 && num % 5 == 0 && num <= 200)
                {
                    // Quando o número for divisivel por 3 e 5
                    lbl_Titulo.Text = "Z";
                    lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(lbl_Titulo);
                }
                else if (num % 3 != 0 && num % 5 == 0 && num <= 200)
                {
                    // Quando o número for divisivel por 5
                    lbl_Titulo.Text = "Y";
                    lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(lbl_Titulo);
                }
                else if (num % 3 == 0 && num % 5 != 0 && num <= 200)
                {
                    // Quando o número for divisivel por 3 
                    lbl_Titulo.Text = "X";
                    lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(lbl_Titulo);
                }
                else if (num % 3 != 0 && num % 5 != 0 && num <= 200)
                {
                   //Mensagem do Input caso o número não seja nem múltiplo de 3 nem 5);
                    lbl_Titulo.Text = input;
                    lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(lbl_Titulo);
                }
                else
                {
                   //Código que  mostra "Entrada inválida!" quando o número digitado é maior que 200);
                    lbl_Titulo.Text = "Entrada inválida";
                    lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(lbl_Titulo);
                }

            }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void textBox1_TextChanged_1(object sender, EventArgs e){}
        private void label5_Click(object sender, EventArgs e) {}
    }
}
       