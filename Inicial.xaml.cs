namespace ReplicaWhatsApp;

public partial class Inicial : FlyoutPage
{
	public Inicial()
	{
		InitializeComponent();

		Flyout = new Maestro();
		Detail = new NavigationPage(new Detalle());

		App.FlyoutPage = this;
	}
}