namespace Ковер_Серпинского
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fractPicture = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.ABox_x = new System.Windows.Forms.TextBox();
            this.BBox_x = new System.Windows.Forms.TextBox();
            this.CBox_x = new System.Windows.Forms.TextBox();
            this.DBox_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ABox_y = new System.Windows.Forms.TextBox();
            this.BBox_y = new System.Windows.Forms.TextBox();
            this.CBox_y = new System.Windows.Forms.TextBox();
            this.DBox_y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fractPicture
            // 
            this.fractPicture.AccumBits = ((byte)(0));
            this.fractPicture.AutoCheckErrors = false;
            this.fractPicture.AutoFinish = false;
            this.fractPicture.AutoMakeCurrent = true;
            this.fractPicture.AutoSwapBuffers = true;
            this.fractPicture.BackColor = System.Drawing.Color.White;
            this.fractPicture.ColorBits = ((byte)(32));
            this.fractPicture.DepthBits = ((byte)(16));
            this.fractPicture.Location = new System.Drawing.Point(12, 12);
            this.fractPicture.Name = "fractPicture";
            this.fractPicture.Size = new System.Drawing.Size(500, 500);
            this.fractPicture.StencilBits = ((byte)(0));
            this.fractPicture.TabIndex = 0;
            // 
            // ABox_x
            // 
            this.ABox_x.Location = new System.Drawing.Point(560, 18);
            this.ABox_x.Name = "ABox_x";
            this.ABox_x.Size = new System.Drawing.Size(43, 20);
            this.ABox_x.TabIndex = 1;
            this.ABox_x.Text = "0";
            // 
            // BBox_x
            // 
            this.BBox_x.Location = new System.Drawing.Point(560, 44);
            this.BBox_x.Name = "BBox_x";
            this.BBox_x.Size = new System.Drawing.Size(43, 20);
            this.BBox_x.TabIndex = 2;
            this.BBox_x.Text = "2";
            // 
            // CBox_x
            // 
            this.CBox_x.Location = new System.Drawing.Point(560, 70);
            this.CBox_x.Name = "CBox_x";
            this.CBox_x.Size = new System.Drawing.Size(43, 20);
            this.CBox_x.TabIndex = 3;
            this.CBox_x.Text = "2";
            // 
            // DBox_x
            // 
            this.DBox_x.Location = new System.Drawing.Point(560, 96);
            this.DBox_x.Name = "DBox_x";
            this.DBox_x.Size = new System.Drawing.Size(43, 20);
            this.DBox_x.TabIndex = 4;
            this.DBox_x.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "D";
            // 
            // ABox_y
            // 
            this.ABox_y.Location = new System.Drawing.Point(609, 18);
            this.ABox_y.Name = "ABox_y";
            this.ABox_y.Size = new System.Drawing.Size(43, 20);
            this.ABox_y.TabIndex = 9;
            this.ABox_y.Text = "0";
            // 
            // BBox_y
            // 
            this.BBox_y.Location = new System.Drawing.Point(609, 44);
            this.BBox_y.Name = "BBox_y";
            this.BBox_y.Size = new System.Drawing.Size(43, 20);
            this.BBox_y.TabIndex = 10;
            this.BBox_y.Text = "0";
            // 
            // CBox_y
            // 
            this.CBox_y.Location = new System.Drawing.Point(609, 70);
            this.CBox_y.Name = "CBox_y";
            this.CBox_y.Size = new System.Drawing.Size(43, 20);
            this.CBox_y.TabIndex = 11;
            this.CBox_y.Text = "2";
            // 
            // DBox_y
            // 
            this.DBox_y.Location = new System.Drawing.Point(609, 96);
            this.DBox_y.Name = "DBox_y";
            this.DBox_y.Size = new System.Drawing.Size(43, 20);
            this.DBox_y.TabIndex = 12;
            this.DBox_y.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "n";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(559, 141);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(43, 20);
            this.nBox.TabIndex = 14;
            this.nBox.Text = "4";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(543, 241);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(96, 42);
            this.start_button.TabIndex = 15;
            this.start_button.Text = "Нарисовать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(681, 156);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(32, 28);
            this.up.TabIndex = 17;
            this.up.Text = "up";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.button1_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(681, 224);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(32, 28);
            this.down.TabIndex = 18;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(650, 190);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(32, 28);
            this.left.TabIndex = 19;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(710, 190);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(32, 28);
            this.right.TabIndex = 20;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(732, 12);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(76, 71);
            this.Save_button.TabIndex = 23;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(778, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "do not тыкать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 529);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBox_y);
            this.Controls.Add(this.CBox_y);
            this.Controls.Add(this.BBox_y);
            this.Controls.Add(this.ABox_y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBox_x);
            this.Controls.Add(this.CBox_x);
            this.Controls.Add(this.BBox_x);
            this.Controls.Add(this.ABox_x);
            this.Controls.Add(this.fractPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl fractPicture;
        private System.Windows.Forms.TextBox ABox_x;
        private System.Windows.Forms.TextBox BBox_x;
        private System.Windows.Forms.TextBox CBox_x;
        private System.Windows.Forms.TextBox DBox_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ABox_y;
        private System.Windows.Forms.TextBox BBox_y;
        private System.Windows.Forms.TextBox CBox_y;
        private System.Windows.Forms.TextBox DBox_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

