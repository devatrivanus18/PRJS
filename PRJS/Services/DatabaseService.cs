using MvvmHelpers;
using PRJS.Models;
using SQLite;
using System.Collections.ObjectModel;

namespace PRJS.Services;

public class DatabaseService : BaseViewModel
{
    private ObservableCollection<InvoiceSell> _listInvoiceSell = new ObservableCollection<InvoiceSell>();
    public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }

    private ObservableCollection<InvoiceSellUnit> _listInvoiceSellUnit = new ObservableCollection<InvoiceSellUnit>();
    public ObservableCollection<InvoiceSellUnit> ListInvoiceSellUnit { get => _listInvoiceSellUnit; set => SetProperty(ref _listInvoiceSellUnit, value); }


    public SQLiteAsyncConnection table1;
    public SQLiteAsyncConnection table2;
    public DatabaseService()
    {
        try
        {
            string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StoreDB_501");
            table1 = new SQLiteAsyncConnection(dbpath);
            table1.CreateTableAsync<InvoiceSell>().Wait();
            table2 = new SQLiteAsyncConnection(dbpath);
            table2.CreateTableAsync<InvoiceSellUnit>().Wait();
            getdataInvoiceSell();
            getdataInvoiceSellUnit();
        }
        catch (Exception ex)
        {

            ex.Message.ToString();
        }
    }


    #region Invoice Sell
    public void getdataInvoiceSell()
    {
        var data = GetAllInvoiceSellAsync().Result;
        foreach (var item in data)
        {
            ListInvoiceSell.Add(item);
        }
    }

    public Task<List<InvoiceSell>> GetAllInvoiceSellAsync()
    {

        return table1.Table<InvoiceSell>().ToListAsync();
    }

    public Task<int> SaveInvoiceSellAsync(InvoiceSell invoiceSell)
    {
        // Save a new note.
        try
        {
            return table1.InsertAsync(invoiceSell);

        }
        catch (Exception ex)
        {

            var x = ex.Message;
        }

        return table1.InsertAsync(invoiceSell);
    }

    public Task<int> UpdateInvoiceSellAsync(InvoiceSell invoiceSell)
    {
        return table1.UpdateAsync(invoiceSell);
    }

    public Task<int> DeleteInvoiceSellAsync(InvoiceSell invoiceSell)
    {
        return table1.DeleteAsync(invoiceSell);
    }
    #endregion

    #region Invoice Sell Unit
    public void getdataInvoiceSellUnit()
    {
        var data = GetAllInvoiceSellUnitAsync().Result;
        foreach (var item in data)
        {
            ListInvoiceSellUnit.Add(item);
        }
    }
    public Task<List<InvoiceSellUnit>> GetAllInvoiceSellUnitAsync()
    {

        return table2.Table<InvoiceSellUnit>().ToListAsync();
    }



    public Task<int> SaveInvoiceSellUnitAsync(InvoiceSellUnit invoiceSellUnit)
    {
        // Save a new note.

        return table2.InsertAsync(invoiceSellUnit);
    }

    public Task<int> UpdateInvoiceSellUnitAsync(InvoiceSellUnit invoiceSellUnit)
    {
        return table2.UpdateAsync(invoiceSellUnit);
    }

    public Task<int> DeleteInvoiceSellUnitAsync(InvoiceSellUnit invoiceSellUnit)
    {
        return table2.DeleteAsync(invoiceSellUnit);
    }
    #endregion
}
