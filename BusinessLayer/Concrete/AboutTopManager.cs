using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutTopManager : IAboutTopService
    {
        IAboutTopDal _aboutTopDal;
        public AboutTopManager(IAboutTopDal aboutTopDal)
        {
            _aboutTopDal = aboutTopDal;
        }

        public void TAdd(AboutTop t)
        {
            _aboutTopDal.Insert(t);
        }

        public void TDelete(AboutTop t)
        {
            _aboutTopDal.Delete(t);
        }

        public AboutTop TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AboutTop> TGetList()
        {
            return _aboutTopDal.GetList();
        }

        public void TUpdate(AboutTop t)
        {
            _aboutTopDal.Update(t);
        }
    }
}
