using Bug_tracker.ViewModel;
using System.Windows;

namespace Bug_tracker.View
{
    /// <summary>
    /// Lógica interna para TelaEditarView.xaml
    /// </summary>
    public partial class TelaEditarView : Window
    {
        public TelaEditarView(int? id)
        {
            DataContext = new TelaEditarViewModel(id);
            InitializeComponent();
        }
    }
}
