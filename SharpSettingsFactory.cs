using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    /// <summary>
    /// Класс C#-редактора
    /// </summary>
    class SharpSettingsFactory : ISettingsFactory
    {
        /// <summary>
        /// Получение настроек для C#-редактора
        /// </summary>
        /// <returns>Настройки C#-редактора</returns>
        public ISettings MakeSettings()
        {
            return new SharpSettings();
        }
    }
}
