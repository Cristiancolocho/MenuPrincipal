namespace MenuPrincipal;

public partial class Triangulo : ContentPage
{
	public Triangulo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ase.Text) && !string.IsNullOrEmpty(ltura.Text))
        {
            double altura,Base, superficie;

            Base = Convert.ToDouble(ase.Text);
            altura = Convert.ToDouble(ltura.Text);
            superficie = (Base * altura)/2;
            ResultLabel.Text = " La superficie del triangulo es:  " + superficie.ToString();

        }
        else
        {
            DisplayAlert("ERROR", "La regaste chelito, volvelo a hacer", "Okis");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Menu());
    }
}