using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsoleTicket
{
    public class Ticket
    {
        private DateTime purchaseTime;
        private readonly int costPerHour;
        private readonly int price;

        
        public Ticket(int price, int costPerHour)
        {
            this.price = price;
            this.costPerHour = costPerHour;

        }

        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }

        }

        public int Price
        {
            get
            {
                return price;
            }
        }

        public TimeSpan GetParkingTimeSpan()
        {
            int days = price / costPerHour / 24;
            int hour = (price / costPerHour) % 24;
            int minute = (price * 60 / costPerHour) % 60;
            return new TimeSpan(days, hour, minute, 0);
        }





    }
}