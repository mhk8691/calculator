namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            plus = new Button();
            multiplication = new Button();
            Division = new Button();
            minus = new Button();
            button2 = new Button();
            cleartext = new Button();
            factorial = new Button();
            label1 = new Label();
            darkmodebutton = new Button();
            buton0 = new Button();
            backspace = new Button();
            negativ = new Button();
            ashar = new Button();
            history = new Label();
            pow2 = new Button();
            baghimande = new Button();
            equal = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 349);
            button1.Name = "button1";
            button1.Size = new Size(79, 47);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttoncalculator1;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(182, 349);
            button3.Name = "button3";
            button3.Size = new Size(79, 47);
            button3.TabIndex = 1;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttoncalculator1;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(97, 243);
            button8.Name = "button8";
            button8.Size = new Size(79, 47);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttoncalculator1;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(182, 243);
            button9.Name = "button9";
            button9.Size = new Size(79, 47);
            button9.TabIndex = 5;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttoncalculator1;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(12, 243);
            button7.Name = "button7";
            button7.Size = new Size(79, 47);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttoncalculator1;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(97, 296);
            button5.Name = "button5";
            button5.Size = new Size(79, 47);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttoncalculator1;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(182, 296);
            button6.Name = "button6";
            button6.Size = new Size(79, 47);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttoncalculator1;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(12, 296);
            button4.Name = "button4";
            button4.Size = new Size(79, 47);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttoncalculator1;
            // 
            // plus
            // 
            plus.BackColor = Color.White;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            plus.ForeColor = Color.Black;
            plus.Location = new Point(267, 349);
            plus.Name = "plus";
            plus.RightToLeft = RightToLeft.No;
            plus.Size = new Size(79, 47);
            plus.TabIndex = 12;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += handleOpt;
            // 
            // multiplication
            // 
            multiplication.BackColor = Color.White;
            multiplication.FlatStyle = FlatStyle.Flat;
            multiplication.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            multiplication.ForeColor = Color.Black;
            multiplication.Location = new Point(267, 243);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(79, 47);
            multiplication.TabIndex = 13;
            multiplication.Text = "×";
            multiplication.UseVisualStyleBackColor = false;
            multiplication.Click += handleOpt;
            // 
            // Division
            // 
            Division.BackColor = Color.White;
            Division.FlatStyle = FlatStyle.Flat;
            Division.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Division.ForeColor = Color.Black;
            Division.Location = new Point(267, 190);
            Division.Name = "Division";
            Division.Size = new Size(79, 47);
            Division.TabIndex = 14;
            Division.Text = "÷";
            Division.UseVisualStyleBackColor = false;
            Division.Click += handleOpt;
            // 
            // minus
            // 
            minus.BackColor = Color.White;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            minus.ForeColor = Color.Black;
            minus.Location = new Point(267, 296);
            minus.Name = "minus";
            minus.Size = new Size(79, 47);
            minus.TabIndex = 15;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += handleOpt;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(97, 349);
            button2.Name = "button2";
            button2.Size = new Size(79, 47);
            button2.TabIndex = 18;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttoncalculator1;
            // 
            // cleartext
            // 
            cleartext.BackColor = Color.White;
            cleartext.FlatStyle = FlatStyle.Flat;
            cleartext.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cleartext.ForeColor = Color.Black;
            cleartext.Location = new Point(182, 137);
            cleartext.Name = "cleartext";
            cleartext.Size = new Size(79, 47);
            cleartext.TabIndex = 19;
            cleartext.Text = "C";
            cleartext.UseVisualStyleBackColor = false;
            cleartext.Click += clear;
            // 
            // factorial
            // 
            factorial.BackColor = Color.White;
            factorial.FlatStyle = FlatStyle.Flat;
            factorial.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            factorial.ForeColor = Color.Black;
            factorial.Location = new Point(12, 190);
            factorial.Name = "factorial";
            factorial.Size = new Size(79, 47);
            factorial.TabIndex = 20;
            factorial.Text = "F";
            factorial.UseVisualStyleBackColor = false;
            factorial.Click += factorial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(10, 55);
            label1.Name = "label1";
            label1.Size = new Size(0, 45);
            label1.TabIndex = 21;
            // 
            // darkmodebutton
            // 
            darkmodebutton.BackColor = Color.White;
            darkmodebutton.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            darkmodebutton.ForeColor = Color.Black;
            darkmodebutton.Location = new Point(261, 12);
            darkmodebutton.Name = "darkmodebutton";
            darkmodebutton.Size = new Size(85, 38);
            darkmodebutton.TabIndex = 22;
            darkmodebutton.Text = "Dark";
            darkmodebutton.UseVisualStyleBackColor = false;
            darkmodebutton.Click += DarkmodeClick;
            // 
            // buton0
            // 
            buton0.BackColor = Color.White;
            buton0.FlatStyle = FlatStyle.Flat;
            buton0.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buton0.ForeColor = Color.Black;
            buton0.Location = new Point(97, 402);
            buton0.Name = "buton0";
            buton0.Size = new Size(79, 46);
            buton0.TabIndex = 23;
            buton0.Text = "0";
            buton0.UseVisualStyleBackColor = false;
            buton0.Click += buttoncalculator1;
            // 
            // backspace
            // 
            backspace.BackColor = Color.White;
            backspace.FlatStyle = FlatStyle.Flat;
            backspace.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            backspace.ForeColor = Color.Black;
            backspace.Location = new Point(267, 137);
            backspace.Name = "backspace";
            backspace.Size = new Size(79, 47);
            backspace.TabIndex = 24;
            backspace.Text = "⌫ ";
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += Removelastnumber;
            // 
            // negativ
            // 
            negativ.BackColor = Color.White;
            negativ.FlatStyle = FlatStyle.Flat;
            negativ.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            negativ.ForeColor = Color.Black;
            negativ.Location = new Point(12, 402);
            negativ.Name = "negativ";
            negativ.Size = new Size(79, 46);
            negativ.TabIndex = 25;
            negativ.Text = "+/-";
            negativ.UseVisualStyleBackColor = false;
            negativ.Click += negative;
            // 
            // ashar
            // 
            ashar.BackColor = Color.White;
            ashar.FlatStyle = FlatStyle.Flat;
            ashar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ashar.ForeColor = Color.Black;
            ashar.Location = new Point(182, 402);
            ashar.Name = "ashar";
            ashar.Size = new Size(79, 46);
            ashar.TabIndex = 26;
            ashar.Text = "/";
            ashar.UseVisualStyleBackColor = false;
            ashar.Click += int_to_double;
            // 
            // history
            // 
            history.AutoSize = true;
            history.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            history.Location = new Point(12, 30);
            history.Name = "history";
            history.Size = new Size(0, 20);
            history.TabIndex = 27;
            history.Visible = false;
            // 
            // pow2
            // 
            pow2.BackColor = Color.White;
            pow2.FlatStyle = FlatStyle.Flat;
            pow2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pow2.ForeColor = Color.Black;
            pow2.Location = new Point(97, 190);
            pow2.Name = "pow2";
            pow2.Size = new Size(79, 47);
            pow2.TabIndex = 28;
            pow2.Text = "x²";
            pow2.UseVisualStyleBackColor = false;
            pow2.Click += pow2_Click;
            // 
            // baghimande
            // 
            baghimande.BackColor = Color.White;
            baghimande.FlatStyle = FlatStyle.Flat;
            baghimande.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            baghimande.ForeColor = Color.Black;
            baghimande.Location = new Point(182, 190);
            baghimande.Name = "baghimande";
            baghimande.Size = new Size(79, 47);
            baghimande.TabIndex = 29;
            baghimande.Text = "%";
            baghimande.UseVisualStyleBackColor = false;
            baghimande.Click += handleOpt;
            // 
            // equal
            // 
            equal.BackColor = Color.White;
            equal.FlatStyle = FlatStyle.Flat;
            equal.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            equal.ForeColor = Color.Black;
            equal.Location = new Point(267, 402);
            equal.Name = "equal";
            equal.Size = new Size(79, 46);
            equal.TabIndex = 30;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 218, 218);
            ClientSize = new Size(364, 459);
            Controls.Add(equal);
            Controls.Add(baghimande);
            Controls.Add(pow2);
            Controls.Add(history);
            Controls.Add(ashar);
            Controls.Add(negativ);
            Controls.Add(backspace);
            Controls.Add(buton0);
            Controls.Add(darkmodebutton);
            Controls.Add(label1);
            Controls.Add(factorial);
            Controls.Add(cleartext);
            Controls.Add(button2);
            Controls.Add(minus);
            Controls.Add(Division);
            Controls.Add(multiplication);
            Controls.Add(plus);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator ";
            KeyDown += keydown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button8;
        private Button button9;
        private Button button7;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button plus;
        private Button multiplication;
        private Button Division;
        private Button minus;
        private Button button2;
        private Button cleartext;
        private Button factorial;
        private Label label1;
        private Button darkmodebutton;
        private Button button1;
        private Button button0;

        private Button buttoncalculator;
        private Button buton0;
        private Button backspace;
        private Button negativ;
        private Button ashar;
        private Label history;
        private Button pow2;
        private Button baghimande;
        private Button equal;
    }
}