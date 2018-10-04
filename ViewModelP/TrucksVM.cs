using ModelsP;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModelP
{
    public class TrucksVM : NotificationBase
    {
        public TrucksVM()
        {
            Trucks = new ObservableCollection<TruckVM>();
            RefreshCommand = new Command(LoadAsync);
        }

        public Command RefreshCommand { get; set; }

        private ObservableCollection<TruckVM> _trucks;

        public ObservableCollection<TruckVM> Trucks { get => _trucks;
            set
            {
                if(_trucks == value)
                {
                    return;
                }
                _trucks = value;
                NotifyPropertyChanged();
            }
        }


        public async Task LoadAsync()
        {
            var trucks = TruckInfoSampleData.GetSimpleData();

            Trucks.Clear();

            await Task.Delay(2000);

            trucks.ToList().ForEach(truck =>
            {
                Trucks.Add(new TruckVM()
                {
                    ID = truck.ID,
                    Name = truck.Name,
                    Style = truck.Style
                });
            });

            //await Repository.GetObject<IDialogService>().ShowDialogAsync("Initialization", "Data loaded", "OK", null);
        }

        public async void Lauch() => await LoadAsync();

        private TruckVM _selectedTruck;
        public TruckVM SelectedTruck
        {
            get => _selectedTruck;
            set
            {
                if (_selectedTruck == value)
                {
                    return;
                }
                _selectedTruck = value;
                NotifyPropertyChanged();
            }
        }
    }
}
