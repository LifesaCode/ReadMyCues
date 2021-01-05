using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ReadMyCues
{
    class ButtonInvoker
    {
        Command cmd;

        public void setCommand(Command cmd)
        {
            this.cmd = cmd;
        }

        public void execute(LineManager lm)
        {
            cmd.execute(lm);
        }
        
    }             
}
