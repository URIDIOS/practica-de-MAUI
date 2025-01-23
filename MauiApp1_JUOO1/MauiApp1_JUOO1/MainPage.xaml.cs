namespace MauiApp1_JUOO1
{
    public partial class MainPage : ContentPage
    {
        const double UnderweightThreshold = 18.5;
        const double NormalWeightThreshold = 24.9;
        const double OverweightThreshold = 29.9;

        public MainPage()
        {
            InitializeComponent();
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            var weight = double.Parse(Kilos.Text);
            var height = double.Parse(Altura.Text) / 100;

            var imc = weight / (height * height);

            IMC.Text = imc.ToString("F2");

            string result = GetImc(imc);
            DisplayAlert("Resultado",result,"OK");

		}
        private string GetImc(double imc)
        {
            if(imc < UnderweightThreshold)
            {
                return "Bajo peso";
            }
            else if (imc <= NormalWeightThreshold)
            {
                return "Peso normal";
            }
            else if (imc <= OverweightThreshold)
            {
                return "Sobre peso";
            }
            else
            {
                return "Demaciado peso";
            }
        }
	}

}
