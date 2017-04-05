using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Union.Model;

namespace Union.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel(Pessoa pessoa)
        {
            NomeCompleto = pessoa.PrimeiroNome + " " + pessoa.SegundoNome;
            Email = pessoa.Email;
            Telefone = pessoa.Telefone;
            Idade = CalcularIdade(pessoa.Aniverssario);
        }

        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }

        private int CalcularIdade(DateTime Aniverssario)
        {
            return 21;
        }

        public static Pessoa GetPessoa()
        {
            var pessoa = new Pessoa()
            {
                PrimeiroNome = "Alexander",
                SegundoNome = "Debarbara",
                Email = "debarbara4@gmail.com",
                Telefone = "6532036920",
                Aniverssario = new DateTime(1996, 09, 11),
                Id = 123
            };

            return pessoa;
        }
    }
}
