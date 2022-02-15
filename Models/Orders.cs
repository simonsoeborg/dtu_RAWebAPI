﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAWebAPI.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int itemId { get; set; }
        public int quantity { get; set; }
        public int TableId { get; set; }
        public int ReservationId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public Boolean orderFinished { get; set; }
    }
}
