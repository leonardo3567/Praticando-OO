using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Conta
    {

        public int numero;
        public string titular;
        public double saldo = 100;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        

        public bool Saca(double valor)
        {

            if (this.saldo >= valor) {
                this.saldo -= valor;
                return true;
            }
            
            
                return false;
            
        }

        public void Tranfere(double valor, Conta destino) {
            if (this.Saca(valor)){

                destino.Deposita(valor);
            }

        }
    }
}
