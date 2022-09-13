using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IWorkshopRepository:IRepository<Workshop>
    {
        List<Workshop> GetHomPageProducts();

        
    }
}