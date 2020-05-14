using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    class HTMLSettings : ISettings
    {
        public string SetFont()
        {
            return "Times New Roman";
        }

        public byte SetFontSize()
        {
            return 10;
        }

        public string SetFontColour()
        {
            return "DarkCyan";
        }

        public string SetFontType()
        {
            return "regular";
        }

        public byte SetLineSpacing()
        {
            return 6;
        }

        public string SetBackgroundColour()
        {
            return "Black";
        }

        public string SetServiceFontColour()
        {
            return "Cyan";
        }

        public string SetServiceFontType()
        {
            return "bold";
        }

        public byte SetTabSize()
        {
            return 7;
        }

        public string SetCommentColour()
        {
            return "DarkGreen";
        }
    }
}
