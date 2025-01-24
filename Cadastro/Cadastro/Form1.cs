﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
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
                MessageBox.Show("SUCESSO OK");

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
                   Funcoes.MsgError("Data de nascimento nao e valida");
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
            if (Funcoes.Pergunta("Deseja de fato limpar todos os campos ") == false)
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

        private void OpCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (OpCpf.Checked == true)
            {

                txtDoc.Mask = "0000,000,00-00";
                txtDoc.Focus();


            }
        }

        private void Opcnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (Opcnpj.Checked == true)
            {
                txtDoc.Mask = "00,000,000/0000-00";
                txtDoc.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void opM_CheckedChanged(object sender, EventArgs e)
        {
            txtRG.Focus();  
        }

        private void opF_CheckedChanged(object sender, EventArgs e)
        {
            txtRG.Focus();
        }

        private void opO_CheckedChanged(object sender, EventArgs e)
        {
            txtRG.Focus();
        }

        private void txtNasc_Validated(object sender, EventArgs e)
        {
          

            }

        private void txtNasc_Validating(object sender, CancelEventArgs e)
        {
            if (txtNasc.Text == "  /  /")
                return;

            try
            {
                txtNasc.Text = Convert.ToDateTime(txtNasc.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DAta invalida por favor escreva uma da ta valida");
                e.Cancel = true;

            }
        }

        private void cbEstado_civil_Validating(object sender, CancelEventArgs e)
        {
            if (cbEstado_civil.Text == "") ;
            return;


            if (cbEstado_civil.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o intem da lista");
                e.Cancel=true;  
            }

        }

        private void cbEstado_Validating(object sender, CancelEventArgs e)
        {
            if (cbEstado.Text == "") ;
            return;


            if (cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o intem da lista");
                e.Cancel = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(txtNome);

        }

        private void txtCep_Validating(object sender, CancelEventArgs e)
        {
            if (txtCep.Text.Length == 0)
                return;

            if (txtCep.Text.Length < 8)
            {
                MessageBox.Show("Informacao imcompleta DO CEP");
                e.Cancel = true;
            }
        }

        private void txtDoc_Validating(object sender, CancelEventArgs e)
        {

            if (txtDoc.Text == "")
                return;
            
            
            
            if (OpCpf.Checked == true && txtDoc.Text.Replace(" ", "").Length < 11 )
            {

                MessageBox.Show("Informacao imcompleta do cpf");
                e.Cancel = true;
            }

            if (Opcnpj.Checked == true && txtDoc.Text.Replace(" ", "").Length < 14)
            {

                MessageBox.Show("Informacao imcompleta do cnpj");
                e.Cancel = true;
            }
        }

        private void txtDoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Funcoes.MsgError("Texto da Messagem");
        }

        private void cbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEndereco_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(cbEndereco);

        }

        private void cbBairro_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(cbBairro);
        }

        private void cbCidade_TextChanged(object sender, EventArgs e)
        {
            Funcoes.priMaiuscula(cbCidade); 
        }

        private void btAddFoto_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "")

            {
                Funcoes.MsgError("Salve  os Dados do Cliente Primeiro");
                return; 
            
            }
            OpenFileDialog caixa = new OpenFileDialog();

            caixa.Filter = ("Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp");


            if (caixa.ShowDialog() == DialogResult.OK)
            {
            imgCliente.Image= Image.FromFile(caixa.FileName);
                File.Copy(caixa.FileName,AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtId.Text + ".png");
            
            }
            
        }

        private void btRemoverFoto_Click(object sender, EventArgs e)
        {

            /*  if (imgCliente.Image == Properties.Resources.businessman_icon_260nw_564112600) ;
              {
                  if (txtId.Text == "")
                  {
                      Funcoes.MsgError("Não ha foto para ser Removida");
                      return;
                  }

                  //file existis
                  if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtId.Text + ".png")) ;
                  {

                      Funcoes.MsgError("Não ha foto para Remover");
                      return;
                  }


              }

              if (Funcoes.Pergunta("Deseja de fato remover esta foto?") == false) return;
                   imgCliente.Image = Properties.Resources.businessman_icon_260nw_564112600;
                  File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtId.Text + ".png");
            */

            if (txtId.Text == "")
            {
                Funcoes.MsgError("Nao ha foto para ser removida");
                return;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtId.Text + ".png") == false)
            {

                Funcoes.MsgError("Nao ha fotos para remover");
                return;
            }


            if (Funcoes.Pergunta("Deseja de fato remover esta foto?") == false)
                return;
            imgCliente.Image = Properties.Resources.businessman_icon_260nw_564112600;
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/Fotos/" + txtId.Text + ".png");

        }
    }


}

