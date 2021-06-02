using Dapper;
using HasanFurkanFidan.UdemyCourse.SHARED.DataAccess.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HasanFurkanFidan.Discount.WebApi.Data
{
    public class DiscountRepository : DpGenericRepository<Models.Discount>, IDiscountRepository
    {
        private readonly IDbConnection _dbConnection;
        public DiscountRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<Models.Discount> GetDiscountWithUserIdAndCodeAsync(string userId, string code)
        {
            var discount = await _dbConnection.QueryFirstOrDefaultAsync<Models.Discount>("select * from Discounts where userId=@userId and code=@code", new
            {
                userId = userId,
                code = code
            }
            );
            return discount;
        }
    }
}
