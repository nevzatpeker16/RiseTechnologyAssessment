﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerate
{
    public class InformationType:IEntity
    {
        public InformationType()
        {
            ID = new Guid();
        }

        public Guid ID { get; set; }
        public string Type { get; set; }

    }
}
