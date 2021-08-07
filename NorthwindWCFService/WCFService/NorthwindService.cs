using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities.Concrete;
using Business.Abstract;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NorthwindService" in both code and config file together.
    public class NorthwindService : INorthwindService
    {
        private IProductService _productService;

        public List<Product> GetList()
        {
            return _productService.GetAll();
        }
    }
}
