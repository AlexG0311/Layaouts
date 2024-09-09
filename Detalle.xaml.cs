using ReplicaWhatsApp.ModelCanales;
using ReplicaWhatsApp.Models;
using ReplicaWhatsApp.Model;
using System.Collections.ObjectModel;

namespace ReplicaWhatsApp;

public partial class Detalle : ContentPage
{
    public ObservableCollection<Estado> Estadoss { get; set; }
    public ObservableCollection<Canales> Canaless { get; set; }

    public ObservableCollection<MenuModel> Canales1 { get; set; }
    public Detalle()
	{
        InitializeComponent();

        Estadoss = new ObservableCollection<Estado>();

        Canaless = new ObservableCollection<Canales>();

        Canales1 = new ObservableCollection<MenuModel>();

        Estadoss.Add(new Estado
        {
            Name = "Estad",
            Image = "manwhite.png",

           
        });
        Estadoss.Add(new Estado
        {
            Name = "Estado1",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estado
        {
            Name = "Estado2",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estado
        {
            Name = "Estado3",
            Image = "manwhite.png",


        });
        Estadoss.Add(new Estado
        {
            Name = "Estado3",
            Image = "manwhite.png",


        });

        Estadoss.Add(new Estado
        {
            Name = "Estado3",
            Image = "manwhite.png",


        });


        Collection.ItemsSource = Estadoss;
        // CANALES


        Canales1.Add(new MenuModel
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",


        });

        Canales1.Add(new MenuModel
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",


        });


        Canales1.Add(new MenuModel
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",



        });

        Canales1.Add(new MenuModel
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",



        });

        Canales1.Add(new MenuModel
        {
            Nombre = "Pepito1",
            Imagen1 = "manwhite.png",
            Actualizacion = "",
            Mensaje = "Hola",



        });

        canales1.ItemsSource = Canales1;


        // BUSCAR CANALES


        Canaless.Add(new Canales
        {
            Nombre = "Pepito1",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito2",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito3",
            Imagen = "manwhite.png",


        });

        Canaless.Add(new Canales
        {
            Nombre = "Pepito4",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito5",
            Imagen = "manwhite.png",


        });

        Canaless.Add(new Canales
        {
            Nombre = "Pepito6",
            Imagen = "manwhite.png",


        });


        Canaless.Add(new Canales
        {
            Nombre = "Pepito7",
            Imagen = "manwhite.png",


        });

        Canales.ItemsSource = Canaless;

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