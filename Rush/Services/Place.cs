using Rush.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rush.Services
{
    public class Place : Iplace
    {
        List<PlaceModel> myData;

        public Place()
        {
            myData = new List<PlaceModel>();

            myData.Add(new PlaceModel { Placename = "Highland Home", Description = "Need bed down at 2Am ", id = 1, latitude = 113353.34, longitude = 1253.34444 });
            myData.Add(new PlaceModel { Placename = "Highland Park", Description = "Need bed down at 2Am ", id = 2, latitude = 1133355.34, longitude = 123.34444 });
            myData.Add(new PlaceModel { Placename = "Highland Ent", Description = "Need bed down at 2Am ", id = 3, latitude = 113332.344, longitude = 12388.34444 });
        }

        public async Task<List<PlaceModel>> getplaces()
        {
            return await Task.FromResult(myData);
        }
    }
}
