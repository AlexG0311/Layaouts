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

			
			Name = "Grid",
            Imagen = "manwhite.png",
        
            Page = new Grid()
		});


        MenuModels.Add(new MenuModel
        {

            Name = "StackLayout",
            Imagen = "manwhite.png",
            
            Page = new StackLayout()

        });


        MenuModels.Add(new MenuModel
        {

            Name = "VerticalStackLayout",
            Imagen = "manwhite.png",
        
            Page = new VerticalStackLayout()
        });

        MenuModels.Add(new MenuModel
        {

            Name = "HorizontalStackLayout",
            Imagen = "manwhite.png",
           
            Page = new HorizontalStackLayout()
        });


        MenuModels.Add(new MenuModel
        {

            Name = "FlexLayout",
            Imagen = "manwhite.png",
           
            Page = new FlexLayout()
        });
        MenuModels.Add(new MenuModel
        {

            Name = "Absolute",
            Imagen = "manwhite.png",

            Page = new Absolute()
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
        NavigationToPage(itemSelected.Page);

    }
}