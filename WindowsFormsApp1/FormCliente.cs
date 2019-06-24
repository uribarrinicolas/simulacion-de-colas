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
    public partial class FormCliente : Form
    {
        private Simulacion.Cliente cliente;

        public FormCliente(Simulacion.Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.Text += cliente.id.ToString();
            this.data_id.Text = cliente.id.ToString();

            long te = cliente.getTiempoEntrada();
            if (te != -1)
            {
                data_t_llegada.Text = te.ToString();

                decimal ta = cliente.getTiempoAtendido();
                if (ta != -1)
                {
                    data_t_atendido.Text = ta.ToString() + " (en cola: " + (ta - te).ToString() + ")";
                    data_servidor.Text = cliente.getServidor() + " (" + cliente.getServidorInversaVelocidad().ToString() + " tiempo/cliente)";

                    decimal ts = cliente.getTiempoSalida();
                    if (ts != -1)
                    {
                        data_t_salir.Text = ts.ToString() + " (total en sistema: " + (ts - te).ToString() + ")";
                    }
                }
            }
            
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
