using ProMan_Simulator.Model;
using ProMan_Simulator.Views;
using System.Windows;

namespace ProMan_Simulator.Helper
{
    public static class WindowService
    {
        public static void ShowSetValueWindow(SetValueModel viewModel)
        {
            var win = new SetValueWindow();
            win.DataContext = viewModel;
            win.Show();
        }

        public static void ShowUpdateValueWindow(UpdateValueModel viewModel)
        {
            var win = new UpdateValueWindow();
            win.DataContext = viewModel;
            win.Show();

        }
    }
}
