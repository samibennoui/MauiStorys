namespace MauiStorys;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new story1());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new story2());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new story3());
    }
}