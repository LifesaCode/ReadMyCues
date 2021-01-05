using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ReadMyCues
{
    abstract class Command
    {
        static SpeechSynthesizer speaker;

        public abstract void execute(LineManager lm);

        public void play(String line)
        {
            if (speaker != null) {
                if(speaker.State == SynthesizerState.Speaking)
                {
                    speaker.SpeakAsyncCancelAll();
                }
                speaker.Dispose();
            }
            speaker = new SpeechSynthesizer();
            speaker.SpeakAsync(line);
        }
    }
}
