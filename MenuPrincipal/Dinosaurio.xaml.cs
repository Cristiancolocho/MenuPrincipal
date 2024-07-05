namespace MenuPrincipal;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(kg.Text) && !string.IsNullOrEmpty(tura.Text))
        {
            double peso, altura, total, igual;

            peso = Convert.ToDouble(kg.Text);
            altura = Convert.ToDouble(tura.Text);
            total = peso * 2.205  ;
            ResultLabel.Text = " El peso del dinosuario es : " + total.ToString();
            igual = altura * 100;
            ResultLabel2.Text = " El altura del dinosuario es : " + igual.ToString();
        }
        else
        {
            DisplayAlert("ERROR", "La regaste chelito, volvelo a hacer", "Okis");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Menu());
    }
}