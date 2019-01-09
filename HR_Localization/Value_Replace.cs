using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HR_Localization
{
    class Value_Replace
    {
        public string target;
        static readonly int File_Name = 0;
        static readonly int Null = 1;

        public Value_Replace(string target)
        {
            this.target = target;
        }

        public int GetTargetType()
        {
            if(Regex.Match(target, "{file}").ToString()!= "")
            {
                return File_Name;
            }
            return Null;
        }

        public string Handle(string replace)
        {
            string goal;
            if(GetTargetType() == File_Name)
            {
                goal = target.Replace("/{file}/g", replace);
                return goal;
            }

            return target;
        }
    }
}
