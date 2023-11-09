using HW8.Models.Enum;


namespace HW8.Entities
{
    public class LolipopsEntities : SugarCandysEntity
    {
        public LolipopsForms Form;

        public LolipopsEntities(SugarCandysEntity candy) : base(candy)
        {
            Stick = candy.Stick;

            Array values = Enum.GetValues(typeof(LolipopsForms));
            Random random = new Random();

            Form = (LolipopsForms)values.GetValue(random.Next(values.Length));
            Name = $"{candy.Name}_{Stick}";
        }
    }
}
