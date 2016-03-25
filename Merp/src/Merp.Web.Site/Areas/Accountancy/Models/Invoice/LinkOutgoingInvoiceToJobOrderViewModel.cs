﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Merp.Web.Site.Areas.Accountancy.Models.Invoice
{
    public class LinkOutgoingInvoiceToJobOrderViewModel
    {
        public string InvoiceNumber { get; set; }
        public Guid InvoiceOriginalId { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public DateTime DateOfLink { get; set; }

        [Required]
        public string JobOrderNumber { get; set; }
    }
}