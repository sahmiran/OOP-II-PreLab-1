namespace OOP_II_Lab
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.shapePanel = new System.Windows.Forms.Panel();
            this.shapeSaveBtn = new System.Windows.Forms.Button();
            this.squareCheckBox = new System.Windows.Forms.CheckBox();
            this.roundCheckBox = new System.Windows.Forms.CheckBox();
            this.triangleCheckBox = new System.Windows.Forms.CheckBox();
            this.shapeBtn = new System.Windows.Forms.Button();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.customSubPanel = new System.Windows.Forms.Panel();
            this.customSaveBtn = new System.Windows.Forms.Button();
            this.yValueText = new System.Windows.Forms.TextBox();
            this.xValueText = new System.Windows.Forms.TextBox();
            this.customBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
            this.difficultyBtn = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.selectedDifficultyLabel = new System.Windows.Forms.Label();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.selectedShapeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.yellowCheckBox = new System.Windows.Forms.CheckBox();
            this.renkSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorLaber = new System.Windows.Forms.Label();
            this.optionPanel.SuspendLayout();
            this.shapePanel.SuspendLayout();
            this.difficultyPanel.SuspendLayout();
            this.customSubPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionPanel
            // 
            this.optionPanel.AutoScroll = true;
            this.optionPanel.Controls.Add(this.exitBtn);
            this.optionPanel.Controls.Add(this.shapePanel);
            this.optionPanel.Controls.Add(this.shapeBtn);
            this.optionPanel.Controls.Add(this.difficultyPanel);
            this.optionPanel.Controls.Add(this.difficultyBtn);
            this.optionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionPanel.Location = new System.Drawing.Point(0, 0);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(127, 600);
            this.optionPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.Location = new System.Drawing.Point(0, 426);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 31);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // shapePanel
            // 
            this.shapePanel.Controls.Add(this.shapeSaveBtn);
            this.shapePanel.Controls.Add(this.squareCheckBox);
            this.shapePanel.Controls.Add(this.roundCheckBox);
            this.shapePanel.Controls.Add(this.triangleCheckBox);
            this.shapePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapePanel.Location = new System.Drawing.Point(0, 293);
            this.shapePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shapePanel.Name = "shapePanel";
            this.shapePanel.Size = new System.Drawing.Size(127, 133);
            this.shapePanel.TabIndex = 3;
            this.shapePanel.Visible = false;
            // 
            // shapeSaveBtn
            // 
            this.shapeSaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeSaveBtn.Location = new System.Drawing.Point(0, 72);
            this.shapeSaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shapeSaveBtn.Name = "shapeSaveBtn";
            this.shapeSaveBtn.Size = new System.Drawing.Size(127, 31);
            this.shapeSaveBtn.TabIndex = 4;
            this.shapeSaveBtn.Text = "Save";
            this.shapeSaveBtn.UseVisualStyleBackColor = true;
            this.shapeSaveBtn.Click += new System.EventHandler(this.shapeSaveBtn_Click);
            // 
            // squareCheckBox
            // 
            this.squareCheckBox.AutoSize = true;
            this.squareCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.squareCheckBox.Location = new System.Drawing.Point(0, 48);
            this.squareCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.squareCheckBox.Name = "squareCheckBox";
            this.squareCheckBox.Size = new System.Drawing.Size(127, 24);
            this.squareCheckBox.TabIndex = 3;
            this.squareCheckBox.Text = "Square";
            this.squareCheckBox.UseVisualStyleBackColor = true;
            // 
            // roundCheckBox
            // 
            this.roundCheckBox.AutoSize = true;
            this.roundCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundCheckBox.Location = new System.Drawing.Point(0, 24);
            this.roundCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundCheckBox.Name = "roundCheckBox";
            this.roundCheckBox.Size = new System.Drawing.Size(127, 24);
            this.roundCheckBox.TabIndex = 2;
            this.roundCheckBox.Text = "Round";
            this.roundCheckBox.UseVisualStyleBackColor = true;
            // 
            // triangleCheckBox
            // 
            this.triangleCheckBox.AutoSize = true;
            this.triangleCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.triangleCheckBox.Location = new System.Drawing.Point(0, 0);
            this.triangleCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.triangleCheckBox.Name = "triangleCheckBox";
            this.triangleCheckBox.Size = new System.Drawing.Size(127, 24);
            this.triangleCheckBox.TabIndex = 1;
            this.triangleCheckBox.Text = "Triangle";
            this.triangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // shapeBtn
            // 
            this.shapeBtn.BackColor = System.Drawing.Color.Cyan;
            this.shapeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeBtn.Location = new System.Drawing.Point(0, 262);
            this.shapeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shapeBtn.Name = "shapeBtn";
            this.shapeBtn.Size = new System.Drawing.Size(127, 31);
            this.shapeBtn.TabIndex = 2;
            this.shapeBtn.Text = "Shape";
            this.shapeBtn.UseVisualStyleBackColor = false;
            this.shapeBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.Controls.Add(this.customSubPanel);
            this.difficultyPanel.Controls.Add(this.customBtn);
            this.difficultyPanel.Controls.Add(this.hardBtn);
            this.difficultyPanel.Controls.Add(this.normalBtn);
            this.difficultyPanel.Controls.Add(this.easyBtn);
            this.difficultyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficultyPanel.Location = new System.Drawing.Point(0, 31);
            this.difficultyPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(127, 231);
            this.difficultyPanel.TabIndex = 1;
            this.difficultyPanel.Visible = false;
            // 
            // customSubPanel
            // 
            this.customSubPanel.Controls.Add(this.customSaveBtn);
            this.customSubPanel.Controls.Add(this.yValueText);
            this.customSubPanel.Controls.Add(this.xValueText);
            this.customSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customSubPanel.Location = new System.Drawing.Point(0, 124);
            this.customSubPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customSubPanel.Name = "customSubPanel";
            this.customSubPanel.Size = new System.Drawing.Size(127, 100);
            this.customSubPanel.TabIndex = 4;
            this.customSubPanel.Visible = false;
            // 
            // customSaveBtn
            // 
            this.customSaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customSaveBtn.Location = new System.Drawing.Point(0, 54);
            this.customSaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customSaveBtn.Name = "customSaveBtn";
            this.customSaveBtn.Size = new System.Drawing.Size(127, 31);
            this.customSaveBtn.TabIndex = 4;
            this.customSaveBtn.Text = "Save";
            this.customSaveBtn.UseVisualStyleBackColor = true;
            this.customSaveBtn.Click += new System.EventHandler(this.customSaveBtn_Click);
            // 
            // yValueText
            // 
            this.yValueText.Dock = System.Windows.Forms.DockStyle.Top;
            this.yValueText.Location = new System.Drawing.Point(0, 27);
            this.yValueText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yValueText.Name = "yValueText";
            this.yValueText.Size = new System.Drawing.Size(127, 27);
            this.yValueText.TabIndex = 3;
            // 
            // xValueText
            // 
            this.xValueText.Dock = System.Windows.Forms.DockStyle.Top;
            this.xValueText.Location = new System.Drawing.Point(0, 0);
            this.xValueText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xValueText.Name = "xValueText";
            this.xValueText.Size = new System.Drawing.Size(127, 27);
            this.xValueText.TabIndex = 0;
            // 
            // customBtn
            // 
            this.customBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customBtn.Location = new System.Drawing.Point(0, 93);
            this.customBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(127, 31);
            this.customBtn.TabIndex = 3;
            this.customBtn.Text = "Custom";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hardBtn.Location = new System.Drawing.Point(0, 62);
            this.hardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(127, 31);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.normalBtn.Location = new System.Drawing.Point(0, 31);
            this.normalBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(127, 31);
            this.normalBtn.TabIndex = 1;
            this.normalBtn.Text = "Normal";
            this.normalBtn.UseVisualStyleBackColor = true;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.easyBtn.Location = new System.Drawing.Point(0, 0);
            this.easyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(127, 31);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // difficultyBtn
            // 
            this.difficultyBtn.BackColor = System.Drawing.Color.Red;
            this.difficultyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficultyBtn.Location = new System.Drawing.Point(0, 0);
            this.difficultyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.difficultyBtn.Name = "difficultyBtn";
            this.difficultyBtn.Size = new System.Drawing.Size(127, 31);
            this.difficultyBtn.TabIndex = 0;
            this.difficultyBtn.Text = "Difficulty";
            this.difficultyBtn.UseVisualStyleBackColor = false;
            this.difficultyBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(221, 31);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(69, 20);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // selectedDifficultyLabel
            // 
            this.selectedDifficultyLabel.AutoSize = true;
            this.selectedDifficultyLabel.Location = new System.Drawing.Point(290, 31);
            this.selectedDifficultyLabel.Name = "selectedDifficultyLabel";
            this.selectedDifficultyLabel.Size = new System.Drawing.Size(0, 20);
            this.selectedDifficultyLabel.TabIndex = 2;
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(221, 61);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(50, 20);
            this.shapeLabel.TabIndex = 3;
            this.shapeLabel.Text = "Shape";
            // 
            // selectedShapeLabel
            // 
            this.selectedShapeLabel.AutoSize = true;
            this.selectedShapeLabel.Location = new System.Drawing.Point(290, 67);
            this.selectedShapeLabel.Name = "selectedShapeLabel";
            this.selectedShapeLabel.Size = new System.Drawing.Size(0, 20);
            this.selectedShapeLabel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(664, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 600);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.renkSaveBtn);
            this.panel2.Controls.Add(this.yellowCheckBox);
            this.panel2.Controls.Add(this.blueCheckBox);
            this.panel2.Controls.Add(this.redCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 139);
            this.panel2.TabIndex = 0;
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.redCheckBox.Location = new System.Drawing.Point(0, 0);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(250, 24);
            this.redCheckBox.TabIndex = 0;
            this.redCheckBox.Text = "Red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.blueCheckBox.Location = new System.Drawing.Point(0, 24);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(250, 24);
            this.blueCheckBox.TabIndex = 1;
            this.blueCheckBox.Text = "Blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            // 
            // yellowCheckBox
            // 
            this.yellowCheckBox.AutoSize = true;
            this.yellowCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.yellowCheckBox.Location = new System.Drawing.Point(0, 48);
            this.yellowCheckBox.Name = "yellowCheckBox";
            this.yellowCheckBox.Size = new System.Drawing.Size(250, 24);
            this.yellowCheckBox.TabIndex = 2;
            this.yellowCheckBox.Text = "Yellow";
            this.yellowCheckBox.UseVisualStyleBackColor = true;
            // 
            // renkSaveBtn
            // 
            this.renkSaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.renkSaveBtn.Location = new System.Drawing.Point(0, 72);
            this.renkSaveBtn.Name = "renkSaveBtn";
            this.renkSaveBtn.Size = new System.Drawing.Size(250, 29);
            this.renkSaveBtn.TabIndex = 3;
            this.renkSaveBtn.Text = "Save";
            this.renkSaveBtn.UseVisualStyleBackColor = true;
            this.renkSaveBtn.Click += new System.EventHandler(this.renkSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color";
            // 
            // colorLaber
            // 
            this.colorLaber.AutoSize = true;
            this.colorLaber.Location = new System.Drawing.Point(298, 96);
            this.colorLaber.Name = "colorLaber";
            this.colorLaber.Size = new System.Drawing.Size(0, 20);
            this.colorLaber.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.colorLaber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedShapeLabel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.selectedDifficultyLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.optionPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.optionPanel.ResumeLayout(false);
            this.shapePanel.ResumeLayout(false);
            this.shapePanel.PerformLayout();
            this.difficultyPanel.ResumeLayout(false);
            this.customSubPanel.ResumeLayout(false);
            this.customSubPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel optionPanel;
        private Panel difficultyPanel;
        private Button customBtn;
        private Button hardBtn;
        private Button normalBtn;
        private Button easyBtn;
        private Button difficultyBtn;
        private Panel shapePanel;
        private Button shapeBtn;
        private CheckBox roundCheckBox;
        private CheckBox triangleCheckBox;
        private CheckBox squareCheckBox;
        private Panel customSubPanel;
        private Button customSaveBtn;
        private TextBox yValueText;
        private TextBox xValueText;
        private Button exitBtn;
        private Button saveoptionBtn;
        private Label difficultyLabel;
        private Label selectedDifficultyLabel;
        private Label shapeLabel;
        private Label selectedShapeLabel;
        private Button shapeSaveBtn;
        private Panel panel1;
        private Panel panel2;
        private Button renkSaveBtn;
        private CheckBox yellowCheckBox;
        private CheckBox blueCheckBox;
        private CheckBox redCheckBox;
        private Label label1;
        private Label colorLaber;
    }
}