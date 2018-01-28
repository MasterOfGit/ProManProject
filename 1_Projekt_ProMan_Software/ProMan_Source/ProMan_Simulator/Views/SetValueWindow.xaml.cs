using ProMan_Simulator.Base;
using System.Windows;


namespace ProMan_Simulator
{
    /// <summary>
    /// Interaktionslogik für SetValueWindow.xaml
    /// </summary>
    public partial class SetValueWindow : Window
    {
        public SetValueWindow()
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
