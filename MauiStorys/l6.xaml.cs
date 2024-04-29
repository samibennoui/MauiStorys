namespace MauiStorys;

public partial class l6 : ContentPage
{
	public l6()
	{
		InitializeComponent();
	}

   

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}