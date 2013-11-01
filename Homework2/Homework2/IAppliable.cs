using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    /// <summary>
    /// This interface defines something that can apply its settings
    /// </summary>
    interface IAppliable
    {
        event EventHandler Apply;
    }
}
