using Reservoom.Exceptions;
using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Operator Suites");
            try
            {

            hotel.MakeReservation(new Reservation(
                new RoomID(2,2),
                "Arata",
                new DateTime(2000, 1, 3),
                new DateTime(2000, 1, 4)));

            hotel.MakeReservation(new Reservation(
                new RoomID(2, 2),
                "Arata",
                new DateTime(2000, 1, 3),
                new DateTime(2000, 1, 4)));

            }
            catch (ReservationConflictException ex)
            {

            }
            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Arata");

            base.OnStartup(e);
        }
    }
}
