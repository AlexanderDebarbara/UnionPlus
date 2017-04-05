using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union.View
{
    public partial class Instituicao : ContentPage
    {

        public Instituicao()
        {
            Title = "Instituição";

            Content = new ScrollView { Content = GetPage() };
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = "Instituição";
        }
        private StackLayout GetPage()
        {
            var txtInstituicao = new Entry()
            {
                Placeholder = "Instituição"            

            };
            var btnGravar = new Button()
            {
                Text = "Gravar",
                BackgroundColor = Color.Blue,
                TextColor = Color.White
            };
            btnGravar.Clicked += Gravar;
            
            var bodyStack = new StackLayout()
            {
                Padding = 20,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new StackLayout()
                    {
                        Children =
                        {
                            txtInstituicao
                            , btnGravar
                        }
                    }
                    
                }
            };
            return bodyStack;
        }
        private void Gravar(object o, EventArgs e)
        {

        }
    }
}
