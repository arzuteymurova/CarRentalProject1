﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class RentalDetailsDto : IDto
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCompanyName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
