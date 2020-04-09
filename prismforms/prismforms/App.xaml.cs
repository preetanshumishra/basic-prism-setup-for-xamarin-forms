using Prism;
using Prism.Ioc;
using Prism.Unity;
using prismforms.Services.Contracts;
using prismforms.Services.Implementations;
using prismforms.ViewModels;
using prismforms.Views;

namespace prismforms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            // Navigate to First Screen.
            NavigationService.NavigateAsync("/CustomNavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register ViewModels for Navigation
            containerRegistry.RegisterForNavigation<CustomNavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();

            // Register Services for Injection
            containerRegistry.Register<ISampleService, SampleService>();
        }
    }
}