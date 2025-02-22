﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);

        IResult Update(Rental rental);

        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IDataResult<List<RentalDetailsDto>> GetRentalDetails();
    }
}
