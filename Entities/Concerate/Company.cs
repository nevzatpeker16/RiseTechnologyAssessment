﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerate
{
    public class Company:IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

    }
}
