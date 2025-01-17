using System;
using System.Collections.Generic;
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
    }
}
