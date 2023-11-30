﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICollectionDefinitionDal : IEntityRepository<CollectionDefinition>
    {
        List<CollectionDefinition> GetListWithDetails();
        CollectionDefinition GetByIdWithDetails(int collectionDefinitonId);
    }
}
