namespace MauiStorys;

public partial class l4 : ContentPage
{
	public l4()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Navigation.PushAsync(new l5());
    }

    private void btnMnu_Clicked(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}