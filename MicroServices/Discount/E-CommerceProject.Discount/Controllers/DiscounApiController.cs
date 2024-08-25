using E_CommerceProject.Discount.Dtos.CouponDtos;
using E_CommerceProject.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceProject.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscounApiController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscounApiController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet("listDiscount")]
        public async Task<IActionResult> ListDiscount()
        {
            var value = await _discountService.GetAllCouponAsync();
            return Ok(value);
        }
        [HttpPost("createDiscount")]
        public async Task<IActionResult> CreateDiscount(CreateCouponDto createCouponDto)
        {
            await _discountService.CreateCouponAsync(createCouponDto);
            return Ok("Kupon Başarlıyla Eklendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdDiscount(int id)
        {
           var value = await _discountService.GetByIdCouponAsync(id);
            return Ok(value);
        }
        [HttpDelete("deleteCoupon")]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteCouponAsync(id);
            return Ok("Kupon başarıyla silindi");
        }

        [HttpPut("updateCoupon")]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateCouponDto updateCouponDto)
        {
            await _discountService.UpdateCouponAsync(updateCouponDto);
            return Ok("İndirim kuponu başarıyla güncellendi");
        }

    }
}
