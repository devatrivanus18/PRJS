namespace PRJS.Models;

public class InvoiceSellUnit
{
    public int orderNo { get; set; }
    public int itemNo { get; set; }
    public string eName { get; set; }
    public string aName { get; set; }
    public string unitNo { get; set; }
    public float price { get; set; }
    public int quantity { get; set; }
    public float discount { get; set; }
    public float total { get; set; }
    public float taxRate1_Percentage { get; set; }
    public float taxRate1_Total { get; set; }
    public float totalPlusTax { get; set; }
}
