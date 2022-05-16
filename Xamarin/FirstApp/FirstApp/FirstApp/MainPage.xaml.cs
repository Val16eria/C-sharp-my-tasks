using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout();

            Label label1 = new Label();

            label1.Text = "Урок 4";
            label1.TextColor = Color.Red;
            label1.FontSize = 20;
            label1.FontAttributes = FontAttributes.Bold;
            label1.HorizontalOptions = LayoutOptions.Center;

            Entry input = new Entry();

            input.Placeholder = "Пароль";
            input.IsPassword = true;

            Entry input1 = new Entry()
            {
                IsEnabled = false,
                Text = "Что-то написано"
            };

            StackLayout horizontalStack = new StackLayout();
            horizontalStack.Orientation = StackOrientation.Horizontal;

            Label sub = new Label()
            {
                Text = "Подписаться",
                FontSize = 25,
                FontAttributes = FontAttributes.Bold
            };

            CheckBox checkBox = new CheckBox()
            {
                IsChecked = true
            };

            horizontalStack.Children.Add(sub);
            horizontalStack.Children.Add(checkBox);


            layout.Children.Add(label1);
            layout.Children.Add(input);
            layout.Children.Add(input1);
            layout.Children.Add(horizontalStack);

            Content = layout;
        }
    }
}
