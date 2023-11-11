using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37652_cnh
{
    public partial class frm37652_cnh : Form
    {
        public frm37652_cnh()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            #region Tratamento de erro
            if (string.IsNullOrEmpty(txtcnh.Text)) 
            {
                MessageBox.Show("Caixa de texto vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcnh.Focus();
                return;
            }
            if (txtcnh.TextLength < 11)
            {
                MessageBox.Show("Para validar o cnh é necessário os 11 digitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcnh.Focus();
                return;
            }
            #endregion

            #region Validação
            try
            {
               string cnh = txtcnh.Text.Trim().Replace(".","").Replace(",","").Replace("-","").Replace("/","").Replace("_","");
               lblResultado.Text = cls37652_cnh.Validar(cnh)? "Válido": "inválido";
            }
            catch 
            {
                MessageBox.Show("Erro inesperado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcnh.Clear();
                lblResultado.Text = "";
                txtcnh.Focus();
                return;
            }
            #endregion

       
        }

        private void txtcnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete &&
                e.KeyChar != (char)3 && e.KeyChar != (char)22)
            {
                e.Handled = true;
            }
        }
    }
}
