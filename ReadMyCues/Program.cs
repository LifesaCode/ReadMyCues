using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMyCues
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\candr\\Documents\\Projects\\VoiceNote Project\\rhyme.txt";
            // 
            LineManager lm = new LineManager(fileName);
            PlayLoop action = new PlayLoop(lm);
            

            // Need to print instructions to console
            Console.WriteLine("Welcome to Read My Cue. This program will speak each line of a text file individually.\n");

            // Need command from user (use wasd for controls for now)
            Console.WriteLine("Commands: <Space> = next line; 'd' = prev line; 'f' = current line; 'q' = quit");
            //Console.WriteLine("Enter a command");
            action.getInput();

            Console.WriteLine("End of Program in Main");
            Console.ReadKey();
        }
    }
}
