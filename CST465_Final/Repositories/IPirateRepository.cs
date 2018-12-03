using Assignment1.Models;
using CST465_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Repositories
{
    public interface IPirateRepository
    {
        List<PirateModel> GetPirates();

        void Insert(PirateModel pirate);

        void Delete(int id);
    }
}
