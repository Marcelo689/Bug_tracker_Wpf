using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bug_tracker.Model
{
    public class Bug :BindableBase
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Comentario { get; set; }
        public string Versao { get; set; }
        public string Autor { get; set; }
        public string Prioridade { get; set; }
        public string Tela { get; set; }
    }
}
