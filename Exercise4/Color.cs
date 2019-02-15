using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Color
    {
        string _name;
        string[] _info = new string[3];

        //Property method for name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Property method for info array
        public string[] Info
        {
            get { return _info; }
            set { _info = value; }
        }

        //Constructor for the class
        public Color(string name, string[] info)
        {
            _name = name;
            _info = info;
        }
    }
}
