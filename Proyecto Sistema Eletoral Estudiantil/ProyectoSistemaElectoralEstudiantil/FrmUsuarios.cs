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
using LogicaNegocio;

namespace ProyectoSistemaElectoralEstudiantil
{
    public partial class FrmUsuarios : Form
    {

        UsuarioRepository repo =
         new UsuarioRepository();


        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cbRol.Items.Add("Votante");
            cbRol.Items.Add("Admin");
            cbRol.Items.Add("RepPartido");

            cbRol.SelectedIndex = 0;

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = repo.ObtenerTodos();

            // Ocultar columnas internas que no debe ver el admin
            dgvUsuarios.Columns["PasswordHash"].Visible = false;
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["PadronId"].Visible = false;
            dgvUsuarios.Columns["Activo"].Visible = false;
            dgvUsuarios.Columns["FechaRegistro"].Visible = false;

            // Mostrar CantidadVotos como columna "YaVoto" (solo lectura)
            if (dgvUsuarios.Columns.Contains("CantidadVotos"))
            {
                dgvUsuarios.Columns["CantidadVotos"].HeaderText = "YaVoto";
                dgvUsuarios.Columns["CantidadVotos"].ReadOnly = true;
            }

            // Ocultar la columna automática YaVoto (la propiedad calculada)
            if (dgvUsuarios.Columns.Contains("YaVoto"))
                dgvUsuarios.Columns["YaVoto"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // ===== VALIDACIÓN 1: nombre vacío =====
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre");
                    txtNombre.Focus();
                    return;
                }

                // ===== VALIDACIÓN 2: matrícula vacía =====
                if (string.IsNullOrWhiteSpace(txtMatricula.Text))
                {
                    MessageBox.Show("Ingrese la matrícula");
                    txtMatricula.Focus();
                    return;
                }

                // ===== VALIDACIÓN 3: curso vacío =====
                if (string.IsNullOrWhiteSpace(txtCurso.Text))
                {
                    MessageBox.Show("Ingrese el curso");
                    txtCurso.Focus();
                    return;
                }

                // ===== VALIDACIÓN 4: sección vacía =====
                if (string.IsNullOrWhiteSpace(txtSeccion.Text))
                {
                    MessageBox.Show("Ingrese la sección");
                    txtSeccion.Focus();
                    return;
                }

                // ===== VALIDACIÓN 5: contraseña vacía =====
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Ingrese la contraseña");
                    txtPassword.Focus();
                    return;
                }

                // ===== VALIDACIÓN 6: longitud mínima de contraseña =====
                if (txtPassword.Text.Length < 4)
                {
                    MessageBox.Show("La contraseña debe tener al menos 4 caracteres");
                    txtPassword.Focus();
                    return;
                }

                // ===== CREAR USUARIO =====
                Usuario u = new Usuario();
                u.Nombre = txtNombre.Text.Trim();        // ← .Trim()
                u.Matricula = txtMatricula.Text.Trim();  // ← .Trim()
                u.Curso = txtCurso.Text.Trim();          // ← .Trim()
                u.Seccion = txtSeccion.Text.Trim();      // ← .Trim()
                u.Rol = cbRol.Text;
                u.PadronId = 1;

                AuthService auth = new AuthService();
                u.PasswordHash = auth.HashPassword(txtPassword.Text);

                repo.Guardar(u);

                MessageBox.Show("Usuario guardado correctamente");
                CargarUsuarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                // ===== MENSAJE AMIGABLE PARA MATRÍCULA DUPLICADA =====
                if (ex.Message.Contains("UNIQUE") || ex.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Ya existe un usuario con esa matrícula");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtMatricula.Clear();
            txtCurso.Clear();
            txtSeccion.Clear();
            txtPassword.Clear();
            cbRol.SelectedIndex = 0;
            txtNombre.Focus();  // ← detalle de UX
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
