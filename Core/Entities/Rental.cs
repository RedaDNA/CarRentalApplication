namespace CarRentalApplication.Core.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CarId { get; set; }
        //public bool HasDriver { get; set; }
        public decimal TotalFare { get; set; }
       // public virtual ICollection<Car> Cars { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
