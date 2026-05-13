using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace ProyectoSistemaElectoralEstudiantil
{
    public partial class FrmPlanchas : Form
    {

        PartidoRepository repo =
          new PartidoRepository();

        List<Candidato> candidatos =
            new List<Candidato>();
        public FrmPlanchas()
        {
            InitializeComponent();

            cbPuesto.Items.Add("Presidente");
            cbPuesto.Items.Add("Vicepresidente");
            cbPuesto.Items.Add("Secretario");
            cbPuesto.Items.Add("Tesorero");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlanchas_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = openFileDialog1.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCandidato.Text))
            {
                MessageBox.Show("Ingrese el nombre del candidato");
                return;
            }

            // ===== VALIDACIÓN 2: puesto no seleccionado =====
            if (cbPuesto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un puesto");
                return;
            }

            // ===== VALIDACIÓN 3: puesto repetido =====
            foreach (Candidato c in candidatos)
            {
                if (c.Puesto == cbPuesto.Text)
                {
                    MessageBox.Show("Ya existe un candidato para el puesto: " + cbPuesto.Text);
                    return;
                }
            }

            // ===== AGREGAR =====
            Candidato cand = new Candidato();
            cand.Nombre = txtCandidato.Text.Trim();  // ← .Trim() quita espacios
            cand.Puesto = cbPuesto.Text;
            cand.Orden = candidatos.Count + 1;
            candidatos.Add(cand);

            dgvCandidatos.DataSource = null;
            dgvCandidatos.DataSource = candidatos;

            txtCandidato.Clear();
            cbPuesto.SelectedIndex = -1;  // ← limpia el ComboBox también

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ===== VALIDACIÓN 1: nombre vacío =====
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre de la plancha");
                    txtNombre.Focus();
                    return;
                }

                // ===== VALIDACIÓN 2: lema vacío =====
                if (string.IsNullOrWhiteSpace(txtLema.Text))
                {
                    MessageBox.Show("Ingrese el lema");
                    txtLema.Focus();
                    return;
                }

                // ===== VALIDACIÓN 3: color por defecto si vacío =====
                if (string.IsNullOrWhiteSpace(txtColor.Text))
                {
                    txtColor.Text = "#1a6fc4";
                }

                // ===== VALIDACIÓN 4: al menos un candidato =====
                if (candidatos.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un candidato");
                    return;
                }

                // ===== GUARDAR =====
                Partido p = new Partido();
                p.Nombre = txtNombre.Text.Trim();
                p.Lema = txtLema.Text.Trim();
                p.ColorHex = txtColor.Text.Trim();
                p.LogoPath = string.IsNullOrWhiteSpace(txtLogo.Text) ? "" : txtLogo.Text;
                p.Candidatos = candidatos;

                repo.Guardar(p);

                MessageBox.Show("Plancha guardada correctamente");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtLema.Clear();
            txtColor.Text = "#1a6fc4";              // ← color por defecto
            txtLogo.Clear();
            txtCandidato.Clear();
            cbPuesto.SelectedIndex = -1;            // ← limpia el ComboBox

            candidatos = new List<Candidato>();     // ← lista NUEVA (no Clear)
            dgvCandidatos.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            txtColor.Text = "#1a6fc4";
        }
    }

}
