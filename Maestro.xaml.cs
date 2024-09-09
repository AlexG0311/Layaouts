using ReplicaWhatsApp.Model;
using System.Collections.ObjectModel;

namespace ReplicaWhatsApp;

public partial class Maestro : ContentPage
{
	
    public ObservableCollection<MenuModel> MenuModels { get; set; }

    public Maestro()
	{
		InitializeComponent();

		MenuModels = new ObservableCollection<MenuModel>();

        MenuModels.Add(new MenuModel
		{

			
			Name = "Pagina_",
            Imagen = "manwhite.png",
            Descripcion = StaticMessage.DESCRIPCION,
            Page = new Page1()
		});


        MenuModels.Add(new MenuModel
        {

            Name = "Pagina_2",
            Imagen = "manwhite.png",
            Descripcion = StaticMessage.DESCRIPCION,
            Page = new Page2()

        });


        MenuModels.Add(new MenuModel
        {

            Name = "Pagina_3",
            Imagen = "manwhite.png",
            Descripcion = StaticMessage.DESCRIPCION,
            Page = new Page3()
        });

        collection.ItemsSource = MenuModels;
        

    }

    private void NavigationToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = false;
    }
        
    private void collection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        MenuModel? itemSelected = (MenuModel)e.CurrentSelection.FirstOrDefault()!;
        NavigationToPage(new General(itemSelected));

    }
}