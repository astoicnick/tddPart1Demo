﻿using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Interfaces
{
    public interface IProductService
    {
        CreateResult CreateProduct(ProductCreateModel productCreateModel);
    }
}
