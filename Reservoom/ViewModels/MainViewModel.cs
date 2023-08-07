using Reservoom.Models;
namespace Reservoom.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
