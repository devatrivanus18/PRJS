using MvvmHelpers;
using PRJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJS.Services
{
    internal class InvoiceSelectedService : ObservableObject, IInvoiceSelected
    {
        private InvoiceSell _invoiceSell = new();
        public InvoiceSell InvoiceSelected { get => _invoiceSell; set => SetProperty(ref _invoiceSell, value); }

        public void SetInvoiceSelected(InvoiceSell item) => _invoiceSell = item;
    }
}
