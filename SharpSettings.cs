﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    /// <summary>
    /// Класс настроек С#-редактора
    /// </summary>
    class SharpSettings : ISettings
    {
        /// <summary>
        /// Функция выбора шрифта
        /// </summary>
        /// <returns>Название шрифта</returns>
        public string SetFont()
        {
            return "Calibri";
        }

        /// <summary>
        /// Функция выбора размера шрифта
        /// </summary>
        /// <returns>Размер шрифта</returns>
        public byte SetFontSize()
        {
            return 12;
        }

        /// <summary>
        /// Функция выбора цвета шрифта
        /// </summary>
        /// <returns>Название цвета шрифта</returns>
        public string SetFontColour()
        {
            return "Gray";
        }

        /// <summary>
        /// Функция выбора начертания шрифта
        /// </summary>
        /// <returns>Название начертания</returns>
        public string SetFontType()
        {
            return "italic";
        }

        /// <summary>
        /// Функция выбора межстрочного интервала
        /// </summary>
        /// <returns>Размер межстрочного интервала</returns>
        public byte SetLineSpacing()
        {
            return 6;
        }

        /// <summary>
        /// Функция выбора фонового цвета
        /// </summary>
        /// <returns>Название цвета фона</returns>
        public string SetBackgroundColour()
        {
            return "White";
        }

        /// <summary>
        /// Функция выбора цвета служебных слов
        /// </summary>
        /// <returns>Название цвета фона</returns>
        public string SetServiceFontColour()
        {
            return "Red";
        }

        /// <summary>
        /// Функция выбора начертания служебных слов
        /// </summary>
        /// <returns>Название начертания</returns>
        public string SetServiceFontType()
        {
            return "regular";
        }

        /// <summary>
        /// Функция выбора размера табуляции
        /// </summary>
        /// <returns>Размер табуляции</returns>
        public byte SetTabSize()
        {
            return 8;
        }

        /// <summary>
        /// Функция выбора цвета комментариев
        /// </summary>
        /// <returns>Название цвета комментариев</returns>
        public string SetCommentColour()
        {
            return "Yellow";
        }
    }
}
