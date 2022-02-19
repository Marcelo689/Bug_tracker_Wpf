using Bug_tracker.ViewModel;
using System.Windows;

namespace Bug_tracker.View
{
    /// <summary>
    /// Lógica interna para TelaPrincipal.xaml
    /// </summary>
    public partial class TelaPrincipal : Window
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            DataContext = new TelaPrincipalViewModel();            
        }
    }
}
