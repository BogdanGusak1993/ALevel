using HW8.Models.Enum;


namespace HW8.Entities
{
    public class ChocolateCandysEntity : CandysEntity
    {
        internal List<BlackChocolateEntity> _blackChocolateList = new List<BlackChocolateEntity>();
        public ChocolateCandyType ChocolatType;
        public ChocolateCandysEntity(CandysEntity candy)
        {
            Weight = candy.Weight;
            Price = candy.Price;
            Type = candy.Type;

            Array values = Enum.GetValues(typeof(ChocolateCandyType));
            Random random = new Random();

            ChocolateCandyType randomChocolateCandyType = (ChocolateCandyType)values.GetValue(random.Next(values.Length));
            ChocolatType = randomChocolateCandyType;

            Name = $"{randomChocolateCandyType}_{CandyType.Chocolate}_{candy.Name}";
        }
    }
}
