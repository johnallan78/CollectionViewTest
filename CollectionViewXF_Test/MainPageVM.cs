using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CollectionViewXF_Test
{
    public class MainPageVM
    {
        public IList<Details> TestData { get; set; }

        public MainPageVM()
        {
            PopulateList();
        }

        private void PopulateList()
        {
            TestData = new List<Details>
            {
                new Details { Name = "A", Duration = 10000000 },
                new Details { Name = "B", Duration = 10000000 },
                new Details { Name = "B", Duration = 10000000 },
                new Details { Name = "C", Duration = 10000000},
                new Details { Name = "D", Duration = 10000000 },
                new Details { Name = "E", Duration = 10000000 },
                new Details { Name = "F", Duration = 10000000 },
                new Details { Name = "G", Duration = 10000000 },
                new Details { Name = "H", Duration = 10000000 }
            };
        }

    }

    public class Details
    {
        public string Name { get; set; }
        public decimal Duration { get; set; }
    }
}

