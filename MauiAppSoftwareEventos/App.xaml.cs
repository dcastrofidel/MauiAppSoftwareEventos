namespace MauiAppSoftwareEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoDeEventos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var Window = base.CreateWindow(activationState);

            Window.Width = 400;
            Window.Height = 600;

            return Window;
        }
    }
}
