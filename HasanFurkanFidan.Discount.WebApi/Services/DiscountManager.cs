using HasanFurkanFidan.UdemyCourse.SHARED.DataAccess;
using HasanFurkanFidan.UdemyCourse.SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasanFurkanFidan.Discount.WebApi.Services
{
    public class DiscountManager : IDiscountService
    {
        private readonly IGenericRepository<Models.Discount> _genericRepository;
        public DiscountManager(IGenericRepository<Models.Discount> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Response<Models.Discount>> GetDiscount(string userId, string code)
        {
            var discount = await _genericRepository.GetAsync(p => p.Code == code && p.UserId == userId);
            if (discount!=null)
            {
                return Response<Models.Discount>.Success(discount, 200);
            }
            return Response<Models.Discount>.Fail("İndirim kodu bulunamadı", 400);
        }
    }
}
