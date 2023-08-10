using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.ViewModels
{
    class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        public string Username { get; }
        public string IsSubscribedDisplay { get; }
        public bool IsMember { get; }

        public YouTubeViewersDetailsViewModel() 
        {
            Username = "Arata";
            IsSubscribedDisplay = "Yes";
            IsMember = true;
        }
    }
}
