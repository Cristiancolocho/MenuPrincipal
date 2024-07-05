namespace MenuPrincipal;

public partial class SurveysView : ContentPage
{
	public SurveysView()
	{
		InitializeComponent();
        MessagingCenter.Subscribe<ContentPage, Surveys>(this, Messages.NewSurveyComplete, (sender, args) => {
            SurveysPanel.Children.Add(new Label() { Text = args.ToString() });

        });
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new SurveyDetailsView());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Menu());
    }
}