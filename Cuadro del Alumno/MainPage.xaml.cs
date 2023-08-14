namespace Cuadro_del_Alumno;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(NumeroEntry.Text, out int numero) && numero >= 0)
        {
            int cuadrado = numero * numero;
            int cubo = numero * numero * numero;

            ResultadoLabel.Text = $"El cuadrado de {numero} es: {cuadrado}\nEl cubo de {numero} es: {cubo}";
        }
        else
        {
            ResultadoLabel.Text = "Por favor, ingrese un número entero positivo válido.";
        }
    }

}

