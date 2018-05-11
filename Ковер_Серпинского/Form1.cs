using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Ковер_Серпинского
{
    public partial class Form1 : Form
    {
        #region Вспомогательные классы
        public class Pair
        {
            public double x { set; get; }
            public double y { set; get; }
            public Pair()
            {
            }
            public Pair(double x, double y)
            {
                this.y = y;
                this.x = x;
            }
        }
        public class fAngle
        {
            public Pair A { set; get; }
            public Pair B { set; get; }
            public Pair C { set; get; }
            public Pair D { set; get; }
            public int n;
            public fAngle()
            {

            }
            public fAngle(Pair _A, Pair _B, Pair _C, Pair _D)
            {
                A = _A;
                B = _B;
                C = _C;
                D = _D;
            }
        }
        public class Line
        {
            public double x, y;
            public Pair A, B;
            public Line()
            {

            }
            public Line (Pair _A, Pair _B)
            {
                A = _A;
                B = _B;
                x = B.x - A.x;
                y = B.y - A.y;
            }
            public double dlina()
            {
                return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            }
        }
        #endregion
        #region Глобальные переменные
        Random rnd = new Random();
        bool error = false;
        //Pair[] ABCD;
        ArrayList mass = new ArrayList();
        List<double> epilepsR; 
        List<double> epilepsG; 
        List<double> epilepsB; 
        
        int n = 5;
        double zoom = 0.5, a = -1, b = -1;
        Pair startA, startB, startC, startD;
        bool isCalc = false;
        bool epilepsia = false;
        #endregion
        public Form1()
        {
            InitializeComponent();
            fractPicture.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, 1000, 1000);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0, (float)(fractPicture.Width), 0, (float)(fractPicture.Height));
            Gl.glLoadIdentity();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            fractPicture.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw_fract();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            b -= 0.02;
        }

        private void left_Click(object sender, EventArgs e)
        {
            a += 0.02;
        }

        private void right_Click(object sender, EventArgs e)
        {
            a -= 0.02;
        }

        private void down_Click(object sender, EventArgs e)
        {
            b += 0.02;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            zoom += 0.05;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoom -= 0.05;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCalc) throw new Exception("Not calculated");
                timer1.Enabled = false;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();
                Bitmap image = new Bitmap(500, 500);
                BitmapData imgData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                Gl.glPushClientAttrib(Gl.GL_CLIENT_PIXEL_STORE_BIT);
                Gl.glPixelStoref(Gl.GL_PACK_ALIGNMENT, 4);

                Gl.glReadPixels(0, 0, image.Width, image.Height, Gl.GL_BGRA, Gl.GL_UNSIGNED_BYTE, imgData.Scan0);
                Gl.glPopClientAttrib();
                image.RotateFlip(RotateFlipType.Rotate180FlipX);
                image.Save(saveFileDialog1.FileName);
                timer1.Enabled = true;
            }
            catch (Exception a)
            {
               //Добавить вывод ошибки
                if (isCalc == true) timer1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            epilepsia = !epilepsia;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zoom = 0.5;
            a = -1;
            b = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void swap(ref Pair first, ref Pair second)
        {
            var temp = new Pair(first.x, first.y);
            first.x = second.x;
            first.y = second.y;
            second.x = temp.x;
            second.y = temp.y;
        }

        private void calc(Pair A, Pair B, Pair C, Pair D, int n)
        {
            isCalc = true;
            if (error)
                return;
            if (n <= 0)
                return;
            //TODO: Добавить функцию которая будет располагать точки в правильной последовательности

            #region Основные линии
            Line AB = new Line(A, B);
            Line BC = new Line(B, C);
            Line CD = new Line(C, D);
            Line DA = new Line(D, A);
            #endregion
            #region Доп точки
            var A1 = new Pair(A.x + AB.x / 3, A.y + AB.y / 3);  // A + AB/3
            var A2 = new Pair(A.x - DA.x / 3, A.y - DA.y / 3);  // A - DA/3

            var B1 = new Pair(B.x - AB.x / 3, B.y - AB.y / 3);  // B - AB/3
            var B2 = new Pair(B.x + BC.x / 3, B.y + BC.y / 3);  // B + BC/3

            var C1 = new Pair(C.x - BC.x / 3, C.y - BC.y / 3);  // C - BC/3
            var C2 = new Pair(C.x + CD.x / 3, C.y + CD.y / 3);  // C + CD/3

            var D1 = new Pair(D.x + DA.x / 3, D.y + DA.y / 3);  // D + DA/3
            var D2 = new Pair(D.x - CD.x / 3, D.y - CD.y / 3);  // D - CD/3

            #endregion
            #region Доп линии
            var A2B2 = new Line(A2, B2);
            var D1C1 = new Line(D1, C1);
            var B1C2 = new Line(B1, C2);
            var A1D2 = new Line(A1, D2);

            #endregion


            var one = new Pair(B.x + (BC.x - A2B2.x) / 3, B.y + (BC.y - A2B2.y) / 3);
            var two = new Pair(C.x + (-BC.x - D1C1.x) / 3, C.y + (-BC.y - D1C1.y) / 3);
            var three = new Pair(A.x + (-DA.x + A2B2.x) / 3, A.y + (-DA.y + A2B2.y) / 3);
            var four = new Pair(D.x + (DA.x + D1C1.x) / 3, D.y + (DA.y + D1C1.y) / 3);

            //Добавление в массив четырехугольника который надо закрасить.
            var temp = new fAngle(one, two, four, three);
            temp.n = n;
            mass.Add(temp);
            

            #region Рекурсия
            //Вызов самой себя для оставшихся 8 четырехугольников
            calc(A, A1, three, A2, n - 1);      //Нижний левый
            calc(A1, B1, one, three, n - 1);    //Левый
            calc(B1, B, B2, one, n - 1);        //Верхний левый
            calc(one, B2, C1, two, n - 1);      //Верхний
            calc(two, C1, C, C2, n - 1);        //Верхний правый
            calc(four, two, C2, D2, n - 1);     //Правый
            calc(D1, four, D2, D, n - 1);       //Нижний правый
            calc(A2, three, four, D1, n - 1);   //Нижний
            #endregion
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                startA = new Pair(double.Parse(ABox_x.Text.Replace('.', ',')), double.Parse(ABox_y.Text.Replace('.', ',')));
                startB = new Pair(double.Parse(BBox_x.Text.Replace('.', ',')), double.Parse(BBox_y.Text.Replace('.', ',')));
                startC = new Pair(double.Parse(CBox_x.Text.Replace('.', ',')), double.Parse(CBox_y.Text.Replace('.', ',')));
                startD = new Pair(double.Parse(DBox_x.Text.Replace('.', ',')), double.Parse(DBox_y.Text.Replace('.', ',')));
                n = int.Parse(nBox.Text);

                epilepsR = new List<double>();
                epilepsG = new List<double>();
                epilepsB = new List<double>();
                for (int i = 0; i <= n; i++)
                {
                    epilepsR.Add(rnd.Next(0, 10000) / 10000.0);
                    epilepsG.Add(rnd.Next(0, 10000) / 10000.0);
                    epilepsB.Add(rnd.Next(0, 10000) / 10000.0);
                }
                error = false;
            }
            catch(Exception a)
            {
                error = true;
                errorProvider1.SetError(start_button, "Неверный формат ввода");
            }
            mass.Clear();
            calc(startA, startB, startC, startD, n);
            timer1.Enabled = true;
            Draw_fract();
        }

        private void Draw_fract()
        {
            if (error)
                return;
            //calc_fract();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glScaled(zoom, zoom, 0);
            Gl.glTranslated(a - 1, b - 1, 0);

            
            Gl.glBegin(Gl.GL_QUADS);
            //ниже стартовый четырехугольник
            Gl.glColor3d(0, 0, 0);
            Gl.glVertex2d(startA.x, startA.y);
            Gl.glVertex2d(startB.x, startB.y);
            Gl.glVertex2d(startC.x, startC.y);
            Gl.glVertex2d(startD.x, startD.y);
            //end

            Gl.glColor3d(1, 1, 1);
            int schet = 0;
            for (int i = 0; i < mass.Count; i++)
            {
                fAngle temp = (fAngle)mass[i];
                if (epilepsia)
                {
                    
                    Gl.glColor3d(rnd.Next(0, 10000) / 10000.0, rnd.Next(0, 10000) / 10000.0, rnd.Next(0, 10000) / 10000.0);
                }
                else
                {
                    Gl.glColor3d(epilepsR[temp.n], epilepsG[temp.n], epilepsB[temp.n]);
                }
                

                Gl.glVertex2d(temp.A.x, temp.A.y);
                Gl.glVertex2d(temp.B.x, temp.B.y);
                Gl.glVertex2d(temp.C.x, temp.C.y);
                Gl.glVertex2d(temp.D.x, temp.D.y);

                
            }
            Gl.glEnd();
            Gl.glPopMatrix();
            Gl.glFlush();
            fractPicture.Invalidate();
        }
    }
}
