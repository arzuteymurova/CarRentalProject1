﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetById(int id);


        IDataResult<List<Car>> GetCarsBrandId(int brandId);
        
        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<CarDetailsDto>> GetCarDetails();

    }
}
