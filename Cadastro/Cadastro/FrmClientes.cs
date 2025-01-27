using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            dgLista.DataSource = Funcoes.BuscaSql("SELECT * FROM clientes");
        }
    }
}
