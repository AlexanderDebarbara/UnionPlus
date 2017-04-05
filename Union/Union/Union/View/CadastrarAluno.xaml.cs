using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union.View
{
    public partial class CadastrarAluno : ContentPage
    {
        
        public CadastrarAluno()
        {
            Title = "Cadastrar Aluno";
            OnAppearing();
            Content = new ScrollView { Content = GetPage() };
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = "Cadastrar Aluno";
        }
        public StackLayout GetPage()
        {
            var txtNome = new Entry()
            {
                Placeholder = "Nome",
                Text = ""

            };
            var txtEmail = new Entry()
            {
                Placeholder = "E-mail",
                Keyboard = Keyboard.Email,
                Text = ""
            };
            var txtTelefone = new Entry()
            {
                Placeholder = "Telefone",
                Keyboard = Keyboard.Numeric,
                Text = ""
            };
            var txtSenha = new Entry()
            {
                Placeholder = "Senha"
            };
            var btnCadastrar = new Button()
            {
                Text = "Cadastrar",
                BackgroundColor = Color.FromRgb(41, 115, 224),
                TextColor = Color.White                
            };
            btnCadastrar.Clicked += Cadastrar;

            var headStack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = 30,
                Children =
                {
                    new StackLayout()
                    {                        
                        Children =
                        {
                            txtNome,
                            txtEmail,
                            txtTelefone,
                            txtSenha
                        }
                    },
                    btnCadastrar
                }
            };
            return headStack;
        }
        private void Cadastrar(object obj, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
