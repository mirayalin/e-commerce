﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIBanka.ViewModel
{
    public class PaymentVM
    {
        public string UserName { get; set; }

        public string Number { get; set; }

        public string ExpiryMonth { get; set; }

        public string ExpiryYear { get; set; }


    }
}