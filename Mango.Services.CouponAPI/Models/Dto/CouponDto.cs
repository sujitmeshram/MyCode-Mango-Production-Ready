namespace Mango.Services.CouponAPI.Models.Dto
{

    /* using Dto because I dont want to pass all of my Coupon models.
     
    we use Dto to send only those details which are required for frotnend side
     */
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
