using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogerHW5
{
    internal class Result : Action
    {
        bool _status;
        public string _error;
        public void ChangeResult(bool status)
        {
            if (status)
            {
                _status = status;
            }
            else
            {
                _status = status;
                _error = "I broke a logic";
            }
        }
    }
}
