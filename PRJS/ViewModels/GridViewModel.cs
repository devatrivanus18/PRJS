using Mapster;
using MvvmHelpers;
using Newtonsoft.Json.Linq;
using PRJS.Models;
using PRJS.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PRJS.ViewModels
{
    public class GridViewModel : BaseViewModel
    {
        private ObservableCollection<InvoiceSell> _listInvoiceSell = new();
        public ObservableCollection<InvoiceSell> ListInvoiceSell { get => _listInvoiceSell; set => SetProperty(ref _listInvoiceSell, value); }
        public DatabaseService DatabaseService { get; set; }
        public ICommand SetAddInvoicePage { get; set; }
        public ICommand SelectedInvoice { get; set; }
        IInvoiceSelected DataService;
        public GridViewModel()
        {
            DatabaseService = new DatabaseService();
            DataService = new InvoiceSelectedService();

            ListInvoiceSell = DatabaseService.ListInvoiceSell;
            SetAddInvoicePage = new Command(OnAddInvoicePage);
            SelectedInvoice = new Command(OnSelectedInvoice);

        }

        private async void OnAddInvoicePage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());

        }

        private void OnSelectedInvoice(object value)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(value);
            var dataDipilih = System.Text.Json.JsonSerializer.Deserialize<List<InvoiceSell>>(json.ToString());
            InvoiceSell x = dataDipilih.FirstOrDefault();
            DataService.SetInvoiceSelected(x);
            OnAddInvoicePage();
        }
    }


}
