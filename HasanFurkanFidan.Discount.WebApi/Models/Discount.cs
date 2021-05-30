using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasanFurkanFidan.Discount.WebApi.Models
{
    [Dapper.Contrib.Extensions.Table("Discounts")]

    public class Discount
    {
        [Dapper.Contrib.Extensions.Key]

        public int Id { get; set; }
        public string UserId { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
    }
}
