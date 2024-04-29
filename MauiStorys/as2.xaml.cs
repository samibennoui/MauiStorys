namespace MauiStorys;

public partial class as2 : ContentPage
{
	public as2()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new as3());
    }
    

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {

    }

    private  void btnMnu_Clicked(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}