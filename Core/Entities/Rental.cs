﻿using System.ComponentModel.DataAnnotations;

namespace CarRentalApplication.Core.Entities
{
    public class Rental
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CarId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? DriverId { get; set; }

        public decimal TotalFare { get; set; }
        public virtual Driver Driver { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }

        public RentalStatus Status { get; set; }


    }
    public enum RentalStatus
    {
        rented,
        returned,
        canceled
    }
}
