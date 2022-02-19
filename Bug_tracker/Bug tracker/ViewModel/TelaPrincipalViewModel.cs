using Bug_tracker.Model;
using Bug_tracker.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows;
using Bug_tracker.View;

namespace Bug_tracker.ViewModel
{
    public class TelaPrincipalViewModel : BindableBase
    {
        public ObservableCollection<Bug> _ListaBugs = new ObservableCollection<Bug>();
        public ObservableCollection<Bug> ListaBugs { get => _ListaBugs; set { SetProperty(ref _ListaBugs, value); } }
        public List<string> _prioridades = new List<string>()
        {
            "1","2","3","4","5","6","7","8","9","10"
        };
        public List<string> _crescenteDescrescenteList = new List<string>()
        {
            "Crescente","Decrescente"
        };
        public List<string> CrescenteDecrescenteList { get => _crescenteDescrescenteList; set { SetProperty(ref _crescenteDescrescenteList, value); } }

        public List<string> _ordenarList = new List<string>()
        {
            "Não Ordenar","Prioridade","Versão"
        };
        public List<string> OrdenarList { get => _ordenarList; set{ SetProperty(ref _ordenarList, value); } }
        public List<string> Prioridades { get => _prioridades; set { SetProperty(ref _prioridades, value); } }
        public ICommand Adicionar { get; set; }
        public ICommand ListarBugs { get; set; }
        public ICommand Filtrar { get; set; }
        public ICommand Deletar { get; set; }
        public ICommand LimparPrioridade { get; set; }
        public ICommand LimparCampos { get; set; }
        public ICommand Editar { get; set; }
        public ICommand Ordenar { get; set; }
        
        public string _selectedOrder = "";
        public string CrescenteDecrescenteSelected { get => _crescenteDescrescenteSelected; set { SetProperty(ref _crescenteDescrescenteSelected, value); } }
        public string _crescenteDescrescenteSelected = "";
        public string SelectedOrder { get => _selectedOrder; set { SetProperty(ref _selectedOrder, value); } }
        public void ResetarCampos()
        {
            Bug = new Bug()
            {
                Prioridade = "",
                Descricao = "",
                Comentario = "",
                Autor = "",
                Tela = "",
                Versao = ""
            };
        }

        public Bug _bug = new Bug();
        public TelaPrincipalViewModel()
        {
            ResetarCampos();    
            Adicionar = new DelegateCommand(AdicionarBug);
            ListaBugs = new ObservableCollection<Bug>();
            ListarBugs = new DelegateCommand(CarregaLista);
            Filtrar = new DelegateCommand(FiltrarBugs);
            Deletar = new DelegateCommand<int?>(DeletarBug);
            LimparPrioridade = new DelegateCommand(PrioridadeBranco);
            LimparCampos = new DelegateCommand(LimparTudo);
            Editar = new DelegateCommand<int?>(EditarBug);
            Ordenar = new DelegateCommand(OrdenarLista);
        }

        private void OrdenarLista()
        {
            if (CrescenteDecrescenteSelected == CrescenteDecrescenteList[0])
            {
                switch (SelectedOrder)
                {
                    case "Não Ordenar":
                        break;
                    case "Prioridade":
                        ListaBugs = new ObservableCollection<Bug>(ListaBugs.OrderBy(b => b.Prioridade).ToList());
                        break;
                    case "Versão":
                        ListaBugs = new ObservableCollection<Bug>(ListaBugs.OrderBy(b => b.Versao).ToList());
                        break;   

                }
            }
            else
            {
                switch (SelectedOrder)
                {
                    case "Não Ordenar":
                        break;
                    case "Prioridade":
                        ListaBugs = new ObservableCollection<Bug>(ListaBugs.OrderByDescending(b => b.Prioridade).ToList());
                        break;
                    case "Versão":
                        ListaBugs = new ObservableCollection<Bug>(ListaBugs.OrderByDescending(b => b.Versao).ToList());
                        break;

                }
            }
        }

        private void EditarBug(int? id)
        {
            Window TelaEditar = new TelaEditarView(id);
            TelaEditar.ShowDialog();
            CarregaLista();
        }

        public void PrioridadeBranco(){
            Bug = new Bug()
            {
                Prioridade = "",
                Autor = Bug.Autor,
                Comentario = Bug.Comentario,
                Descricao = Bug.Descricao,
                Versao = Bug.Versao,
                Tela = Bug.Tela,
            };
        }
        public void LimparTudo()
        {
            Bug = new Bug()
            {
                Prioridade = "",
                Autor = "",
                Comentario = "",
                Descricao = "",
                Versao = "",
                Tela = "",
            };
        }
        public void DeletarBug(int? id)
        {
            if (!(id == null))
            {
                MessageBoxResult resposta = MessageBox.Show("Você tem certeza que deseja excluir?", "Deletar Item?", MessageBoxButton.YesNo);
                if (resposta == MessageBoxResult.Yes)
                {
                    IDataService<Bug> service = new GenericDatabaseServices<Bug>(new Conexao.Conexao());
                    service.Delete(id.Value);
                    CarregaLista();
                }
            }
        }

        public bool ContemParteString(string conteudoTotal, string filtro)
        {
            if(filtro == "")
            {
                return true;
            }
            var palavras = filtro.ToLower().Split(" ");

            foreach (var palavra in palavras)
            {

                if(conteudoTotal.ToLower().IndexOf(palavra) >= 0)
                {

                }
                else
                {
                    return false;
                }
                    
            }
           return true;
                
        }

        private void FiltrarBugs()
        {
            CarregaLista();
            ObservableCollection<Bug> filtro = new ObservableCollection<Bug>(ListaBugs.AsQueryable().Where((b) =>
            ContemParteString(b.Descricao, ConvertNullToEmpty(Bug.Descricao)) &&
            ContemParteString(b.Autor, ConvertNullToEmpty(Bug.Autor)) &&
            ContemParteString(b.Comentario, ConvertNullToEmpty(Bug.Comentario)) &&
            ContemParteString(b.Prioridade, ConvertNullToEmpty(Bug.Prioridade)) &&
            ContemParteString(b.Tela, ConvertNullToEmpty(Bug.Tela)) &&
            ContemParteString(b.Versao, ConvertNullToEmpty(Bug.Versao))
             )
                );
            ListaBugs = filtro;
        }

        public string ConvertNullToEmpty(string input)
        {
            if(input == null)
            {
                return "";
            }
            else
            {
                return input;
            }
        }
        public Bug Bug
        {
            get { return _bug; }
            set { SetProperty(ref _bug, value); }
        }
        public void CarregaLista()
        {
            ListaBugs = RetornaLista();
        }

        public void AdicionarBug()
        {
            IDataService<Bug> service = new GenericDatabaseServices<Bug>(new Conexao.Conexao());
            service.Create(Bug);
            ResetarCampos();
            CarregaLista();
        }

        public ObservableCollection<Bug> RetornaLista()
        {
            IDataService<Bug> service = new GenericDatabaseServices<Bug>(new Conexao.Conexao());          
            return service.GetAll();
        }

    }


}
