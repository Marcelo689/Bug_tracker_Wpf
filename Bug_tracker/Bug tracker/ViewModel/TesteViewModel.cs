using Prism.Commands;
using Prism.Mvvm;
using System.Windows;
using System.Windows.Input;
namespace Bug_tracker.ViewModel
{
    public class TesteViewModel
    {
        
        public class NomeCompleto : BindableBase
        {
            private string _nome = ""; 
            private string _sobrenome = "";
            public string Nome { get => _nome; set { SetProperty(ref _nome, value); } }
            public string Sobrenome { get => _sobrenome; set { SetProperty(ref _sobrenome, value); } }
        }

        public NomeCompleto Nome { get; set; }
        public ICommand Clickar { get; set; }
        public TesteViewModel()
        {
            Nome = new NomeCompleto(){ 
                Nome = "Marcelo",
                Sobrenome = "Jaeger"
            };
            Clickar = new DelegateCommand(AtualizarValor); 
        }
        public void AtualizarValor()
        {
            MessageBox.Show("Funciona "+Nome.Nome);

        }
    }
}
