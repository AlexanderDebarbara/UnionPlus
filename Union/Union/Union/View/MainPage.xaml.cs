using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Union.Model;
using Union.ViewModel;
using Xamarin.Forms;

namespace Union.View
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            Pessoa pessoa = MainPageViewModel.GetPessoa();
            vm = new MainPageViewModel(pessoa);
            BindingContext = vm;

            InitializeComponent();
        }
    }
}
