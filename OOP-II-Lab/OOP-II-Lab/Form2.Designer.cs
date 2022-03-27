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
            this.shapeSaveBtn = new System.Windows.Forms.Button();
            this.optionPanel.SuspendLayout();
            this.shapePanel.SuspendLayout();
            this.difficultyPanel.SuspendLayout();
            this.customSubPanel.SuspendLayout();
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
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(111, 450);
            this.optionPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.Location = new System.Drawing.Point(0, 319);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(111, 23);
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
            this.shapePanel.Location = new System.Drawing.Point(0, 219);
            this.shapePanel.Name = "shapePanel";
            this.shapePanel.Size = new System.Drawing.Size(111, 100);
            this.shapePanel.TabIndex = 3;
            this.shapePanel.Visible = false;
            // 
            // squareCheckBox
            // 
            this.squareCheckBox.AutoSize = true;
            this.squareCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.squareCheckBox.Location = new System.Drawing.Point(0, 38);
            this.squareCheckBox.Name = "squareCheckBox";
            this.squareCheckBox.Size = new System.Drawing.Size(111, 19);
            this.squareCheckBox.TabIndex = 3;
            this.squareCheckBox.Text = "Square";
            this.squareCheckBox.UseVisualStyleBackColor = true;
            // 
            // roundCheckBox
            // 
            this.roundCheckBox.AutoSize = true;
            this.roundCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundCheckBox.Location = new System.Drawing.Point(0, 19);
            this.roundCheckBox.Name = "roundCheckBox";
            this.roundCheckBox.Size = new System.Drawing.Size(111, 19);
            this.roundCheckBox.TabIndex = 2;
            this.roundCheckBox.Text = "Round";
            this.roundCheckBox.UseVisualStyleBackColor = true;
            // 
            // triangleCheckBox
            // 
            this.triangleCheckBox.AutoSize = true;
            this.triangleCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.triangleCheckBox.Location = new System.Drawing.Point(0, 0);
            this.triangleCheckBox.Name = "triangleCheckBox";
            this.triangleCheckBox.Size = new System.Drawing.Size(111, 19);
            this.triangleCheckBox.TabIndex = 1;
            this.triangleCheckBox.Text = "Triangle";
            this.triangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // shapeBtn
            // 
            this.shapeBtn.BackColor = System.Drawing.Color.Cyan;
            this.shapeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeBtn.Location = new System.Drawing.Point(0, 196);
            this.shapeBtn.Name = "shapeBtn";
            this.shapeBtn.Size = new System.Drawing.Size(111, 23);
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
            this.difficultyPanel.Location = new System.Drawing.Point(0, 23);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(111, 173);
            this.difficultyPanel.TabIndex = 1;
            this.difficultyPanel.Visible = false;
            // 
            // customSubPanel
            // 
            this.customSubPanel.Controls.Add(this.customSaveBtn);
            this.customSubPanel.Controls.Add(this.yValueText);
            this.customSubPanel.Controls.Add(this.xValueText);
            this.customSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customSubPanel.Location = new System.Drawing.Point(0, 92);
            this.customSubPanel.Name = "customSubPanel";
            this.customSubPanel.Size = new System.Drawing.Size(111, 75);
            this.customSubPanel.TabIndex = 4;
            this.customSubPanel.Visible = false;
            // 
            // customSaveBtn
            // 
            this.customSaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customSaveBtn.Location = new System.Drawing.Point(0, 46);
            this.customSaveBtn.Name = "customSaveBtn";
            this.customSaveBtn.Size = new System.Drawing.Size(111, 23);
            this.customSaveBtn.TabIndex = 4;
            this.customSaveBtn.Text = "Save";
            this.customSaveBtn.UseVisualStyleBackColor = true;
            this.customSaveBtn.Click += new System.EventHandler(this.customSaveBtn_Click);
            // 
            // yValueText
            // 
            this.yValueText.Dock = System.Windows.Forms.DockStyle.Top;
            this.yValueText.Location = new System.Drawing.Point(0, 23);
            this.yValueText.Name = "yValueText";
            this.yValueText.Size = new System.Drawing.Size(111, 23);
            this.yValueText.TabIndex = 3;
            // 
            // xValueText
            // 
            this.xValueText.Dock = System.Windows.Forms.DockStyle.Top;
            this.xValueText.Location = new System.Drawing.Point(0, 0);
            this.xValueText.Name = "xValueText";
            this.xValueText.Size = new System.Drawing.Size(111, 23);
            this.xValueText.TabIndex = 0;
            // 
            // customBtn
            // 
            this.customBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customBtn.Location = new System.Drawing.Point(0, 69);
            this.customBtn.Name = "customBtn";
            this.customBtn.Size = new System.Drawing.Size(111, 23);
            this.customBtn.TabIndex = 3;
            this.customBtn.Text = "Custom";
            this.customBtn.UseVisualStyleBackColor = true;
            this.customBtn.Click += new System.EventHandler(this.customBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hardBtn.Location = new System.Drawing.Point(0, 46);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(111, 23);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.normalBtn.Location = new System.Drawing.Point(0, 23);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(111, 23);
            this.normalBtn.TabIndex = 1;
            this.normalBtn.Text = "Normal";
            this.normalBtn.UseVisualStyleBackColor = true;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.easyBtn.Location = new System.Drawing.Point(0, 0);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(111, 23);
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
            this.difficultyBtn.Name = "difficultyBtn";
            this.difficultyBtn.Size = new System.Drawing.Size(111, 23);
            this.difficultyBtn.TabIndex = 0;
            this.difficultyBtn.Text = "Difficulty";
            this.difficultyBtn.UseVisualStyleBackColor = false;
            this.difficultyBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(193, 23);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(55, 15);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // selectedDifficultyLabel
            // 
            this.selectedDifficultyLabel.AutoSize = true;
            this.selectedDifficultyLabel.Location = new System.Drawing.Point(254, 23);
            this.selectedDifficultyLabel.Name = "selectedDifficultyLabel";
            this.selectedDifficultyLabel.Size = new System.Drawing.Size(0, 15);
            this.selectedDifficultyLabel.TabIndex = 2;
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(193, 46);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(39, 15);
            this.shapeLabel.TabIndex = 3;
            this.shapeLabel.Text = "Shape";
            // 
            // selectedShapeLabel
            // 
            this.selectedShapeLabel.AutoSize = true;
            this.selectedShapeLabel.Location = new System.Drawing.Point(254, 50);
            this.selectedShapeLabel.Name = "selectedShapeLabel";
            this.selectedShapeLabel.Size = new System.Drawing.Size(0, 15);
            this.selectedShapeLabel.TabIndex = 4;
            // 
            // shapeSaveBtn
            // 
            this.shapeSaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeSaveBtn.Location = new System.Drawing.Point(0, 57);
            this.shapeSaveBtn.Name = "shapeSaveBtn";
            this.shapeSaveBtn.Size = new System.Drawing.Size(111, 23);
            this.shapeSaveBtn.TabIndex = 4;
            this.shapeSaveBtn.Text = "Save";
            this.shapeSaveBtn.UseVisualStyleBackColor = true;
            this.shapeSaveBtn.Click += new System.EventHandler(this.shapeSaveBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedShapeLabel);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.selectedDifficultyLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.optionPanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.optionPanel.ResumeLayout(false);
            this.shapePanel.ResumeLayout(false);
            this.shapePanel.PerformLayout();
            this.difficultyPanel.ResumeLayout(false);
            this.customSubPanel.ResumeLayout(false);
            this.customSubPanel.PerformLayout();
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
    }
}