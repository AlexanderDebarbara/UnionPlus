using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Union.View
{
    public partial class Aluno : ContentPage
    {
        public Aluno()
        {

            InitializeComponent();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }


        private void Gravar(object o, EventArgs e)
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
