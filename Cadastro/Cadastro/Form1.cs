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

                     if (txtNasc.Text == "  /  /") 
                        cmd.Parameters.AddWithValue("@nasc", DBNull.Value);

                        else
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
                    cmd.CommandText = "SELECT @@IDENTITY";
                    txtId.Text = cmd.ExecuteScalar().ToString();
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
                MessageBox.Show("campo de documento e obrigatorio   ");
                txtDoc.Focus();
                return true;
            }

            // verifica  se pelo menos marcou alguma opcao de genero

            if (opM.Checked == false && opF.Checked == false && opO.Checked == false)
            {
                MessageBox.Show("PREECHA Genero uma das opcoes");
                txtNome.Focus();
                return true;
            }
            //validar se a data e valida
            if (txtNasc.Text != "  /  /")
            {
                try
                {
                    Convert.ToDateTime(txtNasc.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data de nascimento nao e valida");
                    return true;

                }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja de fato Limpar todos os campos ", "Crm Clientes", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            txtId.Text = "";
            txtNome.Text = "";
            OpCpf.Checked = false;
            Opcnpj.Checked = false; 

            opM.Checked = false;    
            opF.Checked = false;    
            opO.Checked = false;
            txtRG.Text = "";
            txtDoc.Text = "";
            txtCep.Text = "";
            cbEndereco.Text = "";
            txtNumero.Text = "";
            cbBairro.Text = "";
            cbCidade.Text = "";
            cbEstado.Text = "";
            txtFone.Text = "";
            txtEmail.Text = "";
            cbEstado_civil.Text = "";
            txtOBS.Text = "";


            ckeckAtivo.Checked = true;












        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }


}

