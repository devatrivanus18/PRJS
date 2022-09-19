using MvvmHelpers;
using PRJS.Models;
using PRJS.Services;
using System.Collections.ObjectModel;

namespace PRJS.ViewModels;

public class GridViewModel : BaseViewModel
{
    private ObservableCollection<InvoiceSell> _listInvoiceSell = new ObservableCollection<InvoiceSell>();
    public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }

    private ObservableCollection<InvoiceSellUnit> _listInvoiceSellUnit = new ObservableCollection<InvoiceSellUnit>();
    public ObservableCollection<InvoiceSellUnit> ListInvoiceSellUnit { get => _listInvoiceSellUnit; set => SetProperty(ref _listInvoiceSellUnit, value); }

    private InvoiceSell _invoiceSell = new InvoiceSell();
    public InvoiceSell InvoiceSell { get => _invoiceSell; set => SetProperty(ref _invoiceSell, value); }

    private InvoiceSellUnit _invoiceSellUnit = new InvoiceSellUnit();
    public InvoiceSellUnit InvoiceSellUnit { get => _invoiceSellUnit; set => SetProperty(ref _invoiceSellUnit, value); }

    public DatabaseService DatabaseService { get; set; }
    public GridViewModel()
    {
        DatabaseService = new DatabaseService();
        ListInvoiceSell = DatabaseService.ListInvoiceSell;
    }


    public async void saveInvoiceSell()
    {
        InvoiceSell invoice = new InvoiceSell { eName = "Deva Trivanus2" };
        await DatabaseService.SaveInvoiceSellAsync(invoice);
    }

    public async void UpdateInvoiceSell()
    {
        await DatabaseService.UpdateInvoiceSellAsync(null);
    }

    public async void deleteInvoiceSell()
    {
        await DatabaseService.DeleteInvoiceSellAsync(null);
    }
}
