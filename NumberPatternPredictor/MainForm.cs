using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumberPatternPredictor
{
    public partial class MainForm : Form
    {
        private List<int> numbers = new List<int>();
        private PredictorEngine engine = new PredictorEngine();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string rawData = txtInput.Text;
            var lines = rawData.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            numbers.Clear();
            foreach (var line in lines)
            {
                if (int.TryParse(line.Trim(), out int num))
                    numbers.Add(num);
            }

            MessageBox.Show($"Loaded {numbers.Count} numbers.");
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (numbers == null || numbers.Count < 11)
            {
                MessageBox.Show("Please load at least 11 numbers first.");
                return;
            }

            try
            {
                float aiPred = engine.PredictWithAI(numbers);
                string result = $"🤖 การทำนายด้วย AI:\n\n{(int)Math.Round(aiPred)}";

                lblResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}