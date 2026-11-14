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
            // Cria a janela definindo a página inicial e as dimensões desejadas
            var window = new Window(new AppShell()) // Ou new Window(new MainPage()) dependendo do seu projeto
            {
                Width = 400,
                Height = 600
            };

            return window;
        }
    }
}
