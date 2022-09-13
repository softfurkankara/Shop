using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;

namespace shopapp.business.Concrete
{
    public class WorkshopManager : IWorkshopService
    {
        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private IWorkshopRepository _workshopRepository;

        public WorkshopManager(IWorkshopRepository workshopRepository)
        {
            _workshopRepository = workshopRepository;
        }
        public bool Create(Workshop entity)
        {
            if(Validation(entity))
            {
                _workshopRepository.Create(entity);
                return true;
            }
            return false;
        }

        public void Delete(Workshop entity)
        {
            _workshopRepository.Delete(entity);
        }

        public void Update(Workshop entity)
        {
            _workshopRepository.Update(entity);
        }

        public bool Update(Workshop entity, int[] categoryIds)
        {
            throw new NotImplementedException();
        }

        public bool Validation(Workshop entity)
        {
            throw new NotImplementedException();
        }

        public List<Workshop> GetAll()
        {
            return _workshopRepository.GetAll();
        }
    }
}