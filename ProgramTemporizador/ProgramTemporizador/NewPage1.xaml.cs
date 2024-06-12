namespace ProgramTemporizador;

public partial class NewPage1 : ContentPage
{
    private int Conteo = 10;

    public NewPage1()
	{
		InitializeComponent();
	}

    private async void btnStart_Clicked(object sender, EventArgs e)
    {
        // Deshabilita el bot�n mientras se est� ejecutando la cuenta regresiva
        btnIniciar.IsEnabled = false;

        // Realiza el conteo regresivo de 10 a 1
        for (int i = Conteo; i > 0; i--)
        {
            lblCountdown.Text = i.ToString();
            await Task.Delay(1000); // Espera 1 segundo
        }

        // Restablece el valor del texto y habilita el bot�n nuevamente
        lblCountdown.Text = "�Listo!";
        btnIniciar.IsEnabled = true;
    }
}

    
