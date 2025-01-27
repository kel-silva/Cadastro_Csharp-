using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    internal class Funcoes
    {

        public static void MsgError(string Msg)
            {
            MessageBox.Show(Msg, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        public static void MsgAlerta(string Msg)
        {
            MessageBox.Show(Msg, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //
        public static void MsgOK(string Msg)
        {
            MessageBox.Show(Msg, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool Pergunta(string Msg)
        {
            if (MessageBox.Show(Msg, "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else 
                return false;  
        }

        public static void priMaiuscula(Control ctr)

        {
            
                TextInfo TextInfo = new CultureInfo("pt-BR", false).TextInfo;
            ctr.Text = TextInfo.ToTitleCase(ctr.Text);

            if (ctr is TextBox txt)
            {
                txt.SelectionStart = txt.Text.Length;
            }else   if (ctr is ComboBox cb)
            {

                cb.SelectionStart = cb.Text.Length;

            }
        }

        public static DataTable BuscaSql(string ComandoSql)


        
        {
            DataTable dt = new DataTable();
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=base_clienteS;User=root;Password="))
            { 
            
            Conexao.Open();
                using (MySqlCommand cmd = Conexao.CreateCommand())
                {

                    cmd.CommandText = ComandoSql;   
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);         
                    
                    }
                }
           
            return dt;
            }


        }

        public static void carregarComboBox(ComboBox cb, string tabela, string campo)
        {
            cb.DataSource = Funcoes.BuscaSql("SELECT DISTINCT "+ campo+" FROM "+ tabela +" WHERE "+campo+" <> ''");
            cb.SelectedIndex = -1;

        }
    }
}
