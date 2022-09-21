using MvvmHelpers;
using PRJS.Models;
using PRJS.Services;
using System.Collections.ObjectModel;

namespace PRJS.ViewModels
{
    public class GridViewModel : BaseViewModel
    {
        private ObservableCollection<InvoiceSell> _listInvoiceSell = new ObservableCollection<InvoiceSell>();
        public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }

        private ObservableCollection<InvoiceSellUnit> _listInvoiceSellUnit = new ObservableCollection<InvoiceSellUnit>();
        public ObservableCollection<InvoiceSellUnit> ListInvoiceSellUnit { get => _listInvoiceSellUnit; set => SetProperty(ref _listInvoiceSellUnit, value); }
        public DatabaseService DatabaseService { get; set; }
        public GridViewModel()
        {
            DatabaseService = new DatabaseService();
            ListInvoiceSell = DatabaseService.ListInvoiceSell;
            ListInvoiceSellUnit = DatabaseService.ListInvoiceSellUnit;
        }
    }


}
