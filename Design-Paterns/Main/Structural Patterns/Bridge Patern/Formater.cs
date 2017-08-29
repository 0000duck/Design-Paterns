using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Bridge_Patern
{
    public interface IFormater
    {
        string SetFormat(string text);
    }

    public class StandartFormater : IFormater
    {
        public string SetFormat(string text)
        {
            return text;
        }
    }

    public class StarsFormater : IFormater
    {
        public string SetFormat(string text)
        {
            return "*" + text + "*";
        }
    }
}
