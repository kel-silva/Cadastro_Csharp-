using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmMenuClientes : Form
    {
        public FrmMenuClientes()
        {
            InitializeComponent();
        }
        string pastaFotos = AppDomain.CurrentDomain.BaseDirectory + "/Fotos/";

        private void btAdd_Click(object sender, EventArgs e)
        {
            FrmCadCliente frmcad = new FrmCadCliente(); 
            frmcad.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMenuClientes_Load(object sender, EventArgs e)
        {
            BuscarClientes();

           
            }

        private void dgLista_Sorted(object sender, EventArgs e)
        {
            ReorganizarDataGridView();
        }
        private void ReorganizarDataGridView()
        {
            foreach (DataGridViewRow lin in dgLista.Rows)
            {
                if (lin.Cells["situacao"].Value.ToString() == "Cancelado")
                {
                    lin.DefaultCellStyle.ForeColor = Color.Crimson;
                }

                if (File.Exists(pastaFotos + lin.Cells["id"].Value.ToString() + ".png"))
                {
                    lin.Cells["foto"].Value = Image.FromFile(pastaFotos + lin.Cells["id"].Value.ToString() + ".png");
                }
                else
                {

                    lin.Cells["foto"].Value = Properties.Resources.businessman_icon_260nw_564112600;
                }
               
            }
            dgLista.ClearSelection();
            btEditar.Enabled = false;
        }

        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
          FrmCadCliente frm = new FrmCadCliente();
            frm.txtId.Text = dgLista.CurrentRow.Cells["id"].Value.ToString();   
            
            
            
            frm.ShowDialog();
            BuscarClientes();
        }
        private void BuscarClientes()
        {

            dgLista.DataSource = Funcoes.BuscaSql("SELECT * FROM clientes WHERE 1 " + Gerarcriterios());


            ReorganizarDataGridView();
            Rodape();

        }

        private void PesqCod_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }
        private string Gerarcriterios()

        {
            string c = "";

            if (PesqCod.Text != string.Empty)

            {
                c += "AND id = " + PesqCod.Text;



            }
            if (PesqNome.Text != string.Empty)
            {

                c += $" AND (nome LIKE '%{PesqNome.Text}%'  OR documento LIKE '%{PesqNome.Text}%')";
            }
            //
            if (PesqGenero.Text != string.Empty)

            {
                c += $"AND genero = '{PesqGenero.Text}'";
            }
            if (PesqEstCivil.Text != string.Empty)

            {
                c += $"AND estado_civil = '{PesqEstCivil.Text}'";



            }

            if (PesqEnderecos.Text != string.Empty)
            {
                String e = PesqEnderecos.Text;
                c += $" AND (cep LIKE '%{e}%' OR endereco LIKE '%{e}%' OR numero LIKE '%{e}%' OR bairro LIKE '%{e}%' OR cidade LIKE '%{e}%' OR estado LIKE '%{e}%')";
            }


            try
            {
                DateTime data = Convert.ToDateTime(PesqNasc.Text);
                c += $" AND nasc = '{data:yyyy-MM-dd}'";
            }
            catch (Exception)
            {


            }
            if (PesqAtivo.Checked == true)
            {
                c += " AND situacao = 'Ativo' ";
            }
            else if (PesqCancelado.Checked == true)
            {

                
                    c += " AND situacao = 'Cancelado' ";
                
            } 


            //
            return c;

        }

        private void groupBox2_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PesqTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (PesqTodos.Checked == true)

            {

                BuscarClientes();
            }
        }

        private void PesqAtivo_CheckedChanged(object sender, EventArgs e)
        {

            if (PesqAtivo.Checked == true)

            {

                BuscarClientes();
            }
        }

        private void PesqCancelado_CheckedChanged(object sender, EventArgs e)
        {

            if (PesqCancelado.Checked == true)

            {

                BuscarClientes();
            }
        }
        private void Rodape()
        {
            lbltotal.Text = "Total Localizados ;" + dgLista.RowCount;


            int contador = 0;

            foreach (DataGridViewRow lin in dgLista.Rows)
            {

                if (lin.Cells["situacao"].Value.ToString() ==  "Cancelado" )
                    contador++;
            }
            lblTotalCancelados.Text = "Total Cancelados ;" + contador.ToString();
            lbltotalAtivos.Text = "Total Ativos " + (dgLista.RowCount - contador).ToString();
        }

        private void FrmMenuClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgLista.DataSource = Funcoes.BuscaSql("SELECT * FROM clientes WHERE 1 ");
        }
    }
    }

