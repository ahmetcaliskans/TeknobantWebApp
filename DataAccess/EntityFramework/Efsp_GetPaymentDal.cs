using Core.DataAccess.EntityFramework;
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
    public class Efsp_GetPaymentDal : EfDtoRepositoryBase<sp_GetPayment, TeknobantWebAppDB>, Isp_GetPaymentDal
    {
        public List<sp_GetPayment> GetByDriverInformationId(int driverInformationId, int collectionDefinitionTypeId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.Sp_GetPayments.FromSqlRaw("sp_GetPayments @p0,@p1",  driverInformationId, collectionDefinitionTypeId);
                return result.ToList();
            }
        }
    }
}
