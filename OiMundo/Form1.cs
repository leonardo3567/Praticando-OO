using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";
            c.Deposita(100.0);

            Conta victor = new Conta();
            //init conta

            Conta guilherme = new Conta();

            victor.Tranfere(10,this, guilherme);


            if (c.Saca(100.0))
            {
                MessageBox.Show("Saque realizado com sucesso!");

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }



          

        }
    }
}
