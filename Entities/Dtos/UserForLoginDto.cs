﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int OfficeId { get; set; }
    }
}
