using E_CommerceProject.Discount.Dtos.CouponDtos;

namespace E_CommerceProject.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<CouponDto>> GetAllCouponAsync();

        Task CreateCouponAsync(CreateCouponDto createcoupon);

        Task UpdateCouponAsync(UpdateCouponDto updatecoupon);

        Task DeleteCouponAsync(int id);

        Task<GetByIdCouponDto> GetByIdCouponAsync(int id);
    }
}
