﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Session : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Sequence { get; set; }
        public bool Active { get; set; }
        public virtual List<DriverInformation> DriverInformations { get; set; }
    }
}
