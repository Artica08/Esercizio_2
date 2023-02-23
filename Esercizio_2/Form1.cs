using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Esercizio_2
{
    public partial class Form1 : Form
    {
        // This example requires environment variables named "SPEECH_KEY" and "SPEECH_REGION"
        static string speechKey = "";
        static string speechRegion = "";

        public Form1()
        {
            InitializeComponent();
        }

        static void OutputSpeechSynthesisResult(SpeechSynthesisResult speechSynthesisResult, string text)
        {
            switch (speechSynthesisResult.Reason)
            {
                case ResultReason.SynthesizingAudioCompleted:
                    Console.WriteLine($"Speech synthesized for text: [{text}]");
                    break;
                case ResultReason.Canceled:
                    var cancellation = SpeechSynthesisCancellationDetails.FromResult(speechSynthesisResult);
                    Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                    if (cancellation.Reason == CancellationReason.Error)
                    {
                        Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                        Console.WriteLine($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]");
                        Console.WriteLine($"CANCELED: Did you set the speech resource key and region values?");
                    }
                    break;
                default:
                    break;
            }
        }

        static void OutputSpeechRecognitionResult(SpeechRecognitionResult speechRecognitionResult)
        {
            switch (speechRecognitionResult.Reason)
            {
                case ResultReason.RecognizedSpeech:
                    Console.WriteLine($"RECOGNIZED: Text={speechRecognitionResult.Text}");

                    break;
                case ResultReason.NoMatch:
                    Console.WriteLine($"NOMATCH: Speech could not be recognized.");
                    break;
                case ResultReason.Canceled:
                    var cancellation = CancellationDetails.FromResult(speechRecognitionResult);
                    Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");

                    if (cancellation.Reason == CancellationReason.Error)
                    {
                        Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                        Console.WriteLine($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                        Console.WriteLine($"CANCELED: Did you set the speech resource key and region values?");
                    }
                    break;
            }
        }

        async static Task ConvertToAudio(string text)
        {
            var speechConfig = SpeechConfig.FromSubscription(speechKey, speechRegion);

            // The language of the voice that speaks.
            speechConfig.SpeechSynthesisVoiceName = "en-US-JennyNeural";

            using (var speechSynthesizer = new SpeechSynthesizer(speechConfig))
            {
                var speechSynthesisResult = await speechSynthesizer.SpeakTextAsync(text);
                OutputSpeechSynthesisResult(speechSynthesisResult, text);
            }
            SynthesizeAudioAsync();
        }

        static async Task SynthesizeAudioAsync()
        {
            var speechConfig = SpeechConfig.FromSubscription("", "");
            var audioConfig = AudioConfig.FromWavFileOutput("path\\file.mp3");
            var synthesizer = new SpeechSynthesizer(speechConfig, audioConfig);
            await synthesizer.SpeakTextAsync("Ciao. Io sono Damiano. Come va oggi? tutto bene. ok. ok ok ok.");
        }

        async static Task<string> ConvertToText()
        {
            try
            {
                var speechConfig = SpeechConfig.FromSubscription(speechKey, speechRegion);
                speechConfig.SpeechRecognitionLanguage = "it-IT";

                var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
                var speechRecognizer = new SpeechRecognizer(speechConfig, audioConfig);

                Console.WriteLine("Speak into your microphone.");
                var speechRecognitionResult = await speechRecognizer.RecognizeOnceAsync();
                OutputSpeechRecognitionResult(speechRecognitionResult);

                Console.WriteLine(speechRecognitionResult.Text);
                return speechRecognitionResult.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // Convert voice to text
            var text = await ConvertToText();
            
            // Write on label
            label4.Text = text.ToString();
        }

        private void btn_start_text_Click(object sender, EventArgs e)
        {
            // Get text from the console and synthesize to the default speaker.
            string text = txt_to_speech.Text;

            ConvertToAudio(text);
        }
    }
}
