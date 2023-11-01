using LogerHW5;

namespace LogerHW5
{
    internal class Program
    {
        static void Main()
        {
            Run();
            static void Run()
            {
                int min = 1;
                int max = 3;
                Result result = new Result();
                Loger loger = new Loger();
                for (int i = 0; i < 100; i++)
                {
                    int callAction = new Random().Next(min, max);

                    if (callAction == 0)
                    {
                        result = result.StartMethod();
                    }
                    else if (callAction == 1)
                    {
                        result = result.SkippedLogic();
                    }
                    else
                    {
                        result = result.BrokeLogic();
                        loger.ShowLog("Action faild by a resone: random goes 3");
                    }
                }
                loger.GetLogText();
            }
        }
    }
}
