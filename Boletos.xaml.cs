using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;
using System.Collections.Generic;


public class Boleto
{
    public long idBoleto { get; set; }
    public int cantidadBoletos { get; set; }
    public double price { get; set; }
    public string tipoAsiento { get; set; }

    [ForeignKey("Evento")]
    public Evento evento { get; set; }
}

namespace BoletosDesktop
{
    public partial class Boletos : Window
    {
        private readonly HttpClient httpClient;
        private string apiUrl = "http://localhost:8081/evento/list/evento";
        private string api = "http://localhost:8081/boletos/boleto/save";

        public Boletos()
        {
            InitializeComponent();

            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            LoadEventos();
        }

        private async void LoadEventos()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonEventos = await response.Content.ReadAsStringAsync();
                    List<Evento> eventos = JsonConvert.DeserializeObject<List<Evento>>(jsonEventos);

                    idEventoComboBox.ItemsSource = eventos;
                }
                else
                {
                    MessageBox.Show("Error al obtener la lista de eventos de la API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la comunicación con la API: " + ex.Message);
            }
        }

        private async void GuardarBoletoButton_Click(object sender, RoutedEventArgs e)
        {
            Evento selectedEvento = idEventoComboBox.SelectedItem as Evento;
            long eventoId = selectedEvento != null ? selectedEvento.eventoId : 0;
            int cantidadBoletos = int.Parse(cantidadBoletosTextBox.Text);
            double precio = double.Parse(precioTextBox.Text);
            string tipoAsiento = tipoAsientoTextBox.Text;

            var boleto = new Boleto
            {
                evento = selectedEvento,
                cantidadBoletos = cantidadBoletos,
                price = precio,
                tipoAsiento = tipoAsiento
            };

            bool exito = await GuardarBoleto(boleto);
            if (exito)
            {
                // Realizar acciones adicionales después de guardar el boleto

                // Limpiar los valores de los inputs
                idEventoComboBox.SelectedItem = null;
                cantidadBoletosTextBox.Text = string.Empty;
                precioTextBox.Text = string.Empty;
                tipoAsientoTextBox.Text = string.Empty;
            }
        }


        private async Task<bool> GuardarBoleto(Boleto boleto)
        {
            try
            {
                string jsonBoleto = JsonConvert.SerializeObject(boleto);
                var content = new StringContent(jsonBoleto, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(api, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Evento creado exitosamente");
                    return true;
                }
                else
                {
                    Console.WriteLine("Error al guardar el boleto en la API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la comunicación con la API: " + ex.Message);
            }

            return false;
        }
    }
}