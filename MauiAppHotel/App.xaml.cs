using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Cria a janela principal do app definindo o AppShell e o tamanho desejado
            var window = new Window(new AppShell());

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}