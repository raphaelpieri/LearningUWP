using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LearningUWP2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var info = new TruckInfo
            {
                Id = "1",
                Name = "Taco Talent",
                Style = "It's Nice"
            };

            var infos = new List<TruckInfo>
            {
                new TruckInfo
                {
                    Id = "1",
                    Name = "Taco Talent",
                    Style = "Mexican"
                },
                new TruckInfo
                {
                    Id = "2",
                    Name = "Cake Shack",
                    Style = "Desserts"
                },
                new TruckInfo
                {
                    Id = "3",
                    Name = "Ice heaven",
                    Style = "Cold Drinks"
                }
            };

            var data = new TruckData()
            {
                Trucks = new ObservableCollection<TruckInfo>(infos)
            };

            Data = data;
        }

        public TruckData Data { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TruckData).Trucks.Add(new TruckInfo()
            {
                Id = "4",
                Name = "Motor Monster",
                Style = "BRUM"
            });
        }
    }

    public class StyleToBrushConverter: IValueConverter
    {
        public StyleToBrushConverter()
        {

        }

        private SolidColorBrush _default = new SolidColorBrush(Windows.UI.Colors.White);
        private SolidColorBrush _mexican = new SolidColorBrush(Windows.UI.Colors.LightPink);
        private SolidColorBrush _desserts = new SolidColorBrush(Windows.UI.Colors.Chocolate);
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch(value as string)
            {
                case null:
                default:
                    return _default;
                case "Mexican":
                    return _mexican;
                case "Desserts":
                    return _desserts;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class TruckData : NotificationBase
    {
        public ObservableCollection<TruckInfo> Trucks { get; set; }

        private TruckInfo _selectedTruck;

        public TruckInfo SelectedTruck
        {
            get { return _selectedTruck; }
            set
            {
                if(_selectedTruck == value)
                {
                    return;
                }
                _selectedTruck = value;
                NotififyPropertyChanged();
            }
        }
        public object SelectedTruckObject
        {
            get { return _selectedTruck; }
            set
            {
                if (value == _selectedTruck)
                    return;

                _selectedTruck = (TruckInfo)value;
                NotififyPropertyChanged("SelectedTruck");
            }
        }
    }


    public class TruckInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
    }
}
