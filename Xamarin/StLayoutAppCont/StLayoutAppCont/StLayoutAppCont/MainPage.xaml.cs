 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StLayoutAppCont
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout stackLayout1 = new StackLayout()
            {
                Margin = new Thickness(15),
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label { Text = "Слева", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Start },
                    new Label { Text = "По центру", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Center },
                    new Label { Text = "Справа", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.End },
                    new Label { Text = "На всю ширину", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Fill },
                }
            };

            Content = stackLayout1;
        }
    }
}
