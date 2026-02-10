using Dto;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Mapa : Form
    {

        private readonly Ruta _ruta;
        private readonly ApiReta _api;

        public Mapa(ApiReta api, Ruta ruta)
        {
            InitializeComponent();
            _api = api;
            _ruta = ruta;
        }

        private async void Mapa_Load(object sender, EventArgs e)
        {
            await wbMapa.EnsureCoreWebView2Async();

            var htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "map.html");
            wbMapa.Source = new Uri(htmlPath);

            await EsperarCargaPaginaAsync();
            await CargarYPintarRutaAsync();
        }



        private async Task CargarMapaAsync()
        {
            await wbMapa.EnsureCoreWebView2Async();

            var htmlPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "map.html"
            );

            wbMapa.Source = new Uri(htmlPath);
        }


        private async Task CargarYPintarRutaAsync()
        {

            var tps = await _api.GetAllAsync<DtoTrackPoint>($"api/reta3/rutas/{_ruta.IdRuta}/trackpoints");

            if (tps == null || tps.Count == 0) return;

            var points = tps.Select(tp => new { lat = tp.Latitud, lon = tp.Longitud }).ToList();
            var json = JsonSerializer.Serialize(points);
            await wbMapa.ExecuteScriptAsync($"window.renderTrackpoints({json});");

        }


        private Task EsperarCargaPaginaAsync()
        {
            var tcs = new TaskCompletionSource<bool>();

            void Handler(object? s, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
            {
                wbMapa.NavigationCompleted -= Handler;
                tcs.TrySetResult(true);
            }

            wbMapa.NavigationCompleted += Handler;
            return tcs.Task;
        }


    }
}
