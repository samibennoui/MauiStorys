namespace MauiStorys;

public partial class as3 : ContentPage
{
	public as3()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new as4());
    }

    private async void btnMnu_Clicked(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}