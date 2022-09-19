using MvvmHelpers;
using PRJS.Models;
using PRJS.Services;
using System.Collections.ObjectModel;

namespace PRJS.ViewModels;

public class GridViewModel : BaseViewModel
{
    private ObservableCollection<InvoiceSell> _listInvoiceSell = new ObservableCollection<InvoiceSell>();
    public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }

    public DatabaseService DatabaseService { get; set; }
    public GridViewModel()
    {
        DatabaseService = new DatabaseService();
        ListInvoiceSell = DatabaseService.ListInvoiceSell;
        //saveInvoiceSell();
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
