using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security;
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
        private void SalvarClienteMysql()
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_clienteS;User=root;Password="))
            {
             

                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes(nome,documento,genero,rg,estado_civil,nasc,cep,endereco,numero,bairro,estado,celular,email,obs,situacao)   VALUES (@nome,@documento,@genero,@rg,@estado_civil,@nasc,@cep,@endereco,@numero,@bairro,@estado,@celular,@email,@obs,@situacao)";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@documento", txtDoc.Text);

                    if (opM.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Masculino");
                    }
                    else if (opF.Checked == true) 
                    {
                            cmd.Parameters.AddWithValue("@genero", "Feminino");

                        }
                        else
                        {

                        cmd.Parameters.AddWithValue("@genero", "Outros");
                    }
                    
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

                    if (ckeckAtivo.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@situacao", "Ativo");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@situacao", "Cancelado");
                    }
                   


                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("OK");

            }


        }




        private bool Validacoes()

        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("PREECHA  Campo   NOME obrigatorio");
                txtNome.Focus();
                return true;
            }

            //VALIDAR SE MARCOU CPF
            if (OpCpf.Checked == false && Opcnpj.Checked == false)
            {

                MessageBox.Show("Marque um tipo de documentacao\rCpf ou CNPJ ");
      
                return true;
            }
            if (txtDoc.Text == "")
            {
                MessageBox.Show("campo de dcumento e obrigatorio   ");
                txtDoc.Focus();
                return true;
            }

            // verifica  se pelo menos marcou alguma opcao de genero

            if (opM.Checked == false && opF.Checked == false && opO.Checked == false)
            {
                MessageBox.Show("Selecione o Genero que vc desejar");
                return true;   
            }

            return false;   
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (Validacoes() == true) { 
            return;
            }
        
            SalvarClienteMysql();
          
        }


    

    }

}

