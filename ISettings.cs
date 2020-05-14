using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    /// <summary>
    /// Интерфейс настроек нужного редактора
    /// </summary>
    interface ISettings
    {
        /// <summary>
        /// Функция выбора шрифта
        /// </summary>
        /// <returns>Название шрифта</returns>
        string SetFont();

        /// <summary>
        /// Функция выбора размера шрифта
        /// </summary>
        /// <returns>Размер шрифта</returns>
        byte SetFontSize();

        /// <summary>
        /// Функция выбора цвета шрифта
        /// </summary>
        /// <returns>Название цвета шрифта</returns>
        string SetFontColour();

        /// <summary>
        /// Функция выбора начертания шрифта
        /// </summary>
        /// <returns>Название начертания</returns>
        string SetFontType();

        /// <summary>
        /// Функция выбора межстрочного интервала
        /// </summary>
        /// <returns>Размер межстрочного интервала</returns>
        byte SetLineSpacing();

        /// <summary>
        /// Функция выбора фонового цвета
        /// </summary>
        /// <returns>Название цвета фона</returns>
        string SetBackgroundColour();

        /// <summary>
        /// Функция выбора цвета служебных слов
        /// </summary>
        /// <returns>Название цвета фона</returns>
        string SetServiceFontColour();

        /// <summary>
        /// Функция выбора начертания служебных слов
        /// </summary>
        /// <returns>Название начертания</returns>
        string SetServiceFontType();

        /// <summary>
        /// Функция выбора размера табуляции
        /// </summary>
        /// <returns>Размер табуляции</returns>
        byte SetTabSize();

        /// <summary>
        /// Функция выбора цвета комментариев
        /// </summary>
        /// <returns>Название цвета комментариев</returns>
        string SetCommentColour();
    }
}
