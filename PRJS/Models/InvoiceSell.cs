﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJS.Models;

public class InvoiceSell
{
    public string buildingNo { get; set; }
    public string invoiceNo { get; set; }
    public string userNumber { get; set; }
    public string aName { get; set; }
    public string eName { get; set; }
    public string isCash { get; set; }
    public string dateG { get; set; }
    public string dateH { get; set; }
    public string deliveryDate { get; set; }
    public string deliveryDateH { get; set; }
    public string isDelivered { get; set; }
    public string deliveredDate { get; set; }
    public string deliveredDateH { get; set; }
    public string isOutDelivery { get; set; }
    public string invoiceJobStatusNo { get; set; }
    public string invoiceStatusNo { get; set; }
    public string shipType { get; set; }
    public string shipCost { get; set; }
    public string shipTo { get; set; }
    public string billToTypeNo { get; set; }
    public string billToBuildingNo { get; set; }
    public string billTo { get; set; }
    public string isInventory1GaveIt { get; set; }
    public string inventory1StaffNo { get; set; }
    public string isInventory2ReceivedIt { get; set; }
    public string inventory2StaffNo { get; set; }
    public string depositNo { get; set; }
    public string storeNo { get; set; }
    public string itemStatus { get; set; }
    public string isPostedStock { get; set; }
    public string isDeleted { get; set; }
    public string isVoid { get; set; }
    public string isPosted { get; set; }
    public string isGLPosted { get; set; }
    public string isPayments { get; set; }
    public string isFastInvoice { get; set; }
    public string isDeposited { get; set; }
    public string isCleared { get; set; }
    public string amountLeftAfterAllBills { get; set; }
    public string collectedAmountFromOtherBills { get; set; }
    public string note { get; set; }
    public string isItemOrUnit { get; set; }
    public string personNo2 { get; set; }
    public string carNo { get; set; }
    public string driverNo { get; set; }
    public string driverName { get; set; }
    public string isUseInOutInvoice { get; set; }
    public string regionNo { get; set; }
    public string isAccountingForOthers { get; set; }
    public string accountNo_Pay { get; set; }
    public string accountNo_Ship { get; set; }
    public string accountNo_Discount { get; set; }
    public string name_Pay { get; set; }
    public string name_Discount { get; set; }
    public string name_Ship { get; set; }
    public string billNo { get; set; }
    public string billTypeNo { get; set; }
    public string projectNo { get; set; }
    public string accountNo { get; set; }
    public string accountNo_Second { get; set; }
    public string agentNo { get; set; }
    public string payBillNo { get; set; }
    public string personNo { get; set; }
    public string manPosted { get; set; }
    public string manGLPosted { get; set; }
    public string manVoid { get; set; }
    public string telephone { get; set; }
    public string sumPayed { get; set; }
    public string subTotal { get; set; }
    public string subTotalDiscount { get; set; }
    public string subNetTotal { get; set; }
    public string subNetTotalPlusTax { get; set; }
    public string subCount { get; set; }
    public string subLeftQuantity { get; set; }
    public string subQuantity { get; set; }
    public string amountCalculated { get; set; }
    public string discount { get; set; }
    public string totalDiscount { get; set; }
    public string amountPayed01 { get; set; }
    public string amountPayed02 { get; set; }
    public string amountPayed03 { get; set; }
    public string amountPayed04 { get; set; }
    public string amountPayed05 { get; set; }
    public string amountLeft { get; set; }
    public string amountCalculatedPayed { get; set; }
    public string requestShipDate { get; set; }
    public string paymentTermsId { get; set; }
    public string dueDate { get; set; }
    public string pricingSchemeId { get; set; }
    public string pickedDate { get; set; }
    public string packedDate { get; set; }
    public string isCompleted { get; set; }
    public string taxingSchemeNo { get; set; }
    public string taxRate1_Percentage { get; set; }
    public string taxRate2_Percentage { get; set; }
    public string isCalculateTax2OnTax1 { get; set; }
    public string taxRate1eName { get; set; }
    public string taxRate2eName { get; set; }
    public string isTax1OnShipping { get; set; }
    public string isTax2OnShipping { get; set; }
    public string taxRate1aName { get; set; }
    public string taxRate2aName { get; set; }
    public string taxRateNo2 { get; set; }
    public string taxRate1_Total { get; set; }
    public string taxRate2_Total { get; set; }
    public string isOneInvoiceUploaded { get; set; }
    public string taxRateNo { get; set; }
    public string cashRegisterNo_BuildingNo { get; set; }
    public string invoiceVATID { get; set; }
    public string clientVendorNo { get; set; }
    public string isUploadedToMainBranch { get; set; }
    public string isPostedToTransactions { get; set; }
    public string dateG_PerDay { get; set; }
    public string dateG_PerMonth { get; set; }
    public string dateG_PerYearQuarter { get; set; }
    public string dateG_PerYearHalf { get; set; }
    public string dateG_PerYear { get; set; }
    public string VATTypeNo { get; set; }
    public string VATGroupNo { get; set; }
    public string profitMarginTotal { get; set; }
    public string dateG_Posted { get; set; }
    public string dateG_GLPosted { get; set; }
    public string mainContact1 { get; set; }
    public string mainContact2 { get; set; }
    public string mainContact3 { get; set; }
    public string amountPayed01_VoucherNo { get; set; }
    public string amountPayed02_VoucherNo { get; set; }
    public string amountPayed03_VoucherNo { get; set; }
    public string amountPayed04_VoucherNo { get; set; }
    public string amountPayed05_VoucherNo { get; set; }
    public string amountPayed01_bankAccountNo { get; set; }
    public string amountPayed02_bankAccountNo { get; set; }
    public string amountPayed03_bankAccountNo { get; set; }
    public string amountPayed04_bankAccountNo { get; set; }
    public string amountPayed05_bankAccountNo { get; set; }
    public string customerCashGiven { get; set; }
    public string customerCashReturned { get; set; }
    public string price_differenceFromFirstPriceTotal { get; set; }
    public string print_numOfCopies { get; set; }
    public string print_DateG { get; set; }
    public string leftMoneyPaymentDate { get; set; }
    public string normalCustomerTypeNo { get; set; }
    public string isPrintPartial { get; set; }
    public string cardAmount_Visa { get; set; }
    public string cardAmount_SPAN { get; set; }
    public string dailyBillNo { get; set; }
    public string runningCostAvg_diffrenceWhithPriceTotal { get; set; }
    public string profitMarginTotal_fromAvgCost { get; set; }
    public string runningCostAvgTotal { get; set; }
    public string buyPrice_costPriceTotal { get; set; }
    public string primaryUnit_QuantityTotal { get; set; }
    public string paperBillNum { get; set; }
    public string gazElectric_InNum { get; set; }
    public string gaztElectric_OutNum { get; set; }
    public string isReturnedFullyByReturnInvoice { get; set; }
    public string isReturnedFullyByReturnInvoiceDate { get; set; }
    public string weightTotal { get; set; }
    public string staffNo1_personNo { get; set; }
    public string staffNo2_personNo { get; set; }
    public string staffNo3_personNo { get; set; }
    public string exportImportType { get; set; }
    public string billCreatorAsOf { get; set; }
    public string IDCard { get; set; }
    public string billPaperType { get; set; }
    public string paymentTypes { get; set; }
    public string subNetTotal_ExecludingTax { get; set; }
    public string row_timestamp { get; set; }
}