using System;
using System.Collections.Generic;
using System.Text;

namespace Rush.Models
{
    public class PlaceModel
    {

        public int id { get; set; }
        public string Placename { get; set; }
        public string Description { get; set; }

        public double longitude { get; set; }

        public double latitude { get; set; }

    }
}
