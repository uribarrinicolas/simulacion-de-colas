using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionesDeCola
{
    public class Simulacion
    {
        private List<EventInTime> eventos = new List<EventInTime>();
        private List<Server> servidores = new List<Server>();
        private List<Frecuencia> frecuencias = new List<Frecuencia>();
        private int estado = 0;
        private long TiempoActual = 0;

        private long TiempoSimulado;

        public int getEstado()
        {
            return estado;
        }
        public long getTiempoSimulado()
        {
            return TiempoSimulado;
        }
        public void setTiempoSimulado(long t)
        {
            estado = 0;
            TiempoSimulado = t;
        }
        public long getTiempoActual()
        {
            return this.TiempoActual;
        }

        public Simulacion(long tiempo = 2000)
        {
            TiempoSimulado = tiempo;
        }

        public bool PrepararSimulacion(int semilla = int.MinValue)
        {
            estado = 0;
            TiempoActual = 0;

            if (servidores.Count() == 0) {
                return false;
            }
            if (frecuencias.Count() == 0) {
                return false;
            }

            clientes.Clear();

            if (semilla == int.MinValue)
            {
                MonteCarlo.RandomSeed();
            }
            else
            {
                MonteCarlo.SetSeed(semilla);
            }

            eventos = MonteCarlo.GenerarEventos(TiempoSimulado, frecuencias);
            estado = 1;
            return true;
        }

        public void SimularProximo()
        {
            Simular(1);
        }
        public void SimularTodo()
        {
            Simular(TiempoSimulado - TiempoActual);
        }
        public void Simular(long tiempo)
        {
            for (long i = 0; i < tiempo; i++)
            {
                Step();
            }
        }

        public void LimpiarFrecuencias()
        {
            frecuencias.Clear();
            estado = 0;
        }
        public bool CargarFrecuencia(int tiempo, double probabilidad)
        {
            estado = 0;
            if (tiempo < 1)
            {
                return false;
            }
            if (probabilidad < 0)
            {
                return false;
            }
            Frecuencia frecuencia = new Frecuencia(tiempo, probabilidad);
            frecuencias.Add(frecuencia);
            return true;
        }
        public void LimpiarServidores()
        {
            servidores.Clear();
            estado = 0;
        }
        public bool CargarServidor(decimal tiempoPorCliente, string id)
        {
            estado = 0;
            if (tiempoPorCliente < 0)
            {
                return false;
            }
            Server server = new Server(tiempoPorCliente, id);

            servidores.Add(server);
            return true;
        }
        public bool CargarServidor(decimal tiempoPorCliente)
        {
            return this.CargarServidor(tiempoPorCliente, "");
        }


        // Variables de la simulacion
        public List<Cliente> clientes = new List<Cliente>(); // TODOS
        public Queue<Cliente> colaDeEntrada = new Queue<Cliente>();
        public List<Cliente> listaClientesSiendoAtendido = new List<Cliente>();
        public Queue<Cliente> clientesFinalizados = new Queue<Cliente>();
        // Avanza 1 tiempo la simulacion
        private void Step()
        {
            if (estado == 1)
            {
                foreach (EventInTime evento in eventos)
                {
                    if (evento.time == TiempoActual)
                    {
                        // Entra un cliente
                        Cliente cliente = new Cliente(TiempoActual);
                        // Lo agrego a la lista de clientes total
                        clientes.Add(cliente);
                        // Lo agrego a la cola de espera
                        colaDeEntrada.Enqueue(cliente);
                    }
                }
                foreach (Server server in servidores)
                {
                    if (server.Disponible())
                    {
                        if (colaDeEntrada.Count() > 0)
                        {
                            Cliente cliente = colaDeEntrada.Dequeue();
                            cliente.Atendido(server, TiempoActual);
                            server.EmpezarTrabajo();
                            listaClientesSiendoAtendido.Add(cliente);
                        }
                        else
                        {
                            server.tiempoIdle();
                        }
                    }
                    else
                    {
                        server.Trabajar();
                    }
                }

                List<Cliente> aux = new List<Cliente>();
                foreach (Cliente cliente in listaClientesSiendoAtendido)
                {
                    if (cliente.getTiempoSalida() <= TiempoActual)
                    {
                        //listaClientesSiendoAtendido.Remove(cliente);
                        aux.Add(cliente);
                        clientesFinalizados.Enqueue(cliente);
                    }
                }
                foreach (Cliente cliente in aux)
                {
                    listaClientesSiendoAtendido.Remove(cliente);
                }

                if (TiempoActual >= TiempoSimulado)
                {
                    estado = 2;
                }
            }
            else if (estado == 2)
            {
                throw new IndexOutOfRangeException("Fin de la simulacion.");
            }
            else
            {
                throw new InvalidOperationException("El estado de la simulacion no lo permite. Intente PrepararSimulacion().");
            }
            TiempoActual++;

            //modifico variables contables
            this._contable_acum_clientesEnCola += colaDeEntrada.Count();
            this._contable_acum_clientesEnSistema += colaDeEntrada.Count() + listaClientesSiendoAtendido.Count();
            int i = 0;
            foreach (Server server in servidores)
            {
                if (server.Disponible()) {
                    i++;
                }
                else
                {
                    i--;
                }
            }
            if (i == servidores.Count())
            {
                this._contable_acum_todosServidoresIdle++;
            }
            if (-i == servidores.Count())
            {
                this._contable_acum_todosServidoresOcup++;
            }
            if (colaDeEntrada.Count() > _contable_maxQ) _contable_maxQ = colaDeEntrada.Count();
        }

        public class EventInTime
        {
            public int time = 0;
            public string id;
            public EventInTime(int time, string id = "")
            {
                this.time = time;
                this.id = id;
            }
        }
        public class Server
        {
            public decimal timePerClient = 0;
            public string id;
            public decimal semaforo = 0;
            public long tiempo_desocupado = 0;
            public Server(decimal rate, string id = "")
            {
                this.timePerClient = rate;
                this.id = id;
            }
            public bool Disponible()
            {
                return (semaforo <= 0);
            }
            public void EmpezarTrabajo()
            {
                semaforo = timePerClient;
            }
            public void Trabajar()
            {
                semaforo--;
            }
            public void tiempoIdle()
            {
                tiempo_desocupado++;
            }

        }
        public class Frecuencia
        {
            public int Tiempo = 1;
            public double Probabilidad, FrecuenciaAcumulada;
            public Frecuencia(int T, double P)
            {
                this.Probabilidad = P;
                this.Tiempo = T;
                this.FrecuenciaAcumulada = 0;
            }
        }

        public static class MonteCarlo
        {
            private static Random rnd = new Random();
            public static void SetSeed(int seed) { rnd = new Random(seed); }
            public static void RandomSeed() { rnd = new Random(); }
            public static List<EventInTime> GenerarEventos(long tiempoLimite, List<Frecuencia> frec)
            {
                // Creo la lista de eventos sobre la cual se simularan las llegadas.
                List<EventInTime> li = new List<EventInTime>();

                // Completo las probabilidades acumuladas para poder comparar el numero
                //   aleatorio con cada posible entrada.
                CompletarProbabilidadesAcumuladas(frec);

                // Creo una variable para seguir el tiempo en que cada cliente llega.
                int tiempoActual = 0;

                // Armo un bucle que llena la lista de eventos en funcion a los valores
                //   aleatorios.
                do
                {
                    // Genero el numero aleatorio.
                    double random = rnd.NextDouble();

                    // Sigo la lista de probabilidades hasta llegar al rango que conincida
                    //   con el numero aleatorio.
                    int diferencialTiempo = 1;
                    foreach (Frecuencia f in frec)
                    {
                        if (f.FrecuenciaAcumulada > random) { break; }
                        diferencialTiempo = f.Tiempo;
                    }

                    // Creo el evento, aumento el tiempo en tantas unidades como tiempo
                    //   haya pasado entre clientes.
                    EventInTime evento = new EventInTime(tiempoActual);
                    tiempoActual += diferencialTiempo;

                    // Agrego el evento a la lista resultante.
                    li.Add(evento);

                    // Corto el bucle al llegar el tiempo limite.
                } while (tiempoActual < tiempoLimite);

                return li;
            }

            private static void CompletarProbabilidadesAcumuladas(List<Frecuencia> frec)
            {
                double aux = 0;
                foreach (Frecuencia f in frec)
                {
                    f.FrecuenciaAcumulada = aux;
                    aux += f.Probabilidad;
                }
            }
        }

        public class Cliente
        {
            private static long count = 0;
            public static void resetCount() { Cliente.count = 0; }
            public long id;
            private long tiempo_entrada = -1;
            private decimal tiempo_atendido = -1;

            private Server servidor;

            public Cliente(long tiempo_entrada)
            {
                this.tiempo_entrada = tiempo_entrada;
                this.id = Cliente.count;
                Cliente.count++;
            }

            public void Atendido(Server server, long tiempoActual)
            {
                servidor = server;
                //tiempo_atendido = server.timePerClient;
                tiempo_atendido = tiempoActual;
            }

            public long getTiempoEntrada()
            {
                return tiempo_entrada;
            }

            public decimal getTiempoSalida()
            {
                if ((tiempo_atendido == -1) || (tiempo_entrada == -1)) return -1;
                //return tiempo_entrada + tiempo_atendido;
                return tiempo_atendido + this.getServidorInversaVelocidad();
            }

            public decimal getTiempoAtendido()
            {
                return tiempo_atendido;
            }

            public string getServidor()
            {
                return this.servidor.id;
            }

            public decimal getServidorInversaVelocidad()
            {
                return this.servidor.timePerClient;
            }
        }

        // Funciones contables
        private long _contable_acum_clientesEnCola = 0;
        private long _contable_acum_clientesEnSistema = 0;
        private long _contable_acum_todosServidoresIdle = 0;
        private long _contable_acum_todosServidoresOcup = 0;
        private long _contable_maxQ = 0;
        public float Contable_getLambdaEfectiva()
        {
            return (float)this.clientes.Count() / this.getTiempoActual();
        }
        public float Contable_getMuEfectiva()
        {
            return (float)this.clientesFinalizados.Count() / this.getTiempoActual();
        }
        public float Contable_getUtilizacion()
        {
            long idle = 0;
            foreach (Server server in servidores)
            {
                idle += server.tiempo_desocupado;
            }

            return 1.0f - (float)idle / this.getTiempoActual();
        }
        public float Contable_getLq()
        {
            return (float)_contable_acum_clientesEnCola / this.getTiempoActual();
        }
        public float Contable_getL()
        {
            return (float)_contable_acum_clientesEnSistema / this.getTiempoActual();
        }
        public decimal Contable_getW()
        {
            decimal sum = 0;
            foreach (Cliente c in clientesFinalizados)
            {
                sum += c.getTiempoSalida() - c.getTiempoEntrada();
            }
            return sum / clientesFinalizados.Count();
        }
        public decimal Contable_getWq()
        {
            decimal sum = 0;
            foreach (Cliente c in clientesFinalizados)
            {
                sum += c.getTiempoAtendido() - c.getTiempoEntrada();
            }
            return sum / clientesFinalizados.Count();
        }
        public float Contable_getPo()
        {
            return (float)_contable_acum_todosServidoresIdle / this.getTiempoActual();
        }
        public float Contable_getPw()
        {
            return (float)_contable_acum_todosServidoresOcup / this.getTiempoActual();
        }
        public long Contable_getMaxQ()
        {
            return this._contable_maxQ;
        }
    }
}
