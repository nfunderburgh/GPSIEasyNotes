namespace GPSIEasyNotes
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.undoButton = new MaterialSkin.Controls.MaterialButton();
            this.resetButton = new MaterialSkin.Controls.MaterialButton();
            this.copyButton = new MaterialSkin.Controls.MaterialButton();
            this.resolutionTextBox = new System.Windows.Forms.TextBox();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.snTextBox = new System.Windows.Forms.TextBox();
            this.callerLabel = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.callerTextBox = new System.Windows.Forms.TextBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.issueLabel = new System.Windows.Forms.Label();
            this.snLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.snNDTextBox = new System.Windows.Forms.TextBox();
            this.callerNDLabel = new System.Windows.Forms.Label();
            this.companyNDTextBox = new System.Windows.Forms.TextBox();
            this.callerNDTextBox = new System.Windows.Forms.TextBox();
            this.snNDLabel = new System.Windows.Forms.Label();
            this.companyNDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.caseNDLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControl1.Location = new System.Drawing.Point(6, 67);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 387);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.undoButton);
            this.tabPage1.Controls.Add(this.resetButton);
            this.tabPage1.Controls.Add(this.copyButton);
            this.tabPage1.Controls.Add(this.resolutionTextBox);
            this.tabPage1.Controls.Add(this.issueTextBox);
            this.tabPage1.Controls.Add(this.snTextBox);
            this.tabPage1.Controls.Add(this.callerLabel);
            this.tabPage1.Controls.Add(this.companyTextBox);
            this.tabPage1.Controls.Add(this.callerTextBox);
            this.tabPage1.Controls.Add(this.resolutionLabel);
            this.tabPage1.Controls.Add(this.issueLabel);
            this.tabPage1.Controls.Add(this.snLabel);
            this.tabPage1.Controls.Add(this.companyLabel);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notes";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // undoButton
            // 
            this.undoButton.AutoSize = false;
            this.undoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.undoButton.Depth = 0;
            this.undoButton.HighEmphasis = true;
            this.undoButton.Icon = null;
            this.undoButton.Location = new System.Drawing.Point(165, 321);
            this.undoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.undoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoButton.Name = "undoButton";
            this.undoButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.undoButton.Size = new System.Drawing.Size(112, 36);
            this.undoButton.TabIndex = 15;
            this.undoButton.Text = "undo";
            this.undoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.undoButton.UseAccentColor = false;
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = false;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetButton.Depth = 0;
            this.resetButton.HighEmphasis = true;
            this.resetButton.Icon = null;
            this.resetButton.Location = new System.Drawing.Point(165, 237);
            this.resetButton.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.resetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetButton.Name = "resetButton";
            this.resetButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetButton.Size = new System.Drawing.Size(112, 36);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetButton.UseAccentColor = false;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.AutoSize = false;
            this.copyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.copyButton.Depth = 0;
            this.copyButton.HighEmphasis = true;
            this.copyButton.Icon = null;
            this.copyButton.Location = new System.Drawing.Point(48, 237);
            this.copyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.copyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.copyButton.Name = "copyButton";
            this.copyButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.copyButton.Size = new System.Drawing.Size(103, 36);
            this.copyButton.TabIndex = 13;
            this.copyButton.Text = "Copy";
            this.copyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.copyButton.UseAccentColor = false;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // resolutionTextBox
            // 
            this.resolutionTextBox.BackColor = System.Drawing.Color.White;
            this.resolutionTextBox.Location = new System.Drawing.Point(123, 195);
            this.resolutionTextBox.Name = "resolutionTextBox";
            this.resolutionTextBox.Size = new System.Drawing.Size(154, 23);
            this.resolutionTextBox.TabIndex = 10;
            // 
            // issueTextBox
            // 
            this.issueTextBox.Location = new System.Drawing.Point(123, 161);
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.Size = new System.Drawing.Size(154, 23);
            this.issueTextBox.TabIndex = 9;
            // 
            // snTextBox
            // 
            this.snTextBox.Location = new System.Drawing.Point(123, 127);
            this.snTextBox.Name = "snTextBox";
            this.snTextBox.Size = new System.Drawing.Size(154, 23);
            this.snTextBox.TabIndex = 8;
            // 
            // callerLabel
            // 
            this.callerLabel.AutoSize = true;
            this.callerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callerLabel.Location = new System.Drawing.Point(48, 56);
            this.callerLabel.Name = "callerLabel";
            this.callerLabel.Size = new System.Drawing.Size(69, 25);
            this.callerLabel.TabIndex = 7;
            this.callerLabel.Text = "Caller:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(123, 91);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(154, 23);
            this.companyTextBox.TabIndex = 6;
            // 
            // callerTextBox
            // 
            this.callerTextBox.Location = new System.Drawing.Point(123, 58);
            this.callerTextBox.Name = "callerTextBox";
            this.callerTextBox.Size = new System.Drawing.Size(154, 23);
            this.callerTextBox.TabIndex = 5;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.BackColor = System.Drawing.Color.White;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resolutionLabel.Location = new System.Drawing.Point(8, 190);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(109, 25);
            this.resolutionLabel.TabIndex = 4;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.BackColor = System.Drawing.Color.White;
            this.issueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issueLabel.Location = new System.Drawing.Point(52, 156);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(65, 25);
            this.issueLabel.TabIndex = 3;
            this.issueLabel.Text = "Issue:";
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.BackColor = System.Drawing.Color.White;
            this.snLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snLabel.Location = new System.Drawing.Point(65, 122);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(52, 25);
            this.snLabel.TabIndex = 2;
            this.snLabel.Text = "S/N:";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.White;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyLabel.Location = new System.Drawing.Point(14, 86);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(103, 25);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Company:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.caseNDLabel);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.snNDTextBox);
            this.tabPage2.Controls.Add(this.callerNDLabel);
            this.tabPage2.Controls.Add(this.companyNDTextBox);
            this.tabPage2.Controls.Add(this.callerNDTextBox);
            this.tabPage2.Controls.Add(this.snNDLabel);
            this.tabPage2.Controls.Add(this.companyNDLabel);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Netradyne";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(124, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(298, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // snNDTextBox
            // 
            this.snNDTextBox.Location = new System.Drawing.Point(124, 124);
            this.snNDTextBox.Name = "snNDTextBox";
            this.snNDTextBox.Size = new System.Drawing.Size(154, 23);
            this.snNDTextBox.TabIndex = 14;
            // 
            // callerNDLabel
            // 
            this.callerNDLabel.AutoSize = true;
            this.callerNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callerNDLabel.Location = new System.Drawing.Point(49, 53);
            this.callerNDLabel.Name = "callerNDLabel";
            this.callerNDLabel.Size = new System.Drawing.Size(69, 25);
            this.callerNDLabel.TabIndex = 13;
            this.callerNDLabel.Text = "Caller:";
            // 
            // companyNDTextBox
            // 
            this.companyNDTextBox.Location = new System.Drawing.Point(124, 88);
            this.companyNDTextBox.Name = "companyNDTextBox";
            this.companyNDTextBox.Size = new System.Drawing.Size(154, 23);
            this.companyNDTextBox.TabIndex = 12;
            // 
            // callerNDTextBox
            // 
            this.callerNDTextBox.Location = new System.Drawing.Point(124, 55);
            this.callerNDTextBox.Name = "callerNDTextBox";
            this.callerNDTextBox.Size = new System.Drawing.Size(154, 23);
            this.callerNDTextBox.TabIndex = 11;
            // 
            // snNDLabel
            // 
            this.snNDLabel.AutoSize = true;
            this.snNDLabel.BackColor = System.Drawing.Color.White;
            this.snNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snNDLabel.Location = new System.Drawing.Point(66, 119);
            this.snNDLabel.Name = "snNDLabel";
            this.snNDLabel.Size = new System.Drawing.Size(52, 25);
            this.snNDLabel.TabIndex = 10;
            this.snNDLabel.Text = "S/N:";
            // 
            // companyNDLabel
            // 
            this.companyNDLabel.AutoSize = true;
            this.companyNDLabel.BackColor = System.Drawing.Color.White;
            this.companyNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyNDLabel.Location = new System.Drawing.Point(15, 83);
            this.companyNDLabel.Name = "companyNDLabel";
            this.companyNDLabel.Size = new System.Drawing.Size(103, 25);
            this.companyNDLabel.TabIndex = 9;
            this.companyNDLabel.Text = "Company:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 15;
            // 
            // caseNDLabel
            // 
            this.caseNDLabel.AutoSize = true;
            this.caseNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caseNDLabel.Location = new System.Drawing.Point(53, 21);
            this.caseNDLabel.Name = "caseNDLabel";
            this.caseNDLabel.Size = new System.Drawing.Size(65, 25);
            this.caseNDLabel.TabIndex = 16;
            this.caseNDLabel.Text = "Case:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GSPI Easy Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ContextMenuStrip contextMenuStrip1;
        private Label resolutionLabel;
        private Label issueLabel;
        private Label snLabel;
        private Label companyLabel;
        private TextBox companyTextBox;
        private TextBox callerTextBox;
        private Label callerLabel;
        private TextBox resolutionTextBox;
        private TextBox issueTextBox;
        private TextBox snTextBox;
        private MaterialSkin.Controls.MaterialButton resetButton;
        private MaterialSkin.Controls.MaterialButton copyButton;
        private MaterialSkin.Controls.MaterialButton undoButton;
        private Label caseNDLabel;
        private TextBox textBox1;
        private TextBox snNDTextBox;
        private Label callerNDLabel;
        private TextBox companyNDTextBox;
        private TextBox callerNDTextBox;
        private Label snNDLabel;
        private Label companyNDLabel;
    }
}