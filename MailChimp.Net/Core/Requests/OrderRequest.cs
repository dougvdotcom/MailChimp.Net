﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    public class OrderRequest : QueryableBaseRequest
    {
        [QueryString("customer_id")]
        public string CustomerId { get; set; }
    }
}
