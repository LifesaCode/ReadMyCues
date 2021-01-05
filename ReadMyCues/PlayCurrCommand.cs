using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMyCues
{
    class PlayCurrCommand : Command
    {
        public override void execute(LineManager lm)
        {
            play(lm.getCurrLine());
        }
    }
}
