using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    /// <summary>
    /// Класс HTML-редактора
    /// </summary>
    class HTMLSettingsFactory : ISettingsFactory
    {
        /// <summary>
        /// Получение настроек для HTML-редактора
        /// </summary>
        /// <returns>Настройки HTML-редактора</returns>
        public ISettings MakeSettings()
        {
            return new HTMLSettings();
        }
    }
}
