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
    public partial class FormPrincipal : Form
    {
        //string frecuenciaFilePath = System.AppContext.BaseDirectory + "../../Frecuencias.xml";
        //string configuracionesFilePath = System.AppContext.BaseDirectory + "../../Config.xml";
        //string servidoresFilePath = System.AppContext.BaseDirectory + "../../Servidores.xml";
        string frecuenciaFilePath = System.AppContext.BaseDirectory + "Frecuencias.xml";
        string configuracionesFilePath = System.AppContext.BaseDirectory + "Config.xml";
        string servidoresFilePath = System.AppContext.BaseDirectory + "Servidores.xml";

        private int estadoSimulacion = 0; // 0 sin empezar; 1 simulando; 2 pausa; 3 terminado

        Simulacion sim;

        List<Control> controlesCarga = new List<Control>();
        List<Control> controlesSimulacion = new List<Control>();
        List<Control> controlesResultados = new List<Control>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarFrecuencias();
                dataViewFrecuencias.DataSource = LlegadasDataSet;
                dataViewFrecuencias.DataMember = "frecuencia";
                CargarConfiguracion();
                CargarServidores();
                bsServidores.DataSource = ServidoresDataSet;
                bsServidores.DataMember = "servidor";
                bindingNavigatorServidores.BindingSource = bsServidores;
                data_servidor_id.DataBindings.Add(nameof(data_servidor_id.Text), bsServidores, "id", false, DataSourceUpdateMode.OnPropertyChanged);
                //data_servidor_tasa.DataBindings.Add(nameof(data_servidor_tasa.Value), bsServidores, "tasa_servicio", false, DataSourceUpdateMode.OnPropertyChanged);
                data_servidor_tasa2.DataBindings.Add(nameof(data_servidor_tasa2.Text), bsServidores, "tasa_servicio", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                ComportamientoExcepcionalPorDefecto(ex);
            }
            AgruparControladores();
            CambiarEstadoSimulacion(0);

            Test();
        }

        private void AgruparControladores()
        {
            this.controlesCarga.Add(this.panel1);
            this.controlesCarga.Add(this.BotonGuardarServidores);
            this.controlesCarga.Add(this.splitContainer1.Panel2);
            this.controlesCarga.Add(this.data_tiempo_desde);
            this.controlesCarga.Add(this.data_tiempo_hasta);
            this.controlesCarga.Add(this.data_step);

            this.controlesSimulacion.Add(this.data_velocidad_simulacion);

            this.controlesResultados.Add(this.BotonResultados);
        }

        private void CargarServidores()
        {
            ServidoresDataSet.Clear();
            ServidoresDataSet.ReadXml(servidoresFilePath);
        }

        private void CargarFrecuencias()
        {
            LlegadasDataSet.Clear();
            LlegadasDataSet.ReadXml(frecuenciaFilePath);
        }

        private bool GuardarServidores()
        {
            if (CheckIntegridadServidores())
            {
                ServidoresDataSet.AcceptChanges();
                ServidoresDataSet.WriteXml(servidoresFilePath);
            }
            else
            {
                MessageBox.Show("Error guardando los servidores. Verifique que los mismos cumplan los requisitos.", "Informacion");
                return false;
            }
            return true;
        }

        private bool CheckIntegridadServidores()
        {
            return true;
        }

        private bool GuardarFrecuencias()
        {
            if (SumaFrecuenciasIgualUno())
            {
                LlegadasDataSet.WriteXml(frecuenciaFilePath);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la nueva informacion de frecuencias porque la suma no da 1", "Informacion");
                return false;
            }
            return true;
            
        }

        private bool SumaFrecuenciasIgualUno()
        {
            float sum = 0;
            foreach (DataGridViewRow row in dataViewFrecuencias.Rows) {
                try
                {
                    float a;
                    if (float.TryParse(row.Cells[1].Value.ToString(), out a))
                    {
                        sum += a;
                    }
                }
                catch
                {
                    break;
                }
            }
            return sum == 1;
        }

        private void CargarConfiguracion()
        {
            ConfiguracionesDataSet.ReadXml(configuracionesFilePath);
            // Carga de configuraciones desde XML
            bsConfig.DataSource = ConfiguracionesDataSet;
            bsConfig.DataMember = "Configuraciones";
            data_unidad_tiempo.DataBindings.Add(nameof(data_unidad_tiempo.Text), bsConfig, "unidad_tiempo");
            data_tipo_servicio.DataBindings.Add(nameof(data_tipo_servicio.Text), bsConfig, "tipo_servicio");
            data_tipo_cliente.DataBindings.Add(nameof(data_tipo_cliente.Text), bsConfig, "unidad_cliente");
            data_tasa_servicio.Text = data_unidad_tiempo.Text + " por " + data_tipo_cliente.Text;

            data_velocidad_simulacion.DataBindings.Add(nameof(data_velocidad_simulacion.Text), bsConfig, "velocidad");
            data_tiempo_desde.DataBindings.Add(nameof(data_tiempo_desde.Text), bsConfig, "tiempo_inicial");
            data_tiempo_hasta.DataBindings.Add(nameof(data_tiempo_hasta.Text), bsConfig, "tiempo_final");
            data_step.DataBindings.Add(nameof(data_step.Text), bsConfig, "step");
        }

        private void Test()
        {
            /*
            BindingSource bs = new BindingSource();

            bs.DataSource = LlegadasDataSet;
            bs.DataMember = "frecuencia";

            bindingNavigatorServidores.BindingSource = bs;
            lvl_servidor_id.DataBindings.Add(nameof(lvl_servidor_id.Text), bs, "Tiempo");*/
            data_sim_preview.Groups.Add(grupoEspera);
            data_sim_preview.Groups.Add(grupoSistema);
            data_sim_preview.Groups.Add(grupoFinalizado);
        }

        private void ComportamientoExcepcionalPorDefecto(Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Error");
            Application.Exit();
        }

        private void BotonGuardarFrecuencias_Click(object sender, EventArgs e)
        {
            try
            {
                if(GuardarFrecuencias()) CargarFrecuencias();
            }
            catch (Exception ex)
            {
                ComportamientoExcepcionalPorDefecto(ex);
            }
        }

        private void BotonRecargarFrecuencias_Click(object sender, EventArgs e)
        {
            try
            {
                CargarFrecuencias();
            }
            catch (Exception ex)
            {
                ComportamientoExcepcionalPorDefecto(ex);
            }
        }

        private void BotonCargarServidores_Click(object sender, EventArgs e)
        {
            CargarServidores();
        }

        private void BotonGuardarServidores_Click(object sender, EventArgs e)
        {
            //bindingNavigatorServidores.MoveFirstItem.PerformClick();
            DialogResult dr = MessageBox.Show("¿Desea guardar los cambios en los servidores?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (GuardarServidores()) CargarServidores();
                }
                catch (Exception ex)
                {
                    ComportamientoExcepcionalPorDefecto(ex);
                }
            }
        }

        private void CambiarEstadoSimulacion(int nuevoEstado)
        {
            switch (nuevoEstado) // 0 sin empezar; 1 simulando; 2 pausa; 3 terminado
            {
                case 0:
                    this.BotonSimular.Text = "Simular";
                    this.TimerDeSimulacion.Enabled = false;
                    this.BotonFast.Enabled = false;
                    foreach (Control c in this.controlesCarga)
                        c.Enabled = true;
                    foreach (Control c in this.controlesSimulacion)
                        c.Enabled = true;
                    foreach (Control c in this.controlesResultados)
                        c.Enabled = false;
                    break;

                case 1:
                    this.BotonSimular.Text = "Pausa";
                    this.TimerDeSimulacion.Enabled = true;
                    this.BotonFast.Enabled = true;
                    foreach (Control c in this.controlesCarga)
                        c.Enabled = false;
                    foreach (Control c in this.controlesSimulacion)
                        c.Enabled = false;
                    foreach (Control c in this.controlesResultados)
                        c.Enabled = false;
                    break;

                case 2:
                    this.BotonSimular.Text = "Reanudar";
                    this.TimerDeSimulacion.Enabled = false;
                    this.BotonFast.Enabled = true;
                    foreach (Control c in this.controlesCarga)
                        c.Enabled = false;
                    foreach (Control c in this.controlesSimulacion)
                        c.Enabled = true;
                    foreach (Control c in this.controlesResultados)
                        c.Enabled = true;
                    break;

                case 3:
                    this.BotonSimular.Text = "Simular";
                    this.TimerDeSimulacion.Enabled = false;
                    this.BotonFast.Enabled = false;
                    foreach (Control c in this.controlesCarga)
                        c.Enabled = true;
                    foreach (Control c in this.controlesSimulacion)
                        c.Enabled = true;
                    foreach (Control c in this.controlesResultados)
                        c.Enabled = true;
                    break;
            }
            estadoSimulacion = nuevoEstado;
        }

        private void BotonSimular_Click(object sender, EventArgs e)
        {
            //this.CambiarEstadoSimulacion((estadoSimulacion + 1) % 4);
            switch (this.estadoSimulacion) // 0 sin empezar; 1 simulando; 2 pausa; 3 terminado
            {
                case 0:
                case 3:
                    long desde, hasta;
                    long.TryParse(data_tiempo_desde.Text, out desde);
                    long.TryParse(data_tiempo_hasta.Text, out hasta);

                    sim = new Simulacion(hasta - desde);
                    sim.LimpiarFrecuencias();
                    sim.LimpiarServidores();

                    foreach (DataGridViewRow row in dataViewFrecuencias.Rows)
                    {
                        try
                        {
                            int a;
                            double b;
                            if ((int.TryParse(row.Cells[0].Value.ToString(), out a)) & (double.TryParse(row.Cells[1].Value.ToString(), out b)))
                            {
                                sim.CargarFrecuencia(a, b);
                            }
                        }
                        catch
                        {
                            break;
                        }
                    }
                    foreach (DataRowView rowView in bsServidores.List)
                    {
                        decimal a;
                        string s;
                        s = rowView.Row["id"].ToString();
                        if (decimal.TryParse(rowView.Row["tasa_servicio"].ToString(), out a))
                        {
                            sim.CargarServidor(a, s);
                        }
                    }

                    if (sim.PrepararSimulacion())
                    {
                        //sim.SimularTodo();
                        data_sim_preview.Items.Clear();
                        this.CambiarEstadoSimulacion(1);
                    }
                    else
                    {
                        MessageBox.Show("Error al preparar la simulacion", "Verifique que haya al menos un servidor y una frecuencia.");
                    }

                    break;
                case 1:
                    this.CambiarEstadoSimulacion(2);
                    break;
                case 2:
                    this.CambiarEstadoSimulacion(1);
                    break;

            }
        }

        private void data_velocidad_simulacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float a = 100;
                if (float.TryParse(data_velocidad_simulacion.Text.ToString(), out a))
                {
                    TimerDeSimulacion.Interval = (int)(a * 1000);
                }
            }
            catch
            {

            }
        }

        private void MostrarResultados()
        {
            FormResultado result = new FormResultado(sim, data_nombre_simulacion.Text, data_unidad_tiempo.Text);
            result.Show();
        }


        private void TimerDeSimulacion_Tick(object sender, EventArgs e)
        {
            try
            {
                if (estadoSimulacion == 1)
                {
                    data_tiempo_actual.Text = sim.getTiempoActual().ToString();
                    if (CheckPreview.Checked) ActualizarMonitor();
                    sim.SimularProximo();
                }
            }
            catch (IndexOutOfRangeException ex) 
            {
                CambiarEstadoSimulacion(3);
                MessageBox.Show(ex.Message);
                MostrarResultados();
            }

        }

        ListViewGroup grupoEspera = new ListViewGroup("Cola de espera");
        ListViewGroup grupoSistema = new ListViewGroup("Siendo atendido");
        ListViewGroup grupoFinalizado = new ListViewGroup("Finalizado");
        private void ActualizarMonitor()
        {
 
            int c_finished = sim.clientesFinalizados.Count();
            int c_finished_shown = grupoFinalizado.Items.Count;
            int c_sistem = sim.listaClientesSiendoAtendido.Count();
            int c_sistem_shown = grupoSistema.Items.Count;
            int c_cola = sim.colaDeEntrada.Count();
            int c_cola_shown = grupoEspera.Items.Count;

            while ((c_finished_shown != c_finished) ||
                (c_sistem_shown != c_sistem) ||
                (c_cola_shown != c_cola))
            {
                while (c_finished_shown < c_finished)
                {
                    // solo incrementa, no verifico que hayan bajado
                    ListViewItem item;
                    if (c_sistem_shown > 0)
                    {
                        // saco un cliente del sistema a finalizado
                        item = grupoSistema.Items[0];
                        c_sistem_shown--;
                    }
                    else if (c_cola_shown > 0)
                    {
                        // saco un cliente de la cola a finalizado
                        item = grupoEspera.Items[0];
                        c_cola_shown--;
                    }
                    else
                    {
                        item = new ListViewItem("Cliente");
                        data_sim_preview.Items.Add(item);
                        // creo un nuevo cliente a finalizado
                    }
                    item.Group = grupoFinalizado;
                    c_finished_shown++;

                }
                while (c_sistem_shown < c_sistem)
                {
                    // no deberia checkear si bajo
                    ListViewItem item;
                    if (c_cola_shown > 0)
                    {
                        // saco un cliente de la cola a finalizado
                        item = grupoEspera.Items[0];
                        c_cola_shown--;
                    }
                    else
                    {
                        item = new ListViewItem("Cliente");
                        data_sim_preview.Items.Add(item);
                        // creo un nuevo cliente a finalizado
                    }
                    item.Group = grupoSistema;
                    c_sistem_shown++;
                }
                while (c_cola_shown < c_cola)
                {
                    ListViewItem item = new ListViewItem("Cliente");
                    data_sim_preview.Items.Add(item);
                    item.Group = grupoEspera;
                    c_cola_shown++;
                }
            }
       }

        private void BotonResultados_Click(object sender, EventArgs e)
        {
            this.MostrarResultados();
        }

        private void BotonFast_Click(object sender, EventArgs e)
        {
            sim.SimularTodo();
            this.CambiarEstadoSimulacion(1);
        }

        private void data_sim_preview_SelectedIndexChanged(object sender, EventArgs e)
        {
            Simulacion.Cliente cliente = null;
            try
            {
                int selected = data_sim_preview.SelectedIndices[0];
                cliente = sim.clientes[selected];
            }
            catch
            {

            }       
            if (cliente != null)
            {
                FormCliente dialog = new FormCliente(cliente);
                dialog.ShowDialog();
            }
        }
    } 
}
