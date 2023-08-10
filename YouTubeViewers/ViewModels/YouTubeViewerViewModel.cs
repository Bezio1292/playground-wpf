using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.ViewModels
{
    class YouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }
        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }

        public ICommand AddYouTubeViewersCommand { get; }

        public YouTubeViewerViewModel()
        {
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel();
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
        }
    }
}
