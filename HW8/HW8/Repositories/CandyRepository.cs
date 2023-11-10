using HW8.Entities;
using HW8.Models.Enum;
using HW8.Repositories.Abstractions;



namespace HW8.Repositories
{
    public class CandyRepository : ICandyRepository
    {

        public  List<CandysEntity> CandysList = new List<CandysEntity>();
        public List<SugarCandysEntity> SugarList = new List<SugarCandysEntity>();
        public List<ChocolateCandysEntity> ChocolateList = new List<ChocolateCandysEntity>();
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
            CandysList = list;
            return CandysList;
        }
        public CandyRepository SortCandysRepo(List<CandysEntity> list)
        {
            list = CandysList;
            var candysRepo = new CandyRepository();
            
            foreach (CandysEntity candys in list)
            {
               
                if (candys.Type == CandyType.Sugar)
                {
                    var sugarCandy = new SugarCandysEntity(candys);
                    candysRepo.SugarList.Add(sugarCandy);

                    if (sugarCandy.Stick == SugarCandyType.OnStick)
                    {
                        var lolipop = new LolipopsEntities(sugarCandy);
                        sugarCandy.LolipopList.Add(lolipop);
                    }
                }
                else
                {
                    var chocolateCandy = new ChocolateCandysEntity(candys);
                    candysRepo.ChocolateList.Add(chocolateCandy);

                    if (chocolateCandy.ChocolatType == ChocolateCandyType.Dark)
                    {
                        var darkChocolate = new BlackChocolateEntity(chocolateCandy);
                        chocolateCandy.BlackChocolateList.Add(darkChocolate);
                    }
                }
            }
            return candysRepo;
        }

    }
}

