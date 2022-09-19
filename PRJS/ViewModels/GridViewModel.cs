using PRJS.Models;
using PRJS.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJS.ViewModels;

public class GridViewModel
{
    private ObservableCollection<InvoiceSell> _listInvoiceSell = new ObservableCollection<InvoiceSell>();
    public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }
	
	public DatabaseService DatabaseService { get; set; }
	public GridViewModel()
	{
        DatabaseService = new DatabaseService();
        ListInvoiceSell = DatabaseService.ListInvoiceSell;
    }
}
