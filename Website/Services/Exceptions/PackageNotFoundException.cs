﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuGetGallery
{
    [Serializable]
    public class PackageNotFoundException :   Exception
    {
        public PackageNotFoundException()
        {

        }
    }
}