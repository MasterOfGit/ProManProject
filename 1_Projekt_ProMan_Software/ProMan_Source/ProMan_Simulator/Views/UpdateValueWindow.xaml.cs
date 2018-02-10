using ProMan_Simulator.Base;
using System.Windows;


namespace ProMan_Simulator.Views
{
    /// <summary>
    /// Interaktionslogik für UpdateValueWindow.xaml
    /// </summary>
    public partial class UpdateValueWindow : Window
    {
        public UpdateValueWindow()
        {
            InitializeComponent();
        }

        //connect the base model with the close functionality.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var model = DataContext as BaseModel;
            model.RequestClose += () => { Close(); };

        }
    }
}
