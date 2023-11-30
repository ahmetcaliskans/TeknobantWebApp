﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CollectionDetail :IEntity
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public Collection Collection{ get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
        public int CollectionDefinitionId { get; set; }
        public CollectionDefinition CollectionDefinition { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public bool PaidBySelf { get; set; }
        public decimal Hour { get; set; }
        public int AddedUserId { get; set; }
        public string AddedUserName { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string UpdatedUserName { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
