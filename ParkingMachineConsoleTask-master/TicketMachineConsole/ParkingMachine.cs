﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;
        public double CostPerHour
        {
            get
            {
                return CostPerHour;
            }
        }

        public ParkingMachine(int costPerH)
        {
            total = 0;
            currentTotal = 0;
            costPerHour = costPerH;
        }

        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
        }

        public int CurrentTotal
        {
            get
            {
                return currentTotal;
            }
        }

        public int Total
        {
            get
            {
                return total;
            }
        }

        public void InsertMoney(int value)
        {
            if (value > 0)
            {
                currentTotal = value + currentTotal;
            }
        }
       
        public int Cancel()
        {
            int temp = currentTotal;
            currentTotal = 0;
            return temp;
        }

        public string BuyTicket()
        {
            total += currentTotal;
            Console.WriteLine(total);
            int tCurrentTotal = currentTotal;
            currentTotal = 0;
            return "Parking ticket valid for:" + Environment.NewLine +
                ((tCurrentTotal / costPerHour) / 24) + " days" + Environment.NewLine +
                ((tCurrentTotal / costPerHour) % 24) + " hours" + Environment.NewLine +
                ((tCurrentTotal * 60 / costPerHour)) % 60 + " minutes";
        }
        public void BuyTicket2Day3Hour15Min_TicketText()
        {
            throw new NotImplementedException();
        }


        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes";
        }





    }
}
