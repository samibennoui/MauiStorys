namespace MauiStorys;

public partial class l5 : ContentPage
{
	public l5()
	{
		InitializeComponent();
	}


    private void btnsuivant_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new l6());
    }

    private void btnMenu_Clicked(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}