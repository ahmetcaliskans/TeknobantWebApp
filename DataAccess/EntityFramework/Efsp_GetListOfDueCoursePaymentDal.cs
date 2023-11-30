﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class Efsp_GetListOfDueCoursePaymentDal : EfDtoRepositoryBase<sp_GetListOfDueCoursePayment, TeknobantWebAppDB>, Isp_GetListOfDueCoursePaymentDal
    {
        public List<sp_GetListOfDueCoursePayment> GetList(int dueType, int officeId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.Sp_GetListOfDueCoursePayments.FromSqlRaw("sp_GetListOfDueCoursePayments @p0,@p1",dueType,officeId);
                return result.ToList();
            }
        }
    }
}
