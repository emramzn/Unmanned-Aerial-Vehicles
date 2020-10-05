using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapAndRotation
{
    public class elevationOfPoints
    {

        public List<Results> results { get; set; }

        public string status { get; set; }
        public class Results
        {
            public string elevation { get; set; }
            public string resolution { get; set; }

        }

    }
}
