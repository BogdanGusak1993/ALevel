using ALevel9Lesson9.Common;
using ALevel9Lesson9.Exeptions;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Services.Abstractions;
using ALevelModul2.Entities;
using ALevelModul2.Models.CookingAppliance;
using ALevelModul2.Models.Lamps;
using ALevelModul2.Models.None;
using ALevelModul2.Models.OrgAppliance;
using ALevelModul2.Models.OrgAppliance.PCs;
using ALevelModul2.Services.Abstractions;


namespace ALevel9Lesson9
{
    public class App
    {
        private readonly IApplianceService _applianceService;
        private readonly IRoomService _roomService;


        public App(IApplianceService applianceService, IRoomService roomService)
        {
            _applianceService = applianceService;
            _roomService = roomService;

        }

        public void Run()
        {
            var roomId = _roomService.AddRoom(GetMocRoom());
            var room = _roomService.GetRoom(roomId);

            Appliance appliance;
            try
            {
                var id = _applianceService.AddAppliances(GetMocAppliances());
                var arrayLength = id.Length;


                var plagedAppliance = new Appliance[arrayLength];

                foreach (var item in id)
                {
                    appliance = _applianceService.PlugInAppliance(item);

                    Console.WriteLine($"{appliance.GetApplianceType()}");

                    Index lastIndex = ^arrayLength;

                    plagedAppliance[lastIndex] = appliance;

                    arrayLength--;
                }

                room.Appliances = plagedAppliance;
                room.PowerPlug = _roomService.CalculatePowerPlug(plagedAppliance);

                Console.WriteLine(room.PowerPlug);
            }
            catch (ShowNotFoundExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            Console.WriteLine("Sort and show appliance by type. Type 1 if u want to see OrgAplpliance, " +
                "type 2 for Cooking staf, " +
                "type 0 for Special unknown time" +
                "type anythong if u want to see lamps");
            var inpustString = Console.ReadLine();
            int sortType = 100;

            if (int.TryParse(inpustString, out _))
            {
                sortType = int.Parse(inpustString);
            }
            var sortedAppliance = SortAppliance(room.Appliances, sortType);
            foreach (var item in sortedAppliance)
            {
                Console.WriteLine($"Name:{item.Name}, Descriprion: {item.Description}");
            }

            Console.WriteLine("Fined appliance by part of the name and discription");
            var foundedAppliance = _applianceService.GetApplianceText(Console.ReadLine());

            Console.WriteLine($"Roster of the finded appliances:");
            foreach (var item in foundedAppliance)
            {
                Console.WriteLine($"Name:{item.Name}, Descriprion: {item.Description}");
            }

        }

        private Appliance[] SortAppliance(Appliance[] appliances, int enumNumer)
        {
            var applianceList = new List<Appliance>();
            Array values = Enum.GetValues(typeof(ApplianceType));

            foreach (var appliance in appliances)
            {
                if (appliance.GetApplianceType() == (ApplianceType)values.GetValue(enumNumer) & enumNumer == 0)
                {
                    var item = new NoneTypedAppliance
                    {
                        Id = appliance.Id,
                        Name = $"LapTop_{appliance.Name}",
                        Power = appliance.Power,
                        Voltage = appliance.Voltage,
                        Description = appliance.Description,
                        SpecialDesription = "I dont know what this appliance doing, but whatever",
                    };
                    applianceList.Add(item);
                }
                else if (appliance.GetApplianceType() == (ApplianceType)values.GetValue(enumNumer) & enumNumer == 1)
                {
                    var item = new LapTop
                    {
                        Id = appliance.Id,
                        Name = $"LapTop_{appliance.Name}",
                        Power = appliance.Power,
                        Voltage = appliance.Voltage,
                        Description = appliance.Description,
                        GraphicCardModel = "GeforceGTX 1080",
                        ProcesorModel = "IntelCore i7",
                        PCsType = PCsType.LapTop,
                        Weight = 2,
                    };
                    applianceList.Add(item);
                }
                else if (appliance.GetApplianceType() == (ApplianceType)values.GetValue(enumNumer) & enumNumer == 2)
                {
                    var item = new DishWasher
                    {
                        Id = appliance.Id,
                        Name = $"LapTop_{appliance.Name}",
                        Power = appliance.Power,
                        Voltage = appliance.Voltage,
                        Description = appliance.Description,
                        NumberOfDish = 100,
                    };
                    applianceList.Add(item);
                }
                else if (enumNumer != 1 & enumNumer != 2 & enumNumer != 0)
                {
                    var item = new Torsher
                    {
                        Id = appliance.Id,
                        Name = $"Torsher_{appliance.Name}",
                        Power = appliance.Power,
                        Voltage = appliance.Voltage,
                        Description = appliance.Description,
                        Height = 2,
                    };
                    applianceList.Add(item);
                }
            }
            return applianceList.ToArray();
        }

        private Appliance[] GetMocAppliances()
        {
            var mocList = new List<Appliance>();

            for (int i = 0; i < 20; i++)
            {
                if (i == 0)
                {
                    mocList.Add(new NoneTypedAppliance
                    {
                        Name = $"{ApplianceType.None}_Typed_Appliance{i + 1}",
                        Power = new Random().Next(200, 500),
                        Voltage = new Random().Next(200, 230),
                        Description = $"Some description{i + 1} None"
                    });
                    continue;
                }
                else if (i % 8 == 0)
                {
                    mocList.Add(new ApplianceForCooking
                    {
                        Name = $"{ApplianceType.ApplianceForCooking}_{i + 1}",
                        Power = new Random().Next(200, 500),
                        Voltage = new Random().Next(200, 230),
                        Description = $"Some description{i + 1} ApplianceForCooking"
                    });
                }
                else if (i % 5 == 0)
                {
                    mocList.Add(new OrgAppliance
                    {
                        Name = $"{ApplianceType.OrgAppliance}_{i + 1}",
                        Power = new Random().Next(200, 500),
                        Voltage = new Random().Next(200, 230),
                        Description = $"Some description{i + 1} OrgAppliance"
                    });
                }
                else
                {
                    mocList.Add(new Lamps
                    {
                        Name = $"{ApplianceType.Lamps}_Appliance{i + 1}",
                        Power = new Random().Next(200, 500),
                        Voltage = new Random().Next(200, 230),
                        Description = $"Some description{i + 1} Lamps"
                    });
                }

            }
            return mocList.ToArray();
        }

        private Room GetMocRoom()
        {
            var room = new Room
            {
                Number = 1,
                PowerPlug = 0,
            };
            return room;
        }
    }
}
