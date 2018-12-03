using CST465_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CST465_Final.Repositories
{
    public interface IPirateAnimalRepository
    {
        List<PirateAnimalModel> GetPirateAnimals();

        void Insert(PirateAnimalModel pirateAnimal);

        void Delete(PirateAnimalModel pirateAnimal);
    }
}
