using System.Collections.Generic;

namespace ModelsP
{
    public class TruckInfoSampleData
    {
        public static IEnumerable<TruckInfo> GetSimpleData()
        {
            return new List<TruckInfo>
            {
                new TruckInfo
                {
                    ID = "1",
                    Name = "Taco Talent",
                    Style = "Mexican"
                },
                new TruckInfo
                {
                    ID = "2",
                    Name = "Cake Shack",
                    Style = "Desserts"
                },
                new TruckInfo
                {
                    ID = "3",
                    Name = "Ice heaven",
                    Style = "Cold Drinks"
                }
            };
        }
    }
}
