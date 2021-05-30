using HasanFurkanFidan.UdemyCourse.SHARED.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HasanFurkanFidan.Discount.WebApi.Models;
namespace HasanFurkanFidan.Discount.WebApi.Services
{
    public interface IDiscountService
    {
        Task<Response<HasanFurkanFidan.Discount.WebApi.Models.Discount>> GetDiscount (string userId, string code);
    }
}
