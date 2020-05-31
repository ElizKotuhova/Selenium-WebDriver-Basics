using System;
using System.Collections.Generic;
using System.Text;
using NUnitTestProject3.busness_object;

namespace NUnitTestProject3.busness_object
{
    public class LoginValue 
    {
        public string name { get; set; }
        public string pussword { get; set; }
        public LoginValue(string name, string pussword)
        {
            this.name = name;
            this.pussword = pussword;
        }

    }
}
