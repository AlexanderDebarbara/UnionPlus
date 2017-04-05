using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union.View
{
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            Title = "Noticias";
            OnAppearing();
            Content = new ScrollView { Content = GetPage() };
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = "Noticias";
        }
        private StackLayout GetPage()
        {

            var headStack = new StackLayout()
            {
                
            };
            return headStack;
        }
    }
}
