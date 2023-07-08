namespace CarRentalApplication.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
