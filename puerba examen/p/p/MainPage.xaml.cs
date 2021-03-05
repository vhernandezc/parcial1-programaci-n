using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace p
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             label.Text = "piensa en un numero";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label.Text = "multiplica el numero que pensaste por 2";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            label.Text = "ahora sumale 8";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            label.Text = "el resultado multiplicalo por 5";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            resultado.IsEnabled = true;
            label.Text = "ingrese el resultado";

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            string num = (resultado.Text);
            num = num.Remove(num.Length - 1);
            int a, b;
            b = int.Parse(num);
            a = b - 4;
            calcular.Text = a.ToString();

        }
        
        
    }
}
