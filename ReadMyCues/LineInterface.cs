using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMyCues
{
    interface LineInterface
    {
        string getCurrLine();
        string getNextLine();
        string getPrevLine();
    }
}
