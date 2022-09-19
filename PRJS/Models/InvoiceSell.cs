using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJS.Models;

public class InvoiceSell
{
    public string eName { get; set; }
    public int invoiceVATID { get; set; }
    public int carNo { get; set; }
    public int mainContact1 { get; set; }
    public string lblSearchProduct { get; set; }
    public string aName { get; set; }
    public int clientVendorNo { get; set; }
    public float subNetTotalPlusTax { get; set; }
    public float amountLeft { get; set; }
    public float taxRate1_Total { get; set; }
    public float subNetTotal { get; set; }
    public float subNetTotalDiscount { get; set; }
    public float subQuantity { get; set; }
    public float amountLeftAfterAllBills { get; set; }
}
