using ProMan_Simulator.Model;

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
    }
}
