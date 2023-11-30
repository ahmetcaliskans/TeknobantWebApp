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
    public class EfCollectionDetailDal : EfEntityRepositoryBase<CollectionDetail, TeknobantWebAppDB>, ICollectionDetailDal
    {
        public CollectionDetail GetByIdWithDetails(int collectionDetailId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.CollectionDetails.Include(x => x.PaymentType).Include(x => x.CollectionDefinition).Include(x=>x.Collection).Include(x=>x.Collection.DriverInformation).Include(x=>x.Collection.Office).Where(x => x.Id == collectionDetailId);
                return result.FirstOrDefault();
            }
        }

        public List<CollectionDetail> GetListWithDetailsByCollectionId(int collectionId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.CollectionDetails.Include(x => x.PaymentType).Include(x => x.CollectionDefinition).Where(x => x.CollectionId== collectionId);
                return result.ToList();
            }
        }

        public List<CollectionDetail> GetListWithDetailsByDriverInformationId(int driverInformationId)
        {
            using (TeknobantWebAppDB context = new TeknobantWebAppDB())
            {
                var result = context.CollectionDetails.Include(x => x.PaymentType).Include(x => x.CollectionDefinition).Include(x=> x.Collection).Include(x=> x.Collection.DriverInformation).Where(x => x.Collection.DriverInformationId == driverInformationId);
                return result.ToList();
            }
        }
    }
}
