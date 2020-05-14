using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    class SQLSettings : ISettings
    {
        public string SetFont()
        {
            return "DialogInput";
        }

        public byte SetFontSize()
        {
            return 12;
        }

        public string SetFontColour()
        {
            return "Gray";
        }

        public string SetFontType()
        {
            return "Regular";
        }

        public byte SetLineSpacing()
        {
            return 6;
        }

        public string SetBackgroundColour()
        {
            return "White";
        }

        public string SetServiceFontColour()
        {
            return "DarkBlue";
        }

        public string SetServiceFontType()
        {
            return "bold";
        }

        public byte SetTabSize()
        {
            return 8;
        }
        
        public string SetCommentColour()
        {
            return "DarkYellow";
        }
    }
}
