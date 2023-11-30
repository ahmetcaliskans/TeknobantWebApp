using Core.DataAccess.EntityFramework;
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
    public class EfCollectionDefinitionDal :EfEntityRepositoryBase<CollectionDefinition,TeknobantWebAppDB>, ICollectionDefinitionDal
    {
        public CollectionDefinition GetByIdWithDetails(int collectionDefinitionId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.CollectionDefinitions.Include(x => x.CollectionDefinitionType).Where(x => x.Id == collectionDefinitionId);
                return result.FirstOrDefault();
            }
        }

        public List<CollectionDefinition> GetListWithDetails()
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.CollectionDefinitions.Include(x => x.CollectionDefinitionType);
                return result.ToList();
            }
        }
    }
}
