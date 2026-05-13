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
    public partial class FrmDatosGenerales : Form
    {

        ConfiguracionRepository repoConfig = new ConfiguracionRepository();
        PadronRepository repoPadron = new PadronRepository();

        public FrmDatosGenerales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDatosGenerales_Load(object sender, EventArgs e)
        {
            CargarPadrones();
            CargarConfiguracionActual();

            // Fecha por defecto
            dtInicio.Value = DateTime.Now;
            dtFin.Value = DateTime.Now.AddDays(1);
        }

        private void CargarPadrones()
        {
            try
            {
                List<Padron> padrones = repoPadron.ObtenerActivos();

                cbPadron.DataSource = padrones;
                cbPadron.DisplayMember = "Nombre";  // lo que muestra
                cbPadron.ValueMember = "Id";        // el valor real

                if (padrones.Count == 0)
                {
                    MessageBox.Show(
                        "No hay padrones registrados. Cree uno primero en la BD."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar padrones: " + ex.Message);
            }
        }

    
        private void CargarConfiguracionActual()
        {
            try
            {
                Configuracion cfg = repoConfig.ObtenerActiva();

                if (cfg != null)
                {
                    txtTitulo.Text = cfg.TituloEleccion;
                    dtInicio.Value = cfg.FechaInicio;
                    dtFin.Value = cfg.FechaFin;
                    cbPadron.SelectedValue = cfg.PadronActivoId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar configuración: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // ===== VALIDACIÓN 1: título vacío =====
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("Ingrese el título de la elección");
                    txtTitulo.Focus();
                    return;
                }

                // ===== VALIDACIÓN 2: fecha fin debe ser posterior a inicio =====
                if (dtFin.Value <= dtInicio.Value)
                {
                    MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio");
                    return;
                }

                // ===== VALIDACIÓN 3: padrón seleccionado =====
                if (cbPadron.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un padrón");
                    return;
                }

                // ===== GUARDAR =====
                Configuracion cfg = new Configuracion();
                cfg.TituloEleccion = txtTitulo.Text.Trim();
                cfg.FechaInicio = dtInicio.Value;
                cfg.FechaFin = dtFin.Value;
                cfg.PadronActivoId = Convert.ToInt32(cbPadron.SelectedValue);
                cfg.Activa = true;

                repoConfig.Guardar(cfg);

                MessageBox.Show("Configuración guardada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
