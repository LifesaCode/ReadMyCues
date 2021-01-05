using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMyCues
{
/* Class will get a character as input from the user. That character will determine the next program action.
 * The desired command will be set in ButtonInvoker using setCommand(command), then executed using the 
 * execute() command. This loop will continue until the user enters 'q' to quit, at which time control returns
 * to main(). */

    class PlayLoop
    {
        LineManager lm;
        ButtonInvoker invoke = new ButtonInvoker();
        PlayCurrCommand playCurr = new PlayCurrCommand();
        PlayNextCommand playNext = new PlayNextCommand();
        PlayPrevCommand playPrev = new PlayPrevCommand();
        PlayFromBeginCommand goToBegin = new PlayFromBeginCommand();
        PlayFromEndCommand goToEnd = new PlayFromEndCommand();
        ConsoleKeyInfo input;

        public PlayLoop(LineManager lm)
        {
            this.lm = lm;   
        }

        public void getInput()
        {
            char keyIn;

            do
            {
                input = Console.ReadKey(true);
                keyIn = input.KeyChar;
                
                switch (keyIn)
                {
                    case ' ':
                        // play next line
                        invoke.setCommand(playNext);
                        invoke.execute(lm);
                        break;
                    case 'f':
                    case 'j':
                        // play current line
                        invoke.setCommand(playCurr);
                        invoke.execute(lm);
                        break;
                    case 'd':
                    case 'k':
                        // play prev
                        invoke.setCommand(playPrev);
                        invoke.execute(lm);
                        break;
                    case 'q':
                        //quit file
                        break;
                    case 's':
                        // go to beginning
                        invoke.setCommand(goToBegin);
                        invoke.execute(lm);
                        break;
                    case 'e':
                        //go to end
                        invoke.setCommand(goToEnd);
                        invoke.execute(lm);
                        break;
                    default:
                        // "didn't understand that command:
                        break;
                }
            } while (keyIn != 'q');
        }
    }
}
