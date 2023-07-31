﻿namespace CarRentalApplication.Core.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
