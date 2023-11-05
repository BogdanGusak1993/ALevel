using HW8.Models.Enum;

namespace HW8.Models
{
    public class Present
    {
        public PrizeSize _size;
        public int Weight;
        public int Price;
        public List <Candy> _composition;

        public Present(List<Candy> composition)
        {
            _composition = composition;
            _size = Models.Enum.PrizeSize.Small;
        } 
        public void CountStats()
        {
            foreach (var item in _composition)
            {
                Weight = Weight + item.Weight;
                Price  = Price + item.Price;
            }
            if (Weight > 1000) 
            {
                _size = Models.Enum.PrizeSize.Big;
            }
        }
    }
}
