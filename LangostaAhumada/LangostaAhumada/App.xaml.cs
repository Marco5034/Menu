namespace LangostaAhumada
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Presupuesto_LangostaAhumada());
        }
    }
}
