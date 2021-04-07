﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Tiketon.Services.Basket.Domain.Entities
{
    public class BasketLine
    {
        public Guid BasketLineId { get; set; }

        [Required] public Guid BasketId { get; set; }

        [Required] public Guid EventId { get; set; }

        public Event Event { get; set; }

        [Required] public int TicketAmount { get; set; }

        [Required] public int Price { get; set; }

        public Basket Basket { get; set; }

        public void SetTicketAmount(int ticketAmount)
        {
            TicketAmount = ticketAmount;
        }
    }
}