using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    class Client
    {
        /// <summary>
        /// Вывод настроек для выбранного редактора
        /// </summary>
        /// <param factory="Параметр для получения настроек выбранного редактора"></param>
        public void ConfEditor(ISettingsFactory factory)
        {
            var Settings = factory.MakeSettings();
            Console.WriteLine("Шрифт: " + Settings.SetFont());
            Console.WriteLine("Размер шрифта: " + Settings.SetFontSize());
            Console.WriteLine("Цвет шрифта: " + Settings.SetFontColour());
            Console.WriteLine("Начертание шрифта: " + Settings.SetFontType());
            Console.WriteLine("Межстрочный интервал: " + Settings.SetLineSpacing());
            Console.WriteLine("Цвет фона: " + Settings.SetBackgroundColour());
            Console.WriteLine("Цвет служебных слов: " + Settings.SetServiceFontColour());
            Console.WriteLine("Начертание шрифта для служебных слов: " + Settings.SetServiceFontType());
            Console.WriteLine("Размер табуляции: " + Settings.SetTabSize());
            Console.WriteLine("Цвет шрифта для комментариев: " + Settings.SetCommentColour());
        }

        /// <summary>
        /// Вывод настроек для SQL-редактора
        /// </summary>
        public void SQL()
        {
            Console.WriteLine("Конфигурации для SQL-редактора:");
            ConfEditor(new SQLSettingsFactory());
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод настроек для С#-редактора
        /// </summary>
        public void Sharp()
        {
            Console.WriteLine("Конфигурации для C#-редактора:");
            ConfEditor(new SharpSettingsFactory());
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод настроек для HTML-редактора
        /// </summary>
        public void HTML()
        {
            Console.WriteLine("Конфигурации для HTML-редактора:");
            ConfEditor(new HTMLSettingsFactory());
            Console.WriteLine();
        }
    }
}
