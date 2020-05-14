using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    /// <summary>
    /// Класс SQL-редактора
    /// </summary>
    class SQLSettingsFactory : ISettingsFactory
    {
        /// <summary>
        /// Получение настроек для SQL-редактора
        /// </summary>
        /// <returns>Настройки SQL-редактора</returns>
        public ISettings MakeSettings()
        {
            return new SQLSettings();
        }
    }
}
