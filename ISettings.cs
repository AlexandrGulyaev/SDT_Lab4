using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_4
{
    interface ISettings
    {
        string SetFont();

        byte SetFontSize();

        string SetFontColour();

        string SetFontType();

        byte SetLineSpacing();

        string SetBackgroundColour();

        string SetServiceFontColour();

        string SetServiceFontType();

        byte SetTabSize();

        string SetCommentColour();
    }
}
