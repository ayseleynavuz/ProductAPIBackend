using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IListService
    {
        IDataResult<List<List>> GetAllLists();
        IResult Add(List list);
        IResult Delete(List list);
        IResult Update(List list);
    }


}
