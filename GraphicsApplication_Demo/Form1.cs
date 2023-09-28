using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicsApplication_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RandNum;

        public int One = 150;
        public int Two = 0;

        public int Three = 50;
        public int Four = 0;

        public int Five = 50;
        public int Six = 100;

        public int Seven = 150;
        public int Eight = 100;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.NavajoWhite);
            Pen GreyPen = new Pen(Color.SlateGray);
            Pen CirclePen = new Pen(Color.NavajoWhite);
            Pen StarPen = new Pen(Color.Yellow);
            Pen RedPen = new Pen(Color.SkyBlue);
            Pen myPenBlue = new Pen(Color.AntiqueWhite);
            Brush myBrush = new SolidBrush(Color.MediumSlateBlue);
            Brush TitleBrush = new SolidBrush(Color.LawnGreen);
            Brush TitleBrush2 = new SolidBrush(Color.LightGreen);
            Brush TitleBrush3 = new SolidBrush(Color.LimeGreen);
            Brush TitleBrushSelected = new SolidBrush(Color.LavenderBlush);

            Brush blackBrush = new SolidBrush(Color.Black);

            int Num;
            Point P1 = new Point();
            Point P2 = new Point();

            Point point1 = new Point(1, 1);
            Point point2 = new Point(80, 1);
            Point point3 = new Point(1, 80);
            Point[] curvePoints =
            {
                 point1,
                 point2,
                 point3 
            };
           
            Point point4 = new Point(0, 600);
            Point point5 = new Point(40, 900);
            Point point6 = new Point(500, 250);
            Point point7 = new Point(0, 200);
            Point point8 = new Point(0, 450);
            Point point9 = new Point(0, 1000);
            Point[] HexagonPoints =
            {
                 point4,
                 point5,
                 point6,
                 point7,
                 point8,
                 point9
            };

            //LINE
            //g.DrawLine(myPen, P1, P2);
            //g.DrawLine(myPen, new Point(2, 2), new Point(400, 800));

            //RECTANGLE

            g.FillRectangle(blackBrush, 0, 0, 1920, 1080);

            //CHANGE LINE STYLE
            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            //ELLIPSE
            
            CirclePen.Width = 3;
            g.DrawEllipse(CirclePen, 460, 0, 208, 182);
           

            //ARC
            //g.DrawArc(myPen, 150, 0, 100, 100, 90, 90);
            //g.DrawArc(myPen, 50, 0, 100, 100, 90, -90);
            //g.DrawArc(myPen, 50, 100, 100, 100, -90, 90);
            //g.DrawArc(myPen, 150, 100, 100, 100, -90, -90);

            //PIE
            g.DrawPie(RedPen, 475, 325, 100, 100, 135, 90);
            g.DrawPie(RedPen, 465, 325, 100, 100, 135, 90);


            //TEXT DRAWN
            string Start = "START";
            Font font = new Font("Arial", 18);
            g.DrawString(Start, font, myBrush, new Point(570, 265));

            string Save = "LOAD A GAME";
            g.DrawString(Save, font, TitleBrushSelected, new Point(548, 362));

            string Exit = "EXIT";
            g.DrawString(Exit, font, myBrush, new Point(585, 465));

            string Title = "A SPACE GAME";
            Font font4 = new Font("Impact", 50);
            g.DrawString(Title, font4, TitleBrush, new Point(380, 50));
            g.DrawString(Title, font4, TitleBrush2, new Point(385, 45));
            g.DrawString(Title, font4, TitleBrush3, new Point(390, 40));
        

            g.DrawRectangle(StarPen, 550, 250, 125, 50);
            g.DrawRectangle(StarPen, 540, 260, 125, 50);

            g.DrawRectangle(StarPen, 545, 345, 185, 55);
            g.DrawRectangle(StarPen, 535, 355, 185, 55);

            g.DrawRectangle(StarPen, 550, 450, 125, 50);
            g.DrawRectangle(StarPen, 540, 460, 125, 50);

            g.DrawPolygon(StarPen, curvePoints);
            g.DrawPolygon(GreyPen, HexagonPoints);

            DrawStar1();
            DrawStar2();
            DrawStar3();
            DrawStar4();
            DrawStar5();
            DrawStar6();
            DrawStar7();
          

            g.FillEllipse(myBrush, 800, 0, 800, 800);
   

         

            g.DrawArc(RedPen, 803, 88, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 90, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 92, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 94, 1000, 500, 90, 90);
            g.DrawArc(RedPen    , 803, 96, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 100, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 98, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 102, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 104, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 106, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 108, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 110, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 112, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 114, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 116, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 118, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 120, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 122, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 124, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 126, 1000, 500, 90, 90);
            g.DrawArc(RedPen, 803, 128, 1000, 500, 90, 90);


            void DrawStar1()
            {
                g.DrawArc(myPen, 150, 0, 100, 100, 90, 90);
                g.DrawArc(myPen, 50,0, 100, 100, 90, -90);
                g.DrawArc(myPen, 50, 100, 100, 100, -90, 90);
                g.DrawArc(myPen, 150,100, 100, 100, -90, -90);
            }

            void DrawStar2()
            {
                g.DrawArc(myPen, 250, 100, 100, 100, 90, 90);
                g.DrawArc(myPen, 150, 100, 100, 100, 90, -90);
                g.DrawArc(myPen, 150, 200, 100, 100, -90, 90);
                g.DrawArc(myPen, 250, 200, 100, 100, -90, -90);
            }
            void DrawStar3()
            {
                g.DrawArc(myPen, 375, 225, 100, 100, 90, 90);
                g.DrawArc(myPen, 275, 225, 100, 100, 90, -90);
                g.DrawArc(myPen, 275, 325, 100, 100, -90, 90);
                g.DrawArc(myPen, 375, 325, 100, 100, -90, -90);
            }
            void DrawStar4()
            {
                g.DrawArc(myPen, 375, 225, 100, 100, 90, 90);
                g.DrawArc(myPen, 275, 225, 100, 100, 90, -90);
                g.DrawArc(myPen, 275, 325, 100, 100, -90, 90);
                g.DrawArc(myPen, 375, 325, 100, 100, -90, -90);
            }

            void DrawStar5()
            {
                g.DrawArc(myPen, 350, 350, 100, 100, 90, 90);
                g.DrawArc(myPen, 250, 350, 100, 100, 90, -90);
                g.DrawArc(myPen, 250, 450, 100, 100, -90, 90);
                g.DrawArc(myPen, 350, 450, 100, 100, -90, -90);
            }

            void DrawStar6()
            {
                g.DrawArc(myPen, 150, 300, 100, 100, 90, 90);
                g.DrawArc(myPen, 50, 300, 100, 100, 90, -90);
                g.DrawArc(myPen, 50, 400, 100, 100, -90, 90);
                g.DrawArc(myPen, 150, 400, 100, 100, -90, -90);
            }

            void DrawStar7()
            {
                g.DrawArc(myPen, 25, 225, 100, 100, 90, 90);
                g.DrawArc(myPen, -75, 225, 100, 100, 90, -90);
                g.DrawArc(myPen, -75, 325, 100, 100, -90, 90);
                g.DrawArc(myPen, 25, 325, 100, 100, -90, -90);
            }


           

        }
    }
}
