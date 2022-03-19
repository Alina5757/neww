﻿using CannedFactoryContracts.Enums;
using System;

namespace CannedFactoryFileImplement.Models
{
    //заказ
    public class Order
    {
        public int Id { get; set; }

        public int CannedId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public OrderStatus status { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateImplement { get; set; }
    }
}
