namespace CarRentalApplication.Core.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string CarNumber { get; set; }
        public string Type { get; set; }
        public int EngineCapacity { get; set; }
        public string Color { get; set; }
        public decimal DailyFare { get; set; }
        public bool HasDriver { get; set; }
        public int? DriverId { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    
        public virtual Driver Driver { get; set; }

    }

}
