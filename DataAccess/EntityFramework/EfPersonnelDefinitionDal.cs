﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfPersonnelDefinitionDal : EfEntityRepositoryBase<PersonnelDefinition, TeknobantWebAppDB>, IPersonnelDefinitionDal
    {
        public PersonnelDefinition GetByIdWithDetails(int personnelId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.PersonnelDefinitions.Include(x => x.Office).Where(x => x.Id == personnelId);
                if (result.Count() > 0)
                {
                    return result.FirstOrDefault();
                }
                return result.FirstOrDefault();
            }
        }

        public List<PersonnelDefinition> GetListWithDetailsByOfficeId(int officeId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.PersonnelDefinitions.Include(x => x.Office).Where(x => x.Office.Id == officeId);
                return result.ToList();
            }
        }

    }
}
