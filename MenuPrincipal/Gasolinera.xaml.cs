namespace MenuPrincipal;

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(gal.Text))
        {
            double ga, resultado;

            ga = Convert.ToDouble(gal.Text);
            resultado = ga * 3.78;
            ResultLabel.Text = " Los litros de gasolina son :  " + resultado.ToString();

        }
        else
        {
            DisplayAlert("ERROR", "La regaste chelito, volvelo a hacer", "Okis");
        }
    }
}