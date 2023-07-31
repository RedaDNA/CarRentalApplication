namespace CarRentalApplication.Core.Entities
{
    public class CarDriver
    {
        public virtual Driver Driver { get; set; }
        public virtual Car Car { get; set; }


        public int CarId { get; set; }
        public int DriverId { get; set; }
    }
}
