namespace NumberPatternPredictor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtInput.Location = new System.Drawing.Point(20, 60);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(450, 200);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Paste your numbers here...\nEach number per line";

            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.Location = new System.Drawing.Point(20, 270);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 30);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "📥 Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPredict.Location = new System.Drawing.Point(150, 270);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(150, 30);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "🔮 Predict Next";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTitle.Text = "AI Number Pattern Predictor";

            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.lblResult);
            this.panelResult.Location = new System.Drawing.Point(20, 320);
            this.panelResult.Padding = new System.Windows.Forms.Padding(20);
            this.panelResult.Size = new System.Drawing.Size(450, 150);
            this.panelResult.TabIndex = 3;

            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Text = "🤖 การทำนายด้วย AI:\n\n?";
            this.lblResult.AutoSize = false;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.panelResult);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(516, 539);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Number Pattern Predictor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label lblResult;
    }
}