using ReplicaWhatsApp.ModelCanales;
using ReplicaWhatsApp.Models;
using ReplicaWhatsApp.Model;
using System.Collections.ObjectModel;

namespace ReplicaWhatsApp;

public partial class Detalle : ContentPage
{
 
    public Detalle()
    {
        InitializeComponent();

    }

    private void NavigationToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = false;
    }

    private void canales1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {


        MenuModel? itemSelected = (MenuModel)e.CurrentSelection.FirstOrDefault()!;
        NavigationToPage(new General(itemSelected));

    }
}