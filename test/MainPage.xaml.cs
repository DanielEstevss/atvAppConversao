namespace test;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void btnConverterP_Clicked(object sender, EventArgs e)
    {
        string? de = pesoDe.SelectedItem as string;
        string? para = pesoPara.SelectedItem as string;

        double resultadoConversao = 0;

        string peso = valorPeso.Text;

        int valor = Convert.ToInt32(peso);

        if (de == "Kg")
        {
            if (para == "g")
            {
                resultadoConversao = valor * 1000;
            }

            else if (para == "lb")
            {
                resultadoConversao = valor * 2.20462;
            }
        }

        else if (de == "g")
        {
            if (para == "Kg")
            {
                resultadoConversao = valor / 1000;
            }

            else if (para == "lb")
            {
                resultadoConversao = valor / 453.592; 
            }
        }

        else if (de == "lb")
        {
            if (para == "Kg")
            {
                resultadoConversao = valor / 2.20462;
            }

            else if (para == "g")
            {
                resultadoConversao = valor * 453.592;
            }
        }
        else
        {
            ResultadoPeso.Text = "As unidades são iguais. Selecione unidades diferentes.";
        }

        ResultadoPeso.Text = $"{resultadoConversao:F2} {para}";
    }

    private void btnConverterD_Clicked(object sender, EventArgs e)
    {
        string? de = distanciaDe.SelectedItem as string;
        string? para = distanciaPara.SelectedItem as string;

        double resultadoConversao = 0;

        string distancia = valorDistancia.Text;

        int valor = Convert.ToInt32(distancia);

        if (de == "Km")
        {
            if (para == "m")
            {
                resultadoConversao = valor * 1000;
            }

            else if (para == "mi")
            {
                resultadoConversao = valor * 0.621371;
            }
        }

        else if (de == "m")
        {
            if (para == "Km")
            {
                resultadoConversao = valor / 1000;
            }

            else if (para == "mi")
            {
                resultadoConversao = valor / 1609.34;
            }
        }

        else if (de == "mi")
        {
            if (para == "Km")
            {
                resultadoConversao = valor / 0.621371;
            }

            else if (para == "m")
            {
                resultadoConversao = valor * 1609.34;
            }
        }
        else
        {
            ResultadoDistancia.Text = "As unidades são iguais. Selecione unidades diferentes.";
        }

        ResultadoDistancia.Text = $"{resultadoConversao:F2} {para}";
    }

    private void btnConverterT_Clicked(object sender, EventArgs e)
    {
        string? de = temperaturaDe.SelectedItem as string;
        string? para = temperaturaPara.SelectedItem as string;

        double resultadoConversao = 0;

        string temperatura = valorTemperatura.Text;

        int valor = Convert.ToInt32(temperatura);

        if (de == "ºC")
        {
            if (para == "ºF")
            {
                resultadoConversao = (valor * 9 / 5) + 32;
            }

            else if (para == "ºK")
            {
                resultadoConversao = valor + 273.15;
            }
        }

        else if (de == "ºF")
        {
            if (para == "ºC")
            {
                resultadoConversao = (valor - 32) * 5 / 9;
            }

            else if (para == "ºK")
            {
                resultadoConversao = (valor - 32) * 5 / 9 + 273.15;
            }
        }

        else if (de == "ºK")
        {
            if (para == "ºC")
            {
                resultadoConversao = valor - 273.15;
            }

            else if (para == "ºF")
            {
                resultadoConversao = (valor - 273.15) * 9 / 5 + 32;
            }
        }
        else
        {
            ResultadoTemperatura.Text = "As unidades são iguais. Selecione unidades diferentes.";
        }

        ResultadoTemperatura.Text = $"{resultadoConversao:F2} {para}";
    }
}
