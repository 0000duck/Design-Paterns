using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Observer_Pattern
{
    // The 'Observer' interface
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
