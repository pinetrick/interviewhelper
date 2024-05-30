using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 面试助手
{
    public partial class WebForm : Form
    {
        private SpeechToText speechToText;

        public WebForm()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser browser;
        public ChromiumWebBrowser translate;

        public void InitBrowser()
        {
            CefSettings settings = new CefSettings();
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36 /CefSharp Browser" + Cef.CefSharpVersion;
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            Cef.Initialize(settings);

            translate = new ChromiumWebBrowser("https://translate.google.com/");
            splitContainer1.Panel1.Controls.Add(translate);
            translate.Dock = DockStyle.Fill;

            browser = new ChromiumWebBrowser("https://chatgpt.com/g/g-m24xfQRU1-interview-answer-expert");
            splitContainer1.Panel2.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;



        }

        private void WebForm_Load(object sender, EventArgs e)
        {

        }

        private void WebForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Environment.Exit(0);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            browser.LoadUrl("https://chatgpt.com/g/g-m24xfQRU1-interview-answer-expert");

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {




        }

        private string lastText = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!refreshBtn.Checked) return;

            var thisText = NextQuestion.getNextQuestion().Replace("'", "\"").Replace("\n", "\\\n");
            if (lastText == thisText) return;
            lastText = thisText;

            // 更新textarea的值，触发事件，并模拟按下回车键
            string script = @"
                    var textarea = document.querySelector('textarea[aria-label=原文]');
                    textarea.value = '" + thisText + @"';
                    var event = new Event('input', { bubbles: true });
                    textarea.dispatchEvent(event);

                    setTimeout(function() {
                        var enterEvent = new KeyboardEvent('keydown', {
                            key: 'Enter',
                            code: 'Enter',
                            keyCode: 13,
                            charCode: 13,
                            bubbles: true
                        });
                        textarea.dispatchEvent(enterEvent);
                    }, 300); // 延迟 300 毫秒
                    
                ";
            try
            {
                translate.ExecuteScriptAsync(script);
            }
            catch (Exception ex) { }



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NextQuestion.clear();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // 更新textarea的值，触发事件，并模拟按下回车键
            string script = @"
                    var textarea = document.getElementById('prompt-textarea'); 
                    textarea.value = '" + NextQuestion.getNextQuestion().Replace("'", "\"").Replace("\n", "\\\n") + @"';
                    var event = new Event('input', { bubbles: true });
                    textarea.dispatchEvent(event);

                    setTimeout(function() {
                        var enterEvent = new KeyboardEvent('keydown', {
                            key: 'Enter',
                            code: 'Enter',
                            keyCode: 13,
                            charCode: 13,
                            bubbles: true
                        });
                        textarea.dispatchEvent(enterEvent);
                    }, 300); // 延迟 300 毫秒
                    
                ";
            browser.ExecuteScriptAsync(script);
            NextQuestion.clear();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {


        }

        private void 英文精简引擎ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Enabled = false;
            speechToText = new SpeechToText("vosk-model-small-en-us-0.15", progress, timer2);
            progress.Maximum = 10;
        }

        private void 英文完整版引擎ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Enabled = false;
            speechToText = new SpeechToText("vosk-model-en-us-0.22", progress, timer2);
            progress.Maximum = 400;
        }

        private void 中文精简引擎ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Enabled = false;
            speechToText = new SpeechToText("vosk-model-small-cn-0.22", progress, timer2);
            progress.Maximum = 10;
        }

        private void 中文完整版引擎ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Enabled = false;
            speechToText = new SpeechToText("vosk-model-cn-0.22", progress, timer2);
            progress.Maximum = 250;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton1.Enabled = false;
            speechToText = new SpeechToText("vosk-model-small-en-us-0.15", progress, timer2);
            progress.Maximum = 10;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progress.Value < progress.Maximum) progress.Value += 1;
        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            browser.LoadUrl("https://chatgpt.com/");
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
