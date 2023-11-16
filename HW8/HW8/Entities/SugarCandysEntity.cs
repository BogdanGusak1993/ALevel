using HW8.Models;
using HW8.Models.Enum;


namespace HW8.Entities
{
    public class SugarCandysEntity : CandysEntity
    {
        public List<LolipopsEntities> LolipopList = new List<LolipopsEntities>();
        public SugarCandyType Stick;
        
        public SugarCandysEntity(CandysEntity candy) 
        {
            Name = $"{CandyType.Sugar}_{candy.Name}"; ;
            Weight = candy.Weight;
            Price = candy.Price;
            Type = candy.Type;

            Array values = Enum.GetValues(typeof(SugarCandyType));
            Random random = new Random();

            SugarCandyType randomSugarCandyType = (SugarCandyType)values.GetValue(random.Next(values.Length));
            Stick = randomSugarCandyType;

        }
    }
}
