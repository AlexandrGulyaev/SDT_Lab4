using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    class SQLSettingsFactory : ISettingsFactory
    {
        public ISettings MakeSettings()
        {
            return new SQLSettings();
        }
    }
}
