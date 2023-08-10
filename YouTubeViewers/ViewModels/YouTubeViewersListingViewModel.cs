using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.ViewModels
{
    class YouTubeViewersListingViewModel
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;
    
        public YouTubeViewersListingViewModel()
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Arata"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Sean"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Alan"));
        }
       
    
    }

}
