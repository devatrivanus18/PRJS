using MvvmHelpers;
using PRJS.Models;
using PRJS.Services;
using PRJS.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Command = MvvmHelpers.Commands.Command;

namespace PRJS.ViewModels;

public class HomeViewModel : BaseViewModel
{
    private ObservableCollection<InvoiceSellUnit> _listInvoiceSellUnit = new ObservableCollection<InvoiceSellUnit>();
    public ObservableCollection<InvoiceSellUnit> ListInvoiceSellUnit { get => _listInvoiceSellUnit; set => SetProperty(ref _listInvoiceSellUnit, value); }

    private InvoiceSell _invoiceSell = new InvoiceSell();
    public InvoiceSell InvoiceSell { get => _invoiceSell; set => SetProperty(ref _invoiceSell, value); }

    private InvoiceSellUnit _invoiceSellUnit = new InvoiceSellUnit();
    public InvoiceSellUnit InvoiceSellUnit { get => _invoiceSellUnit; set => SetProperty(ref _invoiceSellUnit, value); }

    private ObservableCollection<Product> _products = new ObservableCollection<Product>();
    public ObservableCollection<Product> Products { get => _products; set => SetProperty(ref _products, value); }

    private float _subNetTotal;
    public float SubNetTotal { get => _subNetTotal; set => SetProperty(ref _subNetTotal, value); }
    private float _taxTotal;
    public float TaxTotal { get => _taxTotal; set => SetProperty(ref _taxTotal, value); }


    private float _subNetTotalPlusTax;
    public float SubNetTotalPlusTax { get => _subNetTotalPlusTax; set => SetProperty(ref _subNetTotalPlusTax, value); }

    public Product product { get; set; }
    public InvoiceSell SelectedInvoice { get; set; } = new InvoiceSell();

    public ICommand SaveCommand { get; set; }
    public ICommand SaveDetailCommand { get; set; }
    public ICommand OnSelectedItemCommand { get; set; }
    public ICommand OnEditingItemCommand { get; set; }
    public ICommand CalculateCommand { get; set; }
    public DatabaseService DatabaseService { get; set; }
    IInvoiceSelected DataService;

    public HomeViewModel()
    {
        DatabaseService = new DatabaseService();
        DataService = new InvoiceSelectedService();
        SaveCommand = new Command(SaveInvoice);
        OnSelectedItemCommand = new Command(AddItemToInvoiceSellUnit);
        OnEditingItemCommand = new Command(OnEditingCell);
        CalculateCommand = new Command(CalculateTotal);
        SelectedInvoice = DataService.InvoiceSelected;
        Products.Add(new Product { unitNo = "1", eName = "Apple", aName = "يالللقرت٤", itemNo = 1, price = 100000 });
        Products.Add(new Product { unitNo = "2", eName = "Grape", aName = "يالللقرت٤", itemNo = 2, price = 1300000 });
        Products.Add(new Product { unitNo = "3", eName = "Banana", aName = "يالللقرت٤", itemNo = 3, price = 1600000 });
    }

    private void CalculateTotal(object obj)
    {
        SubNetTotal = ListInvoiceSellUnit.Sum(x => x.total);
        TaxTotal = ListInvoiceSellUnit.Sum(x => x.taxRate1_Total);
        SubNetTotalPlusTax = SubNetTotal + TaxTotal;
    }

    private void OnEditingCell(object obj)
    {
        
        var item = obj as InvoiceSellUnit;

        item.total = item.quantity * item.price - item.discount;
        item.taxRate1_Total = item.taxRate1_Percentage / 100 * item.total;
        item.totalPlusTax = item.total + item.taxRate1_Total;
    }
    private void SaveInvoice(object obj)
    {
        saveInvoiceSell();
        saveInvoiceSellUnit();
    }

    private void AddItemToInvoiceSellUnit(object obj)
    {
        var item = obj as Product;
        ListInvoiceSellUnit.Add(new InvoiceSellUnit
        {
            eName = item.eName,
            aName = item.aName,
            price = item.price,
            unitNo = item.unitNo,
            itemNo = item.itemNo,
        });
    }

    public async void saveInvoiceSell()
    {
        InvoiceSell invoicesell = InvoiceSell;
        invoicesell.subNetTotal = SubNetTotal;
        invoicesell.taxRate1_Total = TaxTotal;
        invoicesell.subNetTotalPlusTax = SubNetTotalPlusTax;
        await DatabaseService.SaveInvoiceSellAsync(invoicesell);
        await Application.Current.MainPage.Navigation.PushAsync(new GridDataPage());


    }

    public async void saveInvoiceSellUnit()
    {
        InvoiceSellUnit invoicesellunit = InvoiceSellUnit;

        foreach (var item in ListInvoiceSellUnit)
        {
            invoicesellunit = item;
            await DatabaseService.SaveInvoiceSellUnitAsync(invoicesellunit);
        }
    }
}
