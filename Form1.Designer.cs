namespace Parsers
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
            textCommands = new TextBox();
            label1 = new Label();
            comboActs = new ComboBox();
            textValueCmd = new TextBox();
            label2 = new Label();
            buttonaAddCmd = new Button();
            buttonSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            comboItems = new ComboBox();
            label3 = new Label();
            textBoxHash = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            this.SuspendLayout();
            // 
            // textCommands
            // 
            textCommands.Location = new Point(12, 112);
            textCommands.Multiline = true;
            textCommands.Name = "textCommands";
            textCommands.Size = new Size(543, 253);
            textCommands.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Команды:";
            // 
            // comboActs
            // 
            comboActs.FormattingEnabled = true;
            comboActs.Location = new Point(12, 371);
            comboActs.Name = "comboActs";
            comboActs.Size = new Size(110, 23);
            comboActs.TabIndex = 2;
            comboActs.Text = "Выбор";
            comboActs.SelectedIndexChanged += this.comboActs_SelectedIndexChanged;
            // 
            // textValueCmd
            // 
            textValueCmd.Location = new Point(186, 371);
            textValueCmd.Name = "textValueCmd";
            textValueCmd.Size = new Size(369, 23);
            textValueCmd.TabIndex = 3;
            textValueCmd.DoubleClick += this.textValueCmd_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 374);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Ссылка:";
            // 
            // buttonaAddCmd
            // 
            buttonaAddCmd.Location = new Point(561, 371);
            buttonaAddCmd.Name = "buttonaAddCmd";
            buttonaAddCmd.Size = new Size(227, 23);
            buttonaAddCmd.TabIndex = 5;
            buttonaAddCmd.Text = "Добавить";
            buttonaAddCmd.UseVisualStyleBackColor = true;
            buttonaAddCmd.Click += this.buttonaAddCmd_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 400);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(227, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += this.buttonSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(561, 112);
            button1.Name = "button1";
            button1.Size = new Size(227, 23);
            button1.TabIndex = 7;
            button1.Text = "Выбрать папку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // comboItems
            // 
            comboItems.FormattingEnabled = true;
            comboItems.Location = new Point(12, 27);
            comboItems.Name = "comboItems";
            comboItems.Size = new Size(212, 23);
            comboItems.TabIndex = 8;
            comboItems.Text = "Выбор";
            comboItems.SelectedIndexChanged += this.comboItems_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Товар:";
            // 
            // textBoxHash
            // 
            textBoxHash.Location = new Point(381, 27);
            textBoxHash.Name = "textBoxHash";
            textBoxHash.Size = new Size(407, 23);
            textBoxHash.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 9);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 11;
            label4.Text = "Хэш Товара:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 9);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 12;
            label5.Text = "Платформа:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(230, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Выбор";
            comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(comboBox1);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(textBoxHash);
            this.Controls.Add(label3);
            this.Controls.Add(comboItems);
            this.Controls.Add(button1);
            this.Controls.Add(buttonSave);
            this.Controls.Add(buttonaAddCmd);
            this.Controls.Add(label2);
            this.Controls.Add(textValueCmd);
            this.Controls.Add(comboActs);
            this.Controls.Add(label1);
            this.Controls.Add(textCommands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textCommands;
        private Label label1;
        private ComboBox comboActs;
        private TextBox textValueCmd;
        private Label label2;
        private Button buttonaAddCmd;
        private Button buttonSave;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private ComboBox comboItems;
        private Label label3;
        private TextBox textBoxHash;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
    }
}