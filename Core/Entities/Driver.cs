namespace CarRentalApplication.Core.Entities
{
    public class Driver
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
