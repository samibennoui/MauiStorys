namespace MauiStorys;

public partial class story2 : ContentPage
{
    public story2()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new ld1());
    }

    private void btnMnu_Clicked(object sender, EventArgs e)
    {
        //Menu menu = new Menu();
        //this.Navigation.PushAsync(menu);
        this.Navigation.PushAsync(new Menu());

    }
}