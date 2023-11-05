using HW8.Entities;
using HW8.Models;
using HW8.Models.Enum;
using HW8.Repositories.Abstractions;


namespace HW8.Repositories
{
    public class CandyRepository : ICandyRepository
    {
        private readonly List<CandysEntity> _candysList;
        private readonly List<SugarCandysEntity> _sugarList;
        private readonly List<ChocolateCandysEntity> _chocolateList;
        public List<CandysEntity> CraftCandys()
        {
            int max = 100, min = 50;
            int minType = 0, maxType = 1;

            for (int count = 0; count > 20; count++)
            {
                CandysEntity candys = new CandysEntity();

                candys.Weight = new Random().Next(min, max);
                candys.Price = new Random().Next(min, max);
                candys.Name = $"CandyNumber{count}";

                int chooseType = new Random().Next(minType, maxType);
                if (chooseType == 0)
                {
                    candys.Type = CandyType.Chocolate;

                }
                else
                {
                    candys.Type = CandyType.Sugar;
                }


                _candysList.Add(candys);
            }

            return _candysList;
        }
        public void SortCandysRepo(List<CandysEntity> list)
        {
            list = _candysList;
            foreach (CandysEntity candys in list)
            {
                if (candys.Type == CandyType.Sugar)
                {
                    var sugarCandy = (SugarCandysEntity)candys;
                    _sugarList.Add(sugarCandy);

                    Array values = Enum.GetValues(typeof(SugarCandyType));
                    Random random = new Random();

                    SugarCandyType randomSugarCandyType = (SugarCandyType)values.GetValue(random.Next(values.Length));
                    sugarCandy.OnStick = randomSugarCandyType;

                    if (sugarCandy.OnStick == SugarCandyType.OnStick)
                    {
                        var lolipop = (LolipopsEntities)sugarCandy;
                        sugarCandy.lolipopList.Add(lolipop);
                    }
                }
                else
                {
                    var chocolateCandy = (ChocolateCandysEntity)candys;
                    _chocolateList.Add(chocolateCandy);

                    Array values = Enum.GetValues(typeof(ChocolateCandyType));
                    Random random = new Random();

                    ChocolateCandyType randomChocolateType = (ChocolateCandyType)values.GetValue(random.Next(values.Length));
                    chocolateCandy.ChocolatType = randomChocolateType;

                    if (chocolateCandy.ChocolatType == ChocolateCandyType.Dark)
                    {
                        var darkChocolate = (BlackChocolateEntity)chocolateCandy;
                        chocolateCandy.BlackChocolateList.Add(darkChocolate);
                    }
                }
            }
        }

    }
}

