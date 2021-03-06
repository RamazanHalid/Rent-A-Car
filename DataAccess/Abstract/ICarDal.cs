using System.Collections.Generic;
using Core.DataAccess;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
         List<CarDetailsDto> GetCarDetailsDtos();

    }
}