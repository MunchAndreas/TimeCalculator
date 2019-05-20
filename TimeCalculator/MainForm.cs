using System;
using System.Drawing;
using System.Globalization;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class MainForm : Form
    {
        private TimeSpan _summedTimeResult;

        public MainForm()
        {
            InitializeComponent();
            SetWeekNumberText();
        }

        public string ThisWeekNumber => 
            CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday).ToString();

        private decimal DigitalTimeResult => ConvertTimeToDigit(_summedTimeResult);

        private void SetWeekNumberText()
        {
            var font = new Font(WeekLabel.Font.FontFamily, WeekLabel.Height, FontStyle.Bold, GraphicsUnit.Pixel);
            WeekLabel.Font = font;
            WeekLabel.ForeColor = Color.CadetBlue;
            WeekLabel.Text = ThisWeekNumber;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SumAllInput();
            ClearAllInputFields();
            CopyResultToOutputFields();
            CopyResultToClipboard();
            SpeakTheResult(DigitalTimeResult.ToString(CultureInfo.CurrentCulture));
            Time1TextBox.Focus();
        }

        private void SpeakTheResult(string input)
        {
            if (SpeakTheResultCheckBox.Checked)
            {
                var synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Speak($"The calculated value is {input}");
            }
        }

        private void GoToNextInputControl(object sender)
        {
            var senderControl = (TextBox) sender;

            if (senderControl.Tag == null || (string) senderControl.Tag == string.Empty) return;

            var nextControl = Controls.Find((string) senderControl.Tag, true);
            (nextControl[0] as TextBox)?.Focus();
        }

        private void CopyResultToOutputFields()
        {
            TimeResultTextBox.Text = _summedTimeResult.ToString();
            DigitResultTextBox.Text = DigitalTimeResult.ToString(CultureInfo.CurrentCulture);
        }

        private void CopyResultToClipboard()
        {
            if (CopyToClipboardCheckBox.Checked) Clipboard.SetText(DigitResultTextBox.Text);
        }

        private void SumAllInput()
        {
            _summedTimeResult =
                AddTime(AddTime(
                        Time1TextBox.Text.Replace('.', ':'),
                        Time2TextBox.Text.Replace('.', ':')).ToString(),
                    Time3TextBox.Text.Replace('.', ':'));
        }

        private void ClearAllInputFields()
        {
            Time1TextBox.Clear();
            Time2TextBox.Clear();
            Time3TextBox.Clear();
        }

        private static decimal ConvertTimeToDigit(TimeSpan time)
        {
            return Math.Round(Convert.ToDecimal(time.TotalHours), 2);
        }

        private static TimeSpan AddTime(string time1, string time2)
        {
            TimeSpan t1;
            TimeSpan t2;
            TimeSpan.TryParse(time1, out t1);
            TimeSpan.TryParse(time2, out t2);

            try
            {
                return t1.Add(t2);
            }
            catch (Exception)
            {
                return new TimeSpan();
            }
        }

        private void InputTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox) sender).Clear();
        }

        private void InputTextBox_EnterFirst(object sender, EventArgs e)
        {
            ClearAllInputFields();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox) sender).Text == string.Empty) return;

            SumAllInput();
            CopyResultToOutputFields();
            CopyResultToClipboard();
            GoToNextInputControl(sender);
            SpeakTheResult(DigitalTimeResult.ToString(CultureInfo.CurrentCulture));
        }

        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            SetWeekNumberText();
        }
    }
}