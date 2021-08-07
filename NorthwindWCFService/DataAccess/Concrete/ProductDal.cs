using Core.Concrete.DataAccess;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class ProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
