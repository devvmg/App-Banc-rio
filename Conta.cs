using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBancario
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, string email, string aniv)
        {
            this.nome_cli = nome;
            this.cpf_cli = cpf;
            this.email_cli = email;
            this.aniv_cli = aniv;
        }
        public string cpf_cli   { get; set; }
        public string nome_cli  { get; set; }
        public string email_cli { get; set; }
        public string aniv_cli  { get; set; }

    }
    public class Conta
    {
        public Cliente titular_cc { get; set; }
        public int num_cc { get; set; }
        public double saldo_cc { get; set; }


        //MÉTODO -=-= SACAR =-=-
        public void Sacar(double valor_saque)
        {
            if (valor_saque < this.saldo_cc)
            {
                this.saldo_cc = this.saldo_cc - valor_saque;
                MessageBox.Show
                    (
                        "Saque realizado: \n" +
                        "R$" + valor_saque + " - Liberado!\n" +
                        "Aguarde a impressão da(s) cédula(s)."
                    );
            }
            else
            {
                MessageBox.Show
                    (
                        "Saldo insuficiente" +
                        "\nValor de R$" + valor_saque + " maior que seu saldo atual!"
                    ) ;
            }
        }

        //MÉTODO -=-= DEPOSITAR =-=-
        public void Depositar(bool verif , double valor_dep)
        {
            if (verif == true)
            {
                this.saldo_cc = this.saldo_cc + valor_dep;
                MessageBox.Show
                    (
                        "Depósito realizado: \n" +
                        "R$" + valor_dep + " !\n"
                    );
            }
            else { this.saldo_cc =+ valor_dep; }

            
        }
    }

}
