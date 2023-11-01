using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogerHW5
{
    internal class Action
    {
        public  Result StartMethod()
        {   
            Loger loger = new Loger();
            loger.ShowLog("Start method: StartMethod");
            Result result = new Result();
            result.ChangeResult(true);
            return result;
        }

        public  Result SkippedLogic()
        {
            Loger loger = new Loger("Warning");
            loger.ShowLog("Skipped logic in method : SkippedLogic");
            Result result = new Result();
            result.ChangeResult(true);
            return result;
        }


        public  Result BrokeLogic()
        {
            Loger loger = new Loger("Error");
            loger.ShowLog("BrokeLogic");
            Result result = new Result();
            result.ChangeResult(false);
            return result;
        }

    }
}
