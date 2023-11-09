
namespace HW8.Entities
{
    public class BlackChocolateEntity : ChocolateCandysEntity
    {
        public int cacaoPercentage;

        public BlackChocolateEntity(ChocolateCandysEntity candy) : base(candy)
        {
            ChocolatType = candy.ChocolatType;

            int minCacao = 56, maxCacao = 96;
            cacaoPercentage = new Random().Next(minCacao, maxCacao);
            Name = $"{ candy.Name} with {cacaoPercentage}% cacao";
        }
    }
}
