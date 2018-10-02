using System;
using System.Collections.Generic;
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
                Trucks = infos
            };

            DataContext = data;
        }
    }

    public class TruckData
    {
        public IList<TruckInfo> Trucks { get; set; }

        public TruckInfo SelectedTruck { get; set; }
    }


    public class TruckInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
    }
}
