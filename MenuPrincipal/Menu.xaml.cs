namespace MenuPrincipal;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Cambio());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Triangulo());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Dinosaurio());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Gasolinera());

    }

    
    private void Button_Clicked_5(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new SurveysView());
    }
}