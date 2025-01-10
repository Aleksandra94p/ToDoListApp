namespace ToDoListApp
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(574, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(361, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(31, 120);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(484, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(574, 120);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(361, 170);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(427, 259);
            listBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 6;
            label1.Text = "Unesi novi zadatak";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 152);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 7;
            label2.Text = "Lista zadatka za odabran datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 85);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 8;
            label3.Text = "Odaberi prioritet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
