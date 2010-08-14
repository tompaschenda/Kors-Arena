using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datenmodell
{
    public interface IKeyedValue<TKey>
    {
        TKey GetKey(); 
    }
}
