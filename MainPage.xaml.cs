using System;
using Microsoft.Maui.Controls;

namespace ReplicaWhatsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnChatsButtonClicked(object sender, EventArgs e)
        {
            carouselView.Position = 0; // Cambia a la página Chats
        }

        private void OnNovedadesButtonClicked(object sender, EventArgs e)
        {
            carouselView.Position = 1; // Cambia a la página Novedades
        }

        private void OnComunidadesButtonClicked(object sender, EventArgs e)
        {
            carouselView.Position = 2; // Cambia a la página Comunidades
        }

        private void OnLlamadasButtonClicked(object sender, EventArgs e)
        {
            carouselView.Position = 3; // Cambia a la página Llamadas
        }
    }
}
