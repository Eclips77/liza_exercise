﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Interfaces
{
    public interface IWeapon
    {
        string Name { get; set; }
        void Attack();
    }
}
