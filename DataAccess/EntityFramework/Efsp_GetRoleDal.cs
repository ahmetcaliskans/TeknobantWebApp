using Core.DataAccess.EntityFramework;
using Core.Entities.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class Efsp_GetRoleDal : EfDtoRepositoryBase<sp_GetRole, TeknobantWebAppDB>, Isp_GetRoleDal
    {
        public List<sp_GetRole> GetRolesByRoleTypeId(int roleTypeId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.Sp_GetRoles.FromSqlRaw("sp_GetRoles @p0", roleTypeId);
                return result.ToList();
            }
        }

        public sp_GetRole GetRoleByRoleTypeIdAndRoleFormDefinitionId(int roleTypeId, int roleFormDefinitionId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.Sp_GetRoles.FromSqlRaw("sp_GetRoles @p0", roleTypeId);
                return result.ToList().Where(x=>x.RoleFormDefinitionId == roleFormDefinitionId).FirstOrDefault();
            }
        }
    }
}
