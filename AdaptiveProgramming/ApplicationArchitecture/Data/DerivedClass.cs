﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA.ApplicationArchitecture.Data.CircularReference;

namespace TPA.ApplicationArchitecture.Data
{
    public class DerivedClass : AbstractClass
    {
        public int FieldInDerivedClass;

        public override void AbstractMethod() { }

    }
}
