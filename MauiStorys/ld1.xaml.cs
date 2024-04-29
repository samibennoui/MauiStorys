namespace MauiStorys;

public partial class ld1 : ContentPage
{
	public ld1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new l2());
    }

    private void btnMnu_Clicked(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}