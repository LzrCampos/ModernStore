﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernStore.Infrastructure.Transaction
{
    public interface IUow
    {
        void Commit();
        void Rowback();
    }
}
