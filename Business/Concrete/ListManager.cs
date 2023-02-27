using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ListManager : IListService
    {
      
        private IListDal _listDal;

        public ListManager(IListDal listDal)
        {
            _listDal = listDal;
        }


        [SecuredOperation("List.List,Admin")]
        [LogAspect(typeof(FileLogger))]
        [CacheAspect(duration: 10)]
        public IDataResult<List<List>> GetAllLists()
        {
            return new SuccessDataResult<List<List>>(_listDal.GetList().ToList());
        }

        public IResult Add(List list)
        {
            _listDal.Add(list);
            return new SuccessResult(Messages.ListAdded);
        }

        public IResult Delete(List list)
        {
            _listDal.Delete(list);
            return new SuccessResult(Messages.ListDeleted);
        }

        public IResult Update(List list)
        {
            _listDal.Update(list);
            return new SuccessResult(Messages.ListUpdated);
        }
    }
}
