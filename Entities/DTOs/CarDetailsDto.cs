using Entities.Abstract;

namespace Entities.DTOs
{
    public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Brand { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}