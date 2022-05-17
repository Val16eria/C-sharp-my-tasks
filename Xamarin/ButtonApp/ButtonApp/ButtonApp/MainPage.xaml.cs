using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Button btn = null;

            for (int i = 1; i < 11; i++)
            {
                btn = new Button();
                btn.Text = $"Кнопка {i}";
                btn.BackgroundColor = Color.FromRgb(i * 9, i * 27, i * 19);

                btn.Clicked += Button_Clicked;

                stackLayout.Children.Add(btn);
            }
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", $"{(sender as Button).Text}", "Ок");

            
        }
    }
}
