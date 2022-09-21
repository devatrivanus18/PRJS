using PRJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJS.Services
{
    public interface IInvoiceSelected
    {
        InvoiceSell InvoiceSelected { get; set; }

        void SetInvoiceSelected(InvoiceSell item);
    }
}
