namespace Exemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextX = new TextBox();
            labelOutput = new Label();
            inputTextY = new TextBox();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnQuad = new Button();
            btnRaiz = new Button();
            btnPorc = new Button();
            btnBin = new Button();
            btnElev = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(16, 58);
            inputTextX.Name = "inputTextX";
            inputTextX.PlaceholderText = "X";
            inputTextX.Size = new Size(222, 31);
            inputTextX.TabIndex = 1;
            inputTextX.TextChanged += inputTextX_TextChanged;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.Gray;
            labelOutput.ForeColor = Color.Linen;
            labelOutput.Location = new Point(370, 9);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(16, 107);
            inputTextY.Name = "inputTextY";
            inputTextY.PlaceholderText = "Y";
            inputTextY.Size = new Size(222, 31);
            inputTextY.TabIndex = 2;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(16, 190);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(70, 50);
            btnSoma.TabIndex = 5;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += onSomaClick;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(101, 190);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(70, 50);
            btnSub.TabIndex = 6;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += onSubClick;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(177, 190);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(70, 50);
            btnMult.TabIndex = 7;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += onMultClick;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(16, 256);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(70, 50);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += onDivClick;
            // 
            // btnQuad
            // 
            btnQuad.Location = new Point(101, 256);
            btnQuad.Name = "btnQuad";
            btnQuad.Size = new Size(70, 50);
            btnQuad.TabIndex = 9;
            btnQuad.Text = "x²";
            btnQuad.UseVisualStyleBackColor = true;
            btnQuad.Click += onQuadClick;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(177, 256);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(70, 50);
            btnRaiz.TabIndex = 10;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += onRaizClick;
            // 
            // btnPorc
            // 
            btnPorc.Location = new Point(16, 321);
            btnPorc.Name = "btnPorc";
            btnPorc.Size = new Size(70, 50);
            btnPorc.TabIndex = 11;
            btnPorc.Text = "%";
            btnPorc.UseVisualStyleBackColor = true;
            btnPorc.Click += onPorcClick;
            // 
            // btnBin
            // 
            btnBin.Location = new Point(101, 321);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(70, 50);
            btnBin.TabIndex = 12;
            btnBin.Text = "0101";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += onBinClick;
            // 
            // btnElev
            // 
            btnElev.Location = new Point(177, 321);
            btnElev.Name = "btnElev";
            btnElev.Size = new Size(70, 50);
            btnElev.TabIndex = 13;
            btnElev.Text = "x^y";
            btnElev.UseVisualStyleBackColor = true;
            btnElev.Click += onElevClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btnPorc);
            Controls.Add(btnElev);
            Controls.Add(btnBin);
            Controls.Add(btnQuad);
            Controls.Add(btnRaiz);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputTextX;
        private Label labelOutput;
        private TextBox inputTextY;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnQuad;
        private Button btnRaiz;
        private Button btnPorc;
        private Button btnBin;
        private Button btnElev;
    }
}