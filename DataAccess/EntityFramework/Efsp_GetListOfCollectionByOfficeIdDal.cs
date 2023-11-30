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
    public class Efsp_GetListOfCollectionByOfficeIdDal : EfDtoRepositoryBase<sp_GetListOfCollectionByOfficeId, TeknobantWebAppDB>, Isp_GetListOfCollectionByOfficeIdDal
    {
        public List<sp_GetListOfCollectionByOfficeId> GetList(int officeId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.Sp_GetListOfCollectionByOfficeIds.FromSqlRaw("sp_GetListOfCollectionByOfficeId @p0", officeId);
                return result.ToList();
            }
        }
    }
}


