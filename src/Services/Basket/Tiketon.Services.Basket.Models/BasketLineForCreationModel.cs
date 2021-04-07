﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Tiketon.Services.Basket.Models
{
    public class BasketLineForCreationModel
    {
        [Required] public Guid EventId { get; set; }

        [Required] public int Price { get; set; }

        [Required] public int TicketAmount { get; set; }
    }
}