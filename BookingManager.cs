using System;

namespace PR6
{
    class BookingManager
    {
        private static BookingManager instance;
        private BookingManager() { }
        public static BookingManager getInstance()
        {
            if (instance == null) instance = new BookingManager();
            return instance;
        }
        public double CalculateTotalCost(DateTime fromDate, DateTime toDate, double costPerDay)
        {
            int days = (toDate - fromDate).Days + 1;
            return costPerDay * days;
        }
    }
}