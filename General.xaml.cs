using ReplicaWhatsApp.Model;

namespace ReplicaWhatsApp;

public partial class General : ContentPage
{
    public MenuModel Model { get; set; } 
     public General(MenuModel model)

    {
        InitializeComponent();
        this.Model = model;
        this.BindingContext = this;

    }
}   