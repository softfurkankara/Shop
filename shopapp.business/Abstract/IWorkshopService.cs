using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IWorkshopService:IValidator<Workshop>
    {
        bool Create(Workshop entity);
        void Update(Workshop entity);
        void Delete(Workshop entity);
        bool Update(Workshop entity, int[] categoryIds);
        List<Workshop> GetAll();
        
    }
}