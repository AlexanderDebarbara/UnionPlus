using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Union
{
    public class AbrirPaginas: TabbedPage
    {
        public AbrirPaginas()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Children.Add(new View.PaginaInicial());
            Children.Add(new View.Instituicao());            
        }
    }
}
