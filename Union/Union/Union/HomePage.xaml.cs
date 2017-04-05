using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            Content = CreatePage();
            InitializeComponent();
        }

        public View CreatePage()
        {
            var headStack = new StackLayout()
            {
                Padding = 30,
                Children =
                {
                    new Label()
                    {
                        FontSize = 30,
                        Text = "Order Form",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Label()
                            {
                                Text = "Custumer"
                            },
                            new Entry
                            {
                                Placeholder = "Enter Full Name"
                            }
                        }
                    },
                    new Button() {Text ="Click ME" }
                }
            };
            return headStack;
        }
    }
}
