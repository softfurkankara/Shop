using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreWorkshopRepository :
        EfCoreGenericRepository<EfCoreWorkshopRepository, ShopContext>, IWorkshopRepository
    {
        public void Create(Workshop entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Workshop entity)
        {
            throw new NotImplementedException();
        }

        public List<Workshop> GetHomPageProducts()
        {
            using (var context = new ShopContext())
            {
                return context.Workshops
                        .Where(i=>i.wIsApproved&&i.wIsHome).ToList();
            }
        }

        public void Update(Workshop entity)
        {
            throw new NotImplementedException();
        }

        List<Workshop> IRepository<Workshop>.GetAll()
        {
            throw new NotImplementedException();
        }

        Workshop IRepository<Workshop>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}