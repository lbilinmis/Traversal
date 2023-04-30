using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class AboutManager : IAboutBusinessService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void Add(About entity)
        {
            try
            {
                _aboutRepository.Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(About entity)
        {
            try
            {
                _aboutRepository.Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<About> GetAll()
        {
            try
            {
                return _aboutRepository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public About GetById(int id)
        {
            try
            {
                return _aboutRepository.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(About entity)
        {
            try
            {
                _aboutRepository.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
