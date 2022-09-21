using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJS.Models;

public class InvoiceSell
{
    public bool isVoid { get; set; }
    public bool isPosted { get; set; }
    public bool isPayments { get; set; }
    public bool isOutDelivery { get; set; }
    public DateTime dateH { get; set; }
    public DateTime dateG { get; set; }
    public string eName { get; set; } = string.Empty;
    public string invoiceNo { get; set; } = string.Empty;
    [AutoIncrement]
    [PrimaryKey]
    public int? invoiceVATID { get; set; }
    public int? carNo { get; set; }
    public int? mainContact1 { get; set; }
    public string lblSearchProduct { get; set; } = string.Empty;
    public string aName { get; set; } = string.Empty;
    public int? clientVendorNo { get; set; }
    public float? subNetTotalPlusTax { get; set; }
    public float? amountLeft { get; set; }
    public float? taxRate1_Total { get; set; }
    public float? subNetTotal { get; set; }
    public float? subNetTotalDiscount { get; set; }
    public float? subQuantity { get; set; }
    public float? amountLeftAfterAllBills { get; set; }
   // public List<InvoiceSellUnit> invoiceSellUnits { get; set; }
}
