using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        Usuario[] ListaUsuarios = new Usuario[3];

        public Form1()
        {
            InitializeComponent();
            Usuario lucas = new Usuario("lucas@email.com", "123", "Lucas Feliciano", new DateTime(2002, 03, 04),true);
            Usuario pedro = new Usuario("pedrofeliciano467@email.com", "zorro","Pedro Feliciano", new DateTime(2000, 03, 01),true);
            Usuario osvaldo = new Usuario("osvaldo123@hmail.com", "paulao", "osvaldo oliveira", new DateTime(1999, 005, 07),false);
            Text = "Tela principal";


            ListaUsuarios[0] = lucas;
            ListaUsuarios[1] = pedro;
            ListaUsuarios[2] = osvaldo;
           


           // //instanciar classe
           // Pessoa lucas = new Pessoa(false,"lucas");


           // Pessoa pedro = new Pessoa(true,"Pedro");
           // Pessoa martina = new Pessoa(false, "Martina");

           // Pessoa[] array = new Pessoa[] 
           // {
           //     lucas ,pedro,martina, pedro, 
           // };

           // if (array.Length > 3)
           // {
           //     MessageBox.Show("INdice é maior que tres");
           // }
           // else
           // {
           //     MessageBox.Show("Indice é menor que tres");
           // }

           // //inicia          Checa a condiçao        repete
           //for(int indice = 0; indice < array.Length; indice = indice + 1)
           // {
           //     Pessoa pessoaAtual = array[indice];

           //     MessageBox.Show(pessoaAtual.Nome);
           // }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "pedro")
            //{
            //    MessageBox.Show("bem vindo pedro gay flex ");
            //}
            //else if (textBox1.Text == "lucas")
            //{
            //        MessageBox.Show("bem vindo jacare");

            //}
            //else
            //{
            //    MessageBox.Show("vc nao é o pedro nem o lucas fuck off bitch");
            //}
            for (int i = 0; i < ListaUsuarios.Length; i++)
            {
                //Pego o usuario corrente
                Usuario currentUser = ListaUsuarios[i];

                if (textBox1.Text == currentUser.Email && textBox2.Text == currentUser.Senha)
                {
                    MessageBox.Show("bem vindo ");
                    TelaPrincipalUsuarioComum telaPrincipal = new TelaPrincipalUsuarioComum(currentUser);
                    telaPrincipal.ShowDialog();
                }

            }

      
        }
    }
}
