using System.Windows;

namespace Bug_tracker.ViewModel
{
    internal class TelaEditarView : Window
    {
        private int? id;

        public TelaEditarView(int? id)
        {
            this.id = id;
        }
    }
}