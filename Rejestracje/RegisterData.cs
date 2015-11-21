using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracje
{
    public class RegisterData
    {
        public string RegisterNumber { get; set; }
        public string State { get; set; }
        public string Province { get; set; }                

        public RegisterData(string registerNumber, string state,string province)
        {
            RegisterNumber = registerNumber ;
            State = state;
            Province = province;

        }        

    }
}
