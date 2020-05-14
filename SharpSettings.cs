using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    class SharpSettings : ISettings
    {
        public string SetFont()
        {
            return "Calibri";
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
            return "italic";
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
            return "Red";
        }

        public string SetServiceFontType()
        {
            return "regular";
        }

        public byte SetTabSize()
        {
            return 8;
        }

        public string SetCommentColour()
        {
            return "Yellow";
        }
    }
}
