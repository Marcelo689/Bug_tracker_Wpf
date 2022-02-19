using Bug_tracker.Model;
using Bug_tracker.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Bug_tracker.ViewModel
{
    public class TelaEditarViewModel : BindableBase
    {
        private int? id;
        public Bug _bug = new Bug();
        public List<string> _prioridades = new List<string>()
        {
            "1","2","3","4","5","6","7","8","9","10"
        };
        public List<string> Prioridades { get => _prioridades; set { SetProperty(ref _prioridades, value); } }
        public ICommand PegarBug { get; set; }
        public ICommand Atualizar { get; set; }
        public ICommand LimparPrioridade { get; set; }
        public ICommand LimparCampos { get; set; }
        public Bug Bug
        {
            get { return _bug; }
            set { SetProperty(ref _bug, value); }
        }
        public TelaEditarViewModel(int? id)
        {
            this.id = id;
            PegarBug = new DelegateCommand(GetBug);
            Atualizar = new DelegateCommand(AtualizarBug);
            LimparPrioridade = new DelegateCommand(PrioridadeBranco);
            LimparCampos = new DelegateCommand(LimparTudo);
        }

        private void GetBug()
        {
            IDataService<Bug> service = new GenericDatabaseServices<Bug>(new Conexao.Conexao());
            Bug = service.Get(id.Value);
        }

        public void AtualizarBug()
        {
            IDataService<Bug> service = new GenericDatabaseServices<Bug>(new Conexao.Conexao());
            service.Update(id.Value,Bug);
            MessageBox.Show("Registro atualizado com sucesso!");
        }
        public void PrioridadeBranco()
        {
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
    }
}