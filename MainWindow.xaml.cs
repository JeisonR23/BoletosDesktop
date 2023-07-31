using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Evento
{
    public long eventoId { get; set; }
    public string nombreEvento { get; set; }
    public string descripcion { get; set; }
    public DateTime fecha { get; set; }
    public string ubicacion { get; set; }
}

namespace BoletosDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient httpClient;
        private string apiUrl = "http://localhost:8081/evento/list/evento";

        public MainWindow()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async Task ObtenerEventos()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<Evento> eventos = JsonConvert.DeserializeObject<List<Evento>>(jsonResponse);
                    eventosListBox.ItemsSource = eventos; // Asignar la lista de eventos al ListBox
                }
                else
                {
                    MessageBox.Show("Error al obtener los eventos de la API");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la comunicación con la API: " + ex.Message);
            }
        }

        // Método para crear un nuevo evento en la API
      

        // Evento Click de un botón para obtener los eventos desde la API
        private void ObtenerEventosButton_Click(object sender, RoutedEventArgs e)
        {
            ObtenerEventos();
        }


        // Evento Click de un botón para abrir la ventana CrearEventosW
        private void CrearEventoButton_Click(object sender, RoutedEventArgs e)
        {
            CrearEventos crearEventos = new CrearEventos();
            crearEventos.ShowDialog();
        }

        private void IrABoletosButton_Click(object sender, RoutedEventArgs e)
        {
            Boletos boletosWindow = new Boletos();
            boletosWindow.ShowDialog();
        }



        private void eventosListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
