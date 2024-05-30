using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Vosk;
using static System.Net.Mime.MediaTypeNames;

namespace 面试助手
{
    class SpeechToText
    {
        private WasapiLoopbackCapture waveIn;
        private VoskRecognizer recognizer;
        private String engineName;
        private string v;
        private ToolStripProgressBar progress;
        private System.Windows.Forms.Timer timer2;



        public SpeechToText(string engineName, ToolStripProgressBar progress, System.Windows.Forms.Timer timer2) 
        {
            this.engineName = engineName;
            this.progress = progress;
            this.timer2 = timer2;


            timer2.Enabled = true;
            progress.Value = 0;
            

            Thread td = new Thread(initModel);
            td.Start();
        }

        

        public void initModel() {
            // 初始化 Vosk 模型
            Vosk.Vosk.SetLogLevel(1); // 关闭日志
            var dir = Directory.GetCurrentDirectory();

            Model model = new Model(dir + "\\vosk\\" + engineName); // 模型路径


            waveIn = new WasapiLoopbackCapture();
            waveIn.DataAvailable += onDataAvailable;
            waveIn.WaveFormat = new WaveFormat(44100, 1);

            recognizer = new VoskRecognizer(model, waveIn.WaveFormat.SampleRate);
            recognizer.SetMaxAlternatives(0);
            recognizer.SetWords(true);

            start();
            timer2.Enabled = false;

            progress.GetCurrentParent().Invoke(new Action(() => progress.Value = 0));
        }


        public void start() {
            waveIn.StartRecording();
         }

        public void stop()
        {
            waveIn.StopRecording();

        }



        private async void onDataAvailable(object s, WaveInEventArgs e)
        {

            if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
            {
                string parsedText = ParsePartialResult(recognizer.Result(), "text");
                Trace.WriteLine(parsedText);
                NextQuestion.onNewLine(parsedText);
            }
            else
            {
                string parsedText = ParsePartialResult(recognizer.PartialResult(), "partial");

                Trace.WriteLine(parsedText);
                NextQuestion.lastSentence = parsedText;
            }

        }
        public static string ParsePartialResult(string json, String key = "text")
        {
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                if (root.TryGetProperty(key, out JsonElement textElement))
                {
                    return textElement.GetString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
