namespace MauiStorys;

public partial class story1 : ContentPage
{
	public story1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Navigation.PushAsync(new as2());
    }

    private void btnMnu_Clicked(object sender, EventArgs e)
    {
       //var navigationPage = App.Current.MainPage as NavigationPage;
       // await navigationPage.Navigation.PopToRootAsync();
       Menu menu = new Menu();
        this.Navigation.PushAsync(menu);
    }
}