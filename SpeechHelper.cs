using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Text;

namespace BrailleReader {
    public class SpeechHelper {

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public SpeechHelper() {
            synthesizer.SetOutputToDefaultAudioDevice();
        }

        public async void say(String toSay) {
            synthesizer.SpeakAsync(toSay);
        }
    }
}
