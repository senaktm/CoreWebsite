using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : IGenericService<SocialMedia>
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetList();
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
           _socialMediaDal.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }

        public List<SocialMedia> TGetByFilter(Expression<Func<SocialMedia, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
