namespace MyFirstWindowsApp
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

       
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

        
        private void InitializeComponent()
        {
            LanguageSelector = new ComboBox();
            TextBox = new TextBox();
            AddButton = new Button();
            AddNewLanguage = new Label();
            Data = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LanguageSelector
            // 
            LanguageSelector.FormattingEnabled = true;
            LanguageSelector.Items.AddRange(new object[] { "Python", "C++", "Java", "PHP", "Swift" });
            LanguageSelector.Location = new Point(136, 93);
            LanguageSelector.Name = "LanguageSelector";
            LanguageSelector.Size = new Size(151, 28);
            LanguageSelector.TabIndex = 0;
            LanguageSelector.Text = "Choose";
            // 
            // TextBox
            // 
            TextBox.BackColor = SystemColors.ButtonHighlight;
            TextBox.Location = new Point(564, 94);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(125, 27);
            TextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(695, 94);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.TextAlign = ContentAlignment.TopCenter;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddLanguageButton_Click;
            // 
            // AddNewLanguage
            // 
            AddNewLanguage.AutoSize = true;
            AddNewLanguage.Location = new Point(386, 97);
            AddNewLanguage.Name = "AddNewLanguage";
            AddNewLanguage.RightToLeft = RightToLeft.Yes;
            AddNewLanguage.Size = new Size(172, 20);
            AddNewLanguage.TabIndex = 3;
            AddNewLanguage.Text = "Add a Missing Language";
            // 
            // Data
            // 
            Data.FormattingEnabled = true;
            Data.Location = new Point(12, 197);
            Data.Name = "Data";
            Data.Size = new Size(426, 224);
            Data.TabIndex = 4;
            Data.Tag = "";
            Data.SelectedIndexChanged += Data_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 5;
            label1.Text = "Select Language";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 6;
            label2.Text = "Your Selected Language :-";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 24);
            label3.Name = "label3";
            label3.Size = new Size(399, 42);
            label3.TabIndex = 7;
            label3.Text = "My First Windows APP";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Data);
            Controls.Add(AddNewLanguage);
            Controls.Add(AddButton);
            Controls.Add(TextBox);
            Controls.Add(LanguageSelector);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LanguageSelector;
        private TextBox TextBox;
        private Button AddButton;
        private Label AddNewLanguage;
        private ListBox Data;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
