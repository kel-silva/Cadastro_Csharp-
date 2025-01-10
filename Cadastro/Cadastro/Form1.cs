using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_clienteS;User=root;Password="))
            {


                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand()) 
                    {
                    cmd.CommandText = "INSERT INTO clientes(nome,documento,genero,rg,estado_civil,nasc,cep,endereco,numero,bairro,estado,celular,email,obs,situacao)   VALUES (@nome,@documento,@genero,@rg,@estado_civil,@nasc,@cep,@endereco,@numero,@bairro,@estado,@celular,@email,@obs,@situacao)";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDoc.Text);
                    cmd.Parameters.AddWithValue("@genero", "Masculino");
                    cmd.Parameters.AddWithValue("@rg", txtRG.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", cbEstado_civil.Text);

                    //
                    

                    cmd.Parameters.AddWithValue("@nasc", Convert.ToDateTime  (txtNasc.Text));
                    //
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@endereco", cbEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", cbBairro.Text);
                    cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
                    cmd.Parameters.AddWithValue("@celular", txtFone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@obs", txtOBS.Text);
                    cmd.Parameters.AddWithValue("@situacao", "Ativo");


                    cmd.ExecuteNonQuery();  
                     }
                MessageBox.Show("OK");

            }
        }
        private void SalvarNoMysql()
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_clienteS;User=root;Password="))
            {


                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes(nome,documento,genero,rg,estado_civil,nasc,cep,endereco,numero,bairro,estado,celular,email,obs,situacao)   VALUES (@nome,@documento,@genero,@rg,@estado_civil,@nasc,@cep,@endereco,@numero,@bairro,@estado,@celular,@email,@obs,@situacao)";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDoc.Text);
                    cmd.Parameters.AddWithValue("@genero", "Masculino");
                    cmd.Parameters.AddWithValue("@rg", txtRG.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", cbEstado_civil.Text);

                    //


                    cmd.Parameters.AddWithValue("@nasc", Convert.ToDateTime(txtNasc.Text));
                    //
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@endereco", cbEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@bairro", cbBairro.Text);
                    cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
                    cmd.Parameters.AddWithValue("@celular", txtFone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@obs", txtOBS.Text);
                    cmd.Parameters.AddWithValue("@situacao", "Ativo");


                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("OK");

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalvarNoMysql();
        }
    }
}
