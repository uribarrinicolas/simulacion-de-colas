using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionesDeCola
{
    public partial class FormResultado : Form
    {
        Simulacion sim;
        string titulo, unidad_tiempo;

        public FormResultado(Simulacion sim, string titulo, string unidad_tiempo)
        {
            this.sim = sim;
            this.titulo = titulo;
            this.unidad_tiempo = unidad_tiempo;
            InitializeComponent();
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            List<Control> controles = AgruparControlesTemporales();
            this.Text += this.titulo;
            foreach (Control control in controles)
            {
                control.Text += this.unidad_tiempo;
            }
            CargarDatos();
        }

        private List<Control> AgruparControlesTemporales()
        {
            List<Control> result = new List<Control>();
            result.Add(this.lvl_lambda);
            result.Add(this.lvl_lambda_efectiva);
            result.Add(this.lvl_mu);
            result.Add(this.lvl_mu_efectiva);
            result.Add(this.lvl_w);
            result.Add(this.lvl_wq);
            result.Add(this.lvl_t);

            return result;
        }

        private void CargarDatos()
        {
            this.data_lambda.Text = "";
            this.data_lambda_efectiva.Text = sim.Contable_getLambdaEfectiva().ToString();
            this.data_mu.Text = "";
            this.data_mu_efectiva.Text = sim.Contable_getMuEfectiva().ToString();
            this.data_utilizacion.Text = sim.Contable_getUtilizacion().ToString();
            this.data_lq.Text = sim.Contable_getLq().ToString();
            this.data_l.Text = sim.Contable_getL().ToString();
            this.data_w.Text = sim.Contable_getW().ToString();
            this.data_wq.Text = sim.Contable_getWq().ToString();
            this.data_po.Text = sim.Contable_getPo().ToString();
            this.data_pw.Text = sim.Contable_getPw().ToString();
            this.data_t.Text = sim.getTiempoActual().ToString();
            this.data_maxq.Text = sim.Contable_getMaxQ().ToString();

            this.sim = null; // Dejo de apuntar a la simulacion.
        }

    }
}
