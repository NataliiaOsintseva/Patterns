﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Phone
{
    interface ICamera
    {
        void TakePhoto();
        void Flash();
    }
}