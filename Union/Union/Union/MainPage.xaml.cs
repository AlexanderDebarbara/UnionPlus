using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Pessoa pessoa = Init();
            BindingContext = pessoa;
            InitializeComponent();
        }

       private Pessoa Init()
        {
            return new Pessoa { Nome = "Alexander Debarbara", Telefone ="6532036920", Email = "debarbara4@gmail.com" };
        }
    }
}
