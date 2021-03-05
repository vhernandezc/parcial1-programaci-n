using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace p2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text = "anota el día en que naciste";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label.Text = "multiplicalo por 20";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            label.Text = "ahora sumale 73";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            label.Text = "ahora multiplicalo por 5";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            label.Text = "sumale el numero de mes de tu cumpleaños";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            label.Text = "ingresa el resultado";
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            string num = (resultado.Text);
            int a, b;
            b = int.Parse(num);
            a = b - 365;
            calcular.Text = a.ToString("##/##");
        }
    }
}
