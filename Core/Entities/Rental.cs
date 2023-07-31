namespace CarRentalApplication.Core.Entities
{
    public class Rental
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CarId { get; set; }
        public Guid CustomerId { get; set; }
        public bool HasDriver { get; set; }
        public decimal TotalFare { get; set; }
      
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
        public string Status { get; set; }

     
    }
}
