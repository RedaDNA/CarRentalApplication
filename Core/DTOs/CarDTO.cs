namespace CarRentalApplication.Core.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string CarNumber { get; set; }
        public string Type { get; set; }
        public int EngineCapacity { get; set; }
        public string Color { get; set; }
        public decimal DailyFare { get; set; }
        public bool WithDriver { get; set; }
        public int? DriverId { get; set; }
    }
}
