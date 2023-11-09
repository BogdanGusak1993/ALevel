using HW8.Entities;
using HW8.Models.Enum;
using HW8.Repositories.Abstractions;



namespace HW8.Repositories
{
    public class CandyRepository : ICandyRepository
    {

        private  List<CandysEntity> _candysList = new List<CandysEntity>();
        private  List<SugarCandysEntity> _sugarList = new List<SugarCandysEntity>();
        private  List<ChocolateCandysEntity> _chocolateList = new List<ChocolateCandysEntity>();
        public List<CandysEntity> CraftCandys()
        {
            int max = 100, min = 50;
            List<CandysEntity> list = new List<CandysEntity>();

            for (int count = 0; count < 20; count++)
            {
                CandysEntity candys = new CandysEntity();
                

                candys.Weight = new Random().Next(min, max);
                candys.Price = new Random().Next(min, max);
                candys.Name = $"CandyNumber{count}";

                Array values = Enum.GetValues(typeof(CandyType));
                Random random = new Random();

                CandyType randomSugarCandyType = (CandyType)values.GetValue(random.Next(values.Length));
                candys.Type = randomSugarCandyType;

                list.Add(candys);
            }
            _candysList = list;
            return _candysList;
        }
        public void SortCandysRepo(List<CandysEntity> list)
        {
            list = _candysList;
            
            foreach (CandysEntity candys in list)
            {
               
                if (candys.Type == CandyType.Sugar)
                {
                    var sugarCandy = new SugarCandysEntity(candys);
                   _sugarList.Add(sugarCandy);

                    if (sugarCandy.Stick == SugarCandyType.OnStick)
                    {
                        var lolipop = new LolipopsEntities(sugarCandy);
                        sugarCandy._lolipopList.Add(lolipop);
                    }
                }
                else
                {
                    var chocolateCandy = new ChocolateCandysEntity(candys);
                    _chocolateList.Add(chocolateCandy);

                    if (chocolateCandy.ChocolatType == ChocolateCandyType.Dark)
                    {
                        var darkChocolate = new BlackChocolateEntity(chocolateCandy);
                        chocolateCandy._blackChocolateList.Add(darkChocolate);
                    }
                }
            }
        }

    }
}

