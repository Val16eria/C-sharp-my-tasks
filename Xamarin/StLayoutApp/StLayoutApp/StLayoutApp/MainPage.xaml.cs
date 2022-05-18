using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StLayoutApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Content = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label { Text = "Основные цвета" },
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },
                    new Label { Text = "Основные цвета" },
                    new BoxView { Color = Color.Green },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple },
                }
            };           
        }
    }
}
