namespace E_CommerceProject.Discount.Dtos.CouponDtos
{
    public class CreateCouponDto
    {
        public int Code { get; set; }
        public string Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
