using Prism.Navigation;
using prismforms.Services.Contracts;

namespace prismforms.ViewModels
{
    public class HomePageViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ISampleService _sampleService;

        public HomePageViewModel(INavigationService navigationService, ISampleService sampleService)
        {
            _navigationService = navigationService;
            _sampleService = sampleService;
        }
    }
}