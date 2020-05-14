using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    /// <summary>
    /// Интерфейс-фабрика для получения настроек для нужного редактора
    /// </summary>
    interface ISettingsFactory
    {
        /// <summary>
        /// Получение настроек для нужного редактора
        /// </summary>
        /// <returns>Настройки редактора</returns>
        ISettings MakeSettings();
    }
}
