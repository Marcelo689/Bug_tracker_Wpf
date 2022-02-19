using Bug_tracker.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bug_tracker.View
{
    /// <summary>
    /// Lógica interna para TesteView.xaml
    /// </summary>
    public partial class TesteView : Window
    {
        public TesteView()
        {
            InitializeComponent();
            DataContext = new TesteViewModel();
        }
    }
}
