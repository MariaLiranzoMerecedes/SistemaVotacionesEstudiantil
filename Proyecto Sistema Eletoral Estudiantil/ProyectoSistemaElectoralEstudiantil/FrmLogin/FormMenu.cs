using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaElectoralEstudiantil.FrmLogin
{
    public partial class FormMenu : Form
    {
        
        public FormMenu()
        {
            InitializeComponent();
        }

        
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPlanchas frm = new FrmPlanchas();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmVotacion frm = new FrmVotacion(1, 1);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPanelVotaciones frm = new FrmPanelVotaciones();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDatosGenerales frm = new FrmDatosGenerales();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
               "¿Desea cerrar la aplicación?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
    
