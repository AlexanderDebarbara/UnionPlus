using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union.View
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            Content = new ScrollView { Content = CreatePage() };
            InitializeComponent();
        }

        public StackLayout CreatePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var txtLogin = new Entry
            {
                Placeholder = "Login",
                Keyboard = Keyboard.Email,
                Text = ""
            };
            var txtSenha = new Entry
            {
                Placeholder = "Senha",
                IsPassword = true,
                Text = ""
            };

            var btnCadastrar = new Button()
            {
                Text = "Cadastrar",
                BackgroundColor = Color.FromRgb(41, 115, 224),
                TextColor = Color.White
            };
            btnCadastrar.Clicked += Cadastrar;

            var btnEntrar = new Button()
            {
                Text = "Entrar",
                BackgroundColor = Color.FromRgb(104, 180, 47),
                TextColor = Color.White
            };
            btnEntrar.Clicked += Entrar;

            var headStack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = 30,
                Children =
                {
                    new StackLayout()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Center,
                        Children =
                        {
                            new Image()
                            {
                                Source = "logounion.png"
                            }
                        }

                    },
                    new StackLayout()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Start,
                        Children =
                        {
                            txtLogin,
                            txtSenha
                            
                        }
                    },
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        Children =
                        {
                           btnCadastrar,
                           btnEntrar                           
                        }
                    }

                }
            };
            return headStack;
        }
        private void Cadastrar(object sender, EventArgs e)
        {
            try
            {
               Navigation.PushAsync(new CadastrarAluno());
               
            }            
            
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void Entrar(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new AbrirPaginas());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
