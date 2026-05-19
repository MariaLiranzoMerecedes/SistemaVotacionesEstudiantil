using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoSistemaElectoralEstudiantil
{
    public partial class FrmPanelVotaciones : Form
    {

        VotoService service =
          new VotoService();

        public FrmPanelVotaciones()
        {
            InitializeComponent();
        }

        private void FrmPanelVotaciones_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }


        private void CargarEstadisticas()
        {
            try
            {
                Estadisticas est = service.ObtenerEstadisticas();

                // ===== LABELS PRINCIPALES =====
                lblTotal.Text = est.TotalVotos.ToString();
                lblNulos.Text = est.VotosNulos.ToString();
                lblSinVotar.Text = est.SinVotar.ToString();

                // ===== PARTICIPACIÓN (con manejo de cero) =====
                if (est.TotalPadron > 0)
                {
                    lblParticipacion.Text = Math.Round(est.Participacion, 2) + "%";
                }
                else
                {
                    lblParticipacion.Text = "0%";
                }

                // ===== PROGRESS BAR (con límites seguros) =====
                int valorBarra = Convert.ToInt32(est.Participacion);
                if (valorBarra < 0) valorBarra = 0;
                if (valorBarra > 100) valorBarra = 100;
                progressBar1.Value = valorBarra;

                // ===== GRID DE RESULTADOS =====
                dgvResultados.DataSource = null;
                dgvResultados.DataSource = est.Resultados;

                // Formatear nombres de columnas si hay datos
                if (dgvResultados.Columns.Count > 0)
                {
                    if (dgvResultados.Columns.Contains("Nombre"))
                        dgvResultados.Columns["Nombre"].HeaderText = "Plancha";

                    if (dgvResultados.Columns.Contains("TotalVotos"))
                        dgvResultados.Columns["TotalVotos"].HeaderText = "Votos";

                    if (dgvResultados.Columns.Contains("Porcentaje"))
                        dgvResultados.Columns["Porcentaje"].HeaderText = "Porcentaje (%)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarEstadisticas();
            MessageBox.Show("Panel actualizado");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrafica(Estadisticas est)
        {
            // Limpiar gráfica anterior
            chartResultados.Series.Clear();
            chartResultados.Titles.Clear();

            // Título
            chartResultados.Titles.Add("Resultados por Plancha");
            chartResultados.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Crear la serie
            Series serie = new Series("Votos");
            serie.ChartType = SeriesChartType.Pie;  // tipo PASTEL
            serie.IsValueShownAsLabel = true;       // muestra valores en cada parte

            // Agregar cada plancha como un punto en la gráfica
            foreach (ResultadoPartido r in est.Resultados)
            {
                if (r.TotalVotos > 0)  // solo planchas con votos
                {
                    int idx = serie.Points.AddXY(r.Nombre, r.TotalVotos);
                    serie.Points[idx].Label = r.Nombre + ": " + r.TotalVotos + " ("
                                               + Math.Round(r.Porcentaje, 1) + "%)";
                    serie.Points[idx].LegendText = r.Nombre;
                }
            }

            chartResultados.Series.Add(serie);

            // Mostrar leyenda
            chartResultados.Legends.Clear();
            Legend legend = new Legend("Planchas");
            legend.Docking = Docking.Bottom;
            chartResultados.Legends.Add(legend);
        }


    }
}
