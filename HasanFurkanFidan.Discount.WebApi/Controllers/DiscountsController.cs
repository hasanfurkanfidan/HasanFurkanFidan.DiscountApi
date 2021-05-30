using HasanFurkanFidan.Discount.WebApi.Services;
using HasanFurkanFidan.UdemyCourse.SHARED.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasanFurkanFidan.Discount.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : CustomBaseController
    {
        private readonly IDiscountService _disCountService;
        public DiscountsController(IDiscountService discountService)
        {
            _disCountService = discountService;
        }
        public async Task<IActionResult>GetDiscount(string userId,string code)
        {
            var disCount = await _disCountService.GetDiscount(userId, code);
            return CreateActionResultInstance(disCount);
        }
    }
}
