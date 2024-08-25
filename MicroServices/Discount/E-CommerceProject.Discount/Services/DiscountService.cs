using Dapper;
using E_CommerceProject.Discount.Dtos.CouponDtos;
using E_CommerceProject.Discount.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceProject.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _dapperContext;

        public DiscountService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task CreateCouponAsync(CreateCouponDto createcoupon)
        {
            string query = "insert into Coupons (Code,Rate,IsActive,ValidDate) values (@code,@rate,@isActive,@validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createcoupon.Code);
            parameters.Add("@rate", createcoupon.Rate);
            parameters.Add("@isActive", createcoupon.IsActive);
            parameters.Add("@validDate", createcoupon.ValidDate);
            using var connection = _dapperContext.CreateConnection();
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "Delete From Coupons where Id=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("couponId", id);
            using var connection = _dapperContext.CreateConnection();
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<CouponDto>> GetAllCouponAsync()
        {
            string query = "Select * From Coupons";
            using var connection = _dapperContext.CreateConnection();
            {
                var values = await connection.QueryAsync<CouponDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCouponDto> GetByIdCouponAsync(int id)
        {
            string query = "Select * From Coupons Where Id=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using var connection = _dapperContext.CreateConnection();
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdCouponDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateCouponAsync(UpdateCouponDto updatecoupon)
        {
            string query = "Update Coupons Set Code=@code,Rate=@rate,IsActive=@isActive,ValidDate=@validDate where Id=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updatecoupon.Code);
            parameters.Add("@rate", updatecoupon.Rate);
            parameters.Add("@isActive", updatecoupon.IsActive);
            parameters.Add("@validDate", updatecoupon.ValidDate);
            parameters.Add("@couponId", updatecoupon.Id);
            using var connection = _dapperContext.CreateConnection();
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
