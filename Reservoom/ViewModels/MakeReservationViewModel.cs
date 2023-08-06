using System;
using System.Windows.Input;

namespace Reservoom.ViewModels
{
    class MakeReservationViewModel : ViewModelBase
    {
        private string _username; public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }
        private int _floorNumber; public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                OnPropertyChanged();
            }
        }
        private int _roomNumber; public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnPropertyChanged();
            }
        }

        private DateTime _startDate; public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        private DateTime _endDate; public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChanged();
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel()
        {

        }
    }
}
