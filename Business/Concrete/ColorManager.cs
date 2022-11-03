using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<Color> Get(int Id)
        {
            return new DataSuccessResult<Color>(_colorDal.Get(p => p.Id == Id), Message.SuccessGet);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new DataSuccessResult<List<Color>>(_colorDal.GetAll(), Message.SuccessGet);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Message.SuccessUpdated);
        }
    }
}
