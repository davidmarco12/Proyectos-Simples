using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double memoria = 0.0;
        double memoria_MS = 0.0;
        double temp = 0.0;
        bool pres = false;
        int con = 0;
        char ope;
        double porcen;
        bool positivo = true;



        public Form1()
        {
            InitializeComponent();
        }

        //numero 6
        private void button18_Click(object sender, EventArgs e)
        {
            numeros("6");
        }

        private void cero_Click(object sender, EventArgs e)
        {
            if (lblNum.Text != "0") {
                numeros("0");
            }
        }

        private void uno_Click(object sender, EventArgs e)
        {
            numeros("1");
        }

        private void dos_Click(object sender, EventArgs e)
        {
            numeros("2");
        }

        private void tres_Click(object sender, EventArgs e)
        {
            numeros("3");
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            numeros("4");

        }

        private void cinco_Click(object sender, EventArgs e)
        {
            numeros("5");
        }

        private void siete_Click(object sender, EventArgs e)
        {
            numeros("7");
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            numeros("8");
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            numeros("9");
        }



        private void suma_Click(object sender, EventArgs e)
        {
            ope = '+';
            realizar_operacion();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            ope = '-';
            realizar_operacion();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            ope = '*';
            realizar_operacion();
        }

        private void div_Click(object sender, EventArgs e)
        {
            ope = '/';
            realizar_operacion();
        }



        private void porcentaje_Click(object sender, EventArgs e)
        {
            ope = '%';
            if (con == 0) {
                porcen = Convert.ToDouble(lblNum.Text) / 100;

                lblNum.Text = "";
            }
            if (con > 0) {
                memoria = Convert.ToDouble(lblNum.Text);
                memoria = memoria * porcen;
                lblNum.Text = "" + memoria;
            }
            con++;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            double num_temp;

            if (lblNum.Text.Length > 0) {

                num_temp = Convert.ToDouble(lblNum.Text);

            }
        }

        public void realizar_operacion() {
            con++;
            if (positivo == false) {
                temp = temp * -1;
                positivo = true;
            }

            if (con == 1) {
                memoria = temp;
                lblNum.Text = "";
                temp = 0.0;
            }

            if (con > 1 && pres == true) {

                switch (ope) {
                    case '+': memoria = memoria + temp;
                        break;
                    case '-': memoria = memoria - temp;
                        break;
                    case '*': memoria = memoria * temp;
                        break;
                    case '/': memoria = memoria / temp;
                        break;

                }

                lblNum.Text = "" + memoria;
                temp = 0.0;
                pres = false;

            }

        }

        public void numeros(string n) {
            if (pres == false) {

                lblNum.Text = "";
            }

            lblNum.Text = lblNum.Text + n;
            temp = Convert.ToDouble(lblNum.Text);
            pres = true;

        }

        private void igual_Click(object sender, EventArgs e)
        {
            switch (ope) {
                case '+': memoria = memoria + temp;
                    break;
                case '-':
                    memoria = memoria - temp;
                    break;
                case '*':
                    memoria = memoria * temp;
                    break;
                case '/':
                    memoria = memoria / temp;
                    break;
                case '%':
                    memoria = Convert.ToDouble(lblNum.Text);
                    memoria = memoria * porcen;
                    break;
            }

            lblNum.Text = "" + memoria;
            pres = false;


        }

        private void borrarNum_Click(object sender, EventArgs e)
        {
            string dato_temp = "";

            if (lblNum.Text.Length > 1)
            {

                for (int i = 0; i < lblNum.Text.Length - 1; i++)
                {

                    dato_temp = dato_temp + lblNum.Text[i];
                }

                lblNum.Text = dato_temp;
                temp = Convert.ToDouble(lblNum.Text);
            }
            else {

                lblNum.Text = "0";
                temp = 0.0;
            }
        }





        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria_MS = 0.0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            lblNum.Text = "" + memoria_MS;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (lblNum.Text != "" )
                memoria_MS = Convert.ToDouble(lblNum.Text);
            lblNum.Text = "M";
        }

        private void btnMmas_Click(object sender, EventArgs e)
        {
            if (lblNum.Text != "")
                memoria_MS = memoria_MS + Convert.ToDouble(lblNum.Text);
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
            if (lblNum.Text != "")
                memoria_MS = memoria_MS - Convert.ToDouble(lblNum.Text);
        }

        private void coma_Click(object sender, EventArgs e)
        {
            lblNum.Text = lblNum.Text + ".";
        }

        private void borrarAct_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
            positivo = true;
        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
            memoria = 0.0;
            temp = 0.0;
            pres = false;
            con = 0;
            ope = ' ';
            positivo = true;

        }

        private void Signo_Click(object sender, EventArgs e)
        {
            double num_temp;

            if(lblNum.Text.Length > 0){
                num_temp = Convert.ToDouble(lblNum.Text) * -1;
                lblNum.Text = Convert.ToString(num_temp);
                positivo = !positivo;

            }
        }

        private void Inverso_Click(object sender, EventArgs e)
        {
            if (lblNum.Text != "") {
                temp = Convert.ToDouble(lblNum.Text);
                temp = 1 / temp;
                lblNum.Text = "" + temp;

            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como vera, esta es una version nueva y muy simple, no se espera que sea nada complicado","Ayuda",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 0.1", "Version", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
