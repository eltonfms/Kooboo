﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Model
{
    public interface ITable
    {
        string Actions { get; set; }

        string RowActions { get; set; }
    }
}
