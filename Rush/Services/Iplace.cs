using Rush.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rush.Services
{
   public interface Iplace
    {

        Task<List<PlaceModel>> getplaces();


    }
}
