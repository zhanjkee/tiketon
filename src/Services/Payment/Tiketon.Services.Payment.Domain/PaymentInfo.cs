﻿namespace Tiketon.Services.Payment.Domain
{
    public class PaymentInfo
    {
        public int Total { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public string CardExpiration { get; set; }
    }
}