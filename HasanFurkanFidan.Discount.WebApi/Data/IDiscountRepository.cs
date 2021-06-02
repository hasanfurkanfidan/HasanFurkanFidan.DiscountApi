using HasanFurkanFidan.UdemyCourse.SHARED.BusinessServices;
using HasanFurkanFidan.UdemyCourse.SHARED.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasanFurkanFidan.Discount.WebApi.Data
{
    public interface IDiscountRepository:IGenericRepository<Models.Discount>
    {
        Task<Models.Discount> GetDiscountWithUserIdAndCodeAsync(string userId, string code);
    }
}
