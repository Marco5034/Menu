namespace ProgramTemporizador
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Utilizamos el navigationPage para poder crear una instancia de la pagina donde vamos a mostrar el conteo de 10 a 1
            MainPage = new NavigationPage (new NewPage1());
        }
    }
}
