namespace PracownicyMVP.View
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
			panel1 = new Panel();
			label6 = new Label();
			label7 = new Label();
			label5 = new Label();
			radioButton3 = new RadioButton();
			label4 = new Label();
			radioButton1 = new RadioButton();
			label1 = new Label();
			button1 = new Button();
			label3 = new Label();
			radioButton2 = new RadioButton();
			label2 = new Label();
			comboBox1 = new ComboBox();
			numericUpDown1 = new NumericUpDown();
			dateTimePicker1 = new DateTimePicker();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button3 = new Button();
			button2 = new Button();
			listBox1 = new ListBox();
			saveFileDialog1 = new SaveFileDialog();
			openFileDialog1 = new OpenFileDialog();
			button4 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(radioButton3);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(radioButton1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(radioButton2);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(comboBox1);
			panel1.Controls.Add(numericUpDown1);
			panel1.Controls.Add(dateTimePicker1);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(textBox2);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(357, 283);
			panel1.TabIndex = 0;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(4, 188);
			label6.Name = "label6";
			label6.Size = new Size(88, 15);
			label6.TabIndex = 10;
			label6.Text = "Rodzaj umowy:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(4, 74);
			label7.Name = "label7";
			label7.Size = new Size(89, 15);
			label7.TabIndex = 11;
			label7.Text = "Data urodzenia:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 135);
			label5.Name = "label5";
			label5.Size = new Size(70, 15);
			label5.TabIndex = 9;
			label5.Text = "Stanowisko:";
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(179, 211);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(111, 19);
			radioButton3.TabIndex = 2;
			radioButton3.TabStop = true;
			radioButton3.Text = "Umowa zlecenie";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(4, 105);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 8;
			label4.Text = "Pensja";
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(179, 161);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(177, 19);
			radioButton1.TabIndex = 1;
			radioButton1.TabStop = true;
			radioButton1.Text = "Umowa na czas nieokreślony";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(129, 2);
			label1.Name = "label1";
			label1.Size = new Size(98, 15);
			label1.TabIndex = 5;
			label1.Text = "Dane pracownika";
			// 
			// button1
			// 
			button1.Location = new Point(129, 238);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Dodaj";
			button1.UseVisualStyleBackColor = true;
			button1.Click += addPerson;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(4, 48);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 7;
			label3.Text = "Nazwisko:";
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(179, 186);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(161, 19);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "Umowa na czas określony";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(4, 19);
			label2.Name = "label2";
			label2.Size = new Size(33, 15);
			label2.TabIndex = 6;
			label2.Text = "Imie:";
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Inżynier", "Młodszy Programista", "Projektant", "Starszy Programista", "Tester" });
			comboBox1.Location = new Point(231, 132);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 23);
			comboBox1.Sorted = true;
			comboBox1.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDown1.Location = new Point(231, 103);
			numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDown1.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(121, 23);
			numericUpDown1.TabIndex = 1;
			numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 0 });
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePicker1.CustomFormat = "dd.mm.yyyy";
			dateTimePicker1.Format = DateTimePickerFormat.Short;
			dateTimePicker1.ImeMode = ImeMode.Disable;
			dateTimePicker1.Location = new Point(231, 74);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(121, 23);
			dateTimePicker1.TabIndex = 3;
			dateTimePicker1.Value = new DateTime(2023, 3, 31, 0, 0, 0, 0);
			// 
			// textBox1
			// 
			textBox1.Location = new Point(231, 16);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(121, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(231, 45);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(121, 23);
			textBox2.TabIndex = 2;
			// 
			// button3
			// 
			button3.Location = new Point(290, 301);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 3;
			button3.Text = "Wczytaj";
			button3.UseVisualStyleBackColor = true;
			button3.Click += deserialize_list;
			// 
			// button2
			// 
			button2.Location = new Point(12, 301);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "Zapisz";
			button2.UseVisualStyleBackColor = true;
			button2.Click += serialize_list;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(375, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(413, 289);
			listBox1.TabIndex = 4;
			listBox1.SelectedIndexChanged += SelectEmployeeFromListBox;
			// 
			// button4
			// 
			button4.Location = new Point(142, 301);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 12;
			button4.Text = "Reset";
			button4.UseVisualStyleBackColor = true;
			button4.Click += reset;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 334);
			Controls.Add(button4);
			Controls.Add(listBox1);
			Controls.Add(button3);
			Controls.Add(panel1);
			Controls.Add(button2);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button button3;
		public RadioButton radioButton3;
		private Button button2;
		public RadioButton radioButton1;
		private Button button1;
		public RadioButton radioButton2;
		public ComboBox comboBox1;
		public NumericUpDown numericUpDown1;
		public DateTimePicker dateTimePicker1;
		public TextBox textBox1;
		public TextBox textBox2;
		private Label label6;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label1;
		private Label label3;
		private Label label2;
		private ListBox listBox1;
		private SaveFileDialog saveFileDialog1;
		private OpenFileDialog openFileDialog1;
		private Button button4;
	}
}