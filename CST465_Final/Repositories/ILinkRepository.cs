using Assignment1.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CST465_Final.Repositories
{
    public interface ILinkRepository
    {
        List<LinkModel> GetLinks();

        void Insert(LinkModel link);

        void Delete(int id);
    }
}
