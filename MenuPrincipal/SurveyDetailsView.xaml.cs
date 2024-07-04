

namespace MenuPrincipal;

public partial class SurveyDetailsView : ContentPage
{
    private readonly string[] teams =
    {
        "Alianza Lima",
        "America",
        "Boca Juniors",
        "Caracas FC",
        "Colo-colo",
        "Peñarol",
        "FC Barcelona",
        "Saprissa",
    };
	public SurveyDetailsView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTEamTitle, null, null, teams);
        if(!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        //Evaluamos si los datos estan completos
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }
        //Creamos el nuevo objeto de tipo survey
        var newSurvey = new Surveys()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdatePicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };
        //publicamos el mensaje con el objeto de encuesta coomo argumento
        MessagingCenter.Send((ContentPage)this,
            Messages.NewSurveyComplete, newSurvey);
        //Removemos la pagina de la pila de navegacion para regresar inmediaamente
        await Navigation.PopAsync();
    }
}