using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMyCues
{
    class LineManager : LineInterface
    {
        private StringCollection lines = new StringCollection();
        int currIndex = -1;

        public LineManager(String fileName)
        {
            string line;
            Console.WriteLine("Opening file: rhyme.txt\n");
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                    //Console.WriteLine(line);
                }
            } catch  (FileNotFoundException e)
            {
                
            }
            
        }
 

        public string getCurrLine()
        {
            if(currIndex < 0)
            {
                return lines[0];
            }
            else if(currIndex >= lines.Count)
            {
                return lines[lines.Count - 1];
            }
            else
            {
                return lines[currIndex];
            }
        }


        public string getNextLine()
        {
            if (currIndex < (lines.Count - 1))
            {
                currIndex++;
                return lines[currIndex];
            } else
            {
                return "End of file.";
            }
        }


        public string getPrevLine()
        {
            if(currIndex > 0)
            {
                currIndex--;
                return lines[currIndex];
            }
            else
            {
                return "At beginning of file";
            }
        }

        public String goToBegin()
        {
            currIndex = -1;
            return "At beginning of file ";
        }

        public String goToEnd()
        {
            currIndex = lines.Count - 1;
            return "At end of file.";
        }
    }
}
