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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appuserDal;

        public AppUserManager(IAppUserDal appuserDal)
        {
            _appuserDal = appuserDal;
        }

        public void TAdd(AppUser t)
        {
            _appuserDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            _appuserDal.Delete(t);
        }

        public AppUser TGetByID(int id)
        {
            return _appuserDal.GetbyID(id);
        }

        public List<AppUser> TGetList()
        {
            return _appuserDal.GetList();
        }

        public void TUpdate(AppUser t)
        {
             _appuserDal.Update(t);
        }
    }
}
