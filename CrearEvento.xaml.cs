using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace BoletosDesktop
{
    public partial class CrearEventos : Window
    {
        private HttpClient httpClient;
        private string apiUrlS = "http://localhost:8081/evento/evento/save";

        public static readonly DependencyProperty NombreEventoProperty =
            DependencyProperty.Register("NombreEvento", typeof(string), typeof(CrearEventos));

        public static readonly DependencyProperty DescripcionProperty =
            DependencyProperty.Register("Descripcion", typeof(string), typeof(CrearEventos));

        public static readonly DependencyProperty FechaProperty =
            DependencyProperty.Register("Fecha", typeof(DateTime), typeof(CrearEventos));

        public static readonly DependencyProperty UbicacionProperty =
            DependencyProperty.Register("Ubicacion", typeof(string), typeof(CrearEventos));

        public string NombreEvento
        {
            get { return (string)GetValue(NombreEventoProperty); }
            set { SetValue(NombreEventoProperty, value); }
        }

        public string Descripcion
        {
            get { return (string)GetValue(DescripcionProperty); }
            set { SetValue(DescripcionProperty, value); }
        }

        public DateTime Fecha
        {
            get { return (DateTime)GetValue(FechaProperty); }
            set { SetValue(FechaProperty, value); }
        }

        public string Ubicacion
        {
            get { return (string)GetValue(UbicacionProperty); }
            set { SetValue(UbicacionProperty, value); }
        }

        public CrearEventos()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async Task<bool> CrearEvento(Evento evento)
        {
            try
            {
                string jsonEvento = JsonConvert.SerializeObject(evento);
                var content = new StringContent(jsonEvento, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(apiUrlS, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Evento creado exitosamente");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al crear el evento en la API");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la comunicación con la API: " + ex.Message);
            }

            return false;
        }

        public async void CrearEventoButton_Click(object sender, RoutedEventArgs e)
        {
            var nuevoEvento = new Evento
            {
                nombreEvento = NombreEvento,
                descripcion = Descripcion,
                fecha = Fecha,
                ubicacion = Ubicacion
            };

            bool exito = await CrearEvento(nuevoEvento);
            if (exito)
            {
                // Realizar acciones adicionales después de crear el evento
            }
        }

    }
}
