namespace MenuPrincipal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Menu();
        }
    }
}
