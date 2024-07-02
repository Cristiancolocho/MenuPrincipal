namespace MenuPrincipal;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(AAA1.Text) && !string.IsNullOrEmpty(AAA2.Text))
        {
            double resultado, moneya, moneyb;
            moneya = Convert.ToDouble(AAA1.Text);
            moneyb = Convert.ToDouble(AAA2.Text);
            resultado = moneya - moneyb;
            Resultado.Text = resultado.ToString();
        }
        else
        {
            DisplayAlert("Error", "Introduce todos los campos", "ok");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Menu());

    }
}