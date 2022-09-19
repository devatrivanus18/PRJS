using MvvmHelpers;
using PRJS.Models;
using SQLite;
using System.Collections.ObjectModel;

namespace PRJS.Services;

public class DatabaseService : BaseViewModel
{
    private ObservableCollection<InvoiceSell> _listInvoiceSell = new ObservableCollection<InvoiceSell>();
    public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }

    public SQLiteAsyncConnection database;
    public DatabaseService()
    {
        string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbStore.db3");
        database = new SQLiteAsyncConnection(dbpath);
        if (!File.Exists(dbpath))
        {
            try
            {
                database = new SQLiteAsyncConnection(dbpath);
                database.CreateTableAsync<InvoiceSell>().Wait();
                database.CreateTableAsync<InvoiceSellUnit>().Wait();
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }
        getdataInvoiceSell();
    }
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

        return database.Table<InvoiceSell>().ToListAsync();
    }

    public Task<int> SaveInvoiceSellAsync(InvoiceSell invoiceSell)
    {
        if (invoiceSell.invoiceVATID.ToString() != null)
        {
            // Update an existing note.
            return database.UpdateAsync(invoiceSell);
        }
        else
        {
            // Save a new note.
            return database.InsertAsync(invoiceSell);
        }
    }
}
