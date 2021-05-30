using HasanFurkanFidan.UdemyCourse.SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasanFurkanFidan.Discount.WebApi.Services
{
    public class DiscountManager : IDiscountService
    {
        public DiscountManager()
        {

        }
        public Task<Response<Models.Discount>> GetDiscount(string userId, string code)
        {
            throw new NotImplementedException();
        }
    }
}
