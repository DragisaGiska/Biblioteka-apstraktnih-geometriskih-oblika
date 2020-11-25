using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using System.Timers;

namespace Biblioteka_geometrijskih_oblika
{
    public partial class Biblioteka_abstraktinih_geometrijskih_oblika : Form
    {
        string ime="";
        string ime1 = "";
      

        public Biblioteka_abstraktinih_geometrijskih_oblika()
        {
            InitializeComponent();
            //Postavljanje boje poyadine panela za crtanje
            panel1.BackColor = Color.White;
            
         
           
        }
       
      

       
        //Ubacivanje slike 1
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_1;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //crtanje okvira
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
            g.DrawImage(slika, rec, new Rectangle(8, 20, 145, 180), GraphicsUnit.Pixel);//isjecanje slika
           
            g.DrawRectangle(olovka, rec1);
            Slika_1.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
        }

        //Ubacivanje slike 2
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           Image slika = Properties.Resources.Geometriski_oblici_1;//Učitavanje slike
           Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
           
            g.DrawImage(slika, rec, new Rectangle(165, 20, 145, 180), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_2.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
        }

        //Ubacivanje slike 3
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_1;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
            g.DrawImage(slika, rec, new Rectangle(320, 20, 141, 180), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_3.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 4
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_1;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
            
             //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width-1, Slika_1.Height -1);
           
            g.DrawImage(slika, rec, new Rectangle(10, 180, 138, 180), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_4.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 5
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_1;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
           
            g.DrawImage(slika, rec, new Rectangle(162, 180, 148, 180), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_5.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 6
        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_1;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height );

            g.DrawImage(slika, rec, new Rectangle(320, 197, 140, 150), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
                
            Slika_6.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 7
        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_2;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
           
            g.DrawImage(slika, rec, new Rectangle(5, 15, 160, 155), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_7.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 8
        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_2;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
            
            g.DrawImage(slika, rec, new Rectangle(160, 5, 150, 180), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_8.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
        
        }

        //Ubacivanje slike 9
        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_2;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);
           
            g.DrawImage(slika, rec, new Rectangle(305, 5, 150, 170), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_9.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Crtanje slike 10
        private void pictureBox11_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_2;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width -1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Ubacivanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width - 1, Slika_1.Height - 1);

            g.DrawImage(slika, rec, new Rectangle(1, 170, 160, 150), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_10.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 11
        private void pictureBox12_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_2;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
           
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width -1, Slika_1.Height-1 );
            g.DrawRectangle(olovka, rec1);
            g.DrawImage(slika, rec, new Rectangle(160, 180, 150, 140), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_11.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       
        }

        //Ubacivanje slike 12
        private void pictureBox14_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image slika = Properties.Resources.Geometriski_oblici_2;//Učitavanje slike
            Rectangle rec = new Rectangle((Slika_1.Width - (Slika_1.Width - 1)), (Slika_1.Height - (Slika_1.Height - 1)), Slika_1.Width - 1, Slika_1.Height - 1);//Odredjivanje velicine 
            //Crtanje okvira oko slike
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle rec1 = new Rectangle(0, 0, Slika_1.Width-1, Slika_1.Height-1);
            
            g.DrawImage(slika, rec, new Rectangle(305, 170, 152, 155), GraphicsUnit.Pixel);//isjecanje slika
            g.DrawRectangle(olovka, rec1);
            Slika_12.SizeMode = PictureBoxSizeMode.StretchImage;//podesavanje promjene velicine prozora
       

        }


        //Ispisivanje imena slike prelaskom misa preko slike
        private void Slika_1_MouseHover(object sender, EventArgs e)
        {
            PictureBox dugmad = (PictureBox)sender;
            int visina = panel2.Height / 9;
            Graphics g = panel2.CreateGraphics();
            g.Clear(this.BackColor);
            Brush crnaCetka = new SolidBrush(Color.Black);
            FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            StringFormat format2 = new StringFormat();//Kreiramo novi objekat za Formatiranje teksta 
            format2.Alignment = StringAlignment.Center;//Postavimo horizontalno poravnjanje
            format2.LineAlignment = StringAlignment.Center;//Postavimo vertikalno poravnjanje

            Font font = new Font("Arial", (panel3.Height / 40 + panel3.Width / 40), stil, GraphicsUnit.Pixel);
            PointF tacka = new PointF(panel2.Width / 2, 3 * visina);
            g.DrawString("Biblioteka abstraktinih geometrijskih oblika", font, crnaCetka, tacka, format2);
            PointF tacka1 = new PointF(panel2.Width / 2, 6 * visina);

            if (dugmad.Name == "Slika_1")
            {

                g.DrawString("- Slika 1 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_2")
            {
                g.DrawString("- Slika 2 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_3")
            {
                g.DrawString("- Slika 3 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_4")
            {
                g.DrawString("- Slika 4 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_5")
            {
                g.DrawString("- Slika 5 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_6")
            {
                g.DrawString("- Slika 6 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_7")
            {
                g.DrawString("- Slika 7 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_8")
            {
                g.DrawString("- Slika 8 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_9")
            {
               g.DrawString("- Slika 9 -", font, crnaCetka, tacka1, format2);
            }
            else if (dugmad.Name == "Slika_10")
            {
                g.DrawString("- Slika 10 -", font, crnaCetka, tacka1, format2);
       
            }
            else if (dugmad.Name == "Slika_11")
            {
                g.DrawString("- Slika 11 -", font, crnaCetka, tacka1, format2);
       
            }
            else if (dugmad.Name == "Slika_12")
            {
                g.DrawString("- Slika 12 -", font, crnaCetka, tacka1, format2);
            }
        }


        //Sklanjanje misa sa slike
        private void Slika_1_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
            panel2.Invalidate();
            
        }
        
        //Panel sa imenom programa i informacijama o slici
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int visina = panel2.Height / 9;
            Graphics g = panel2.CreateGraphics();
            g.Clear(this.BackColor);
            Brush crnaCetka = new SolidBrush(Color.Black);
            FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            StringFormat format2 = new StringFormat();//Kreiramo novi objekat za Formatiranje teksta 
            format2.Alignment = StringAlignment.Center;//Postavimo horizontalno poravnjanje
            format2.LineAlignment = StringAlignment.Center;//Postavimo vertikalno poravnjanje
                
           

            if (ime1 == "on")
             {
                 PointF tacka = new PointF(panel2.Width / 2, 3 * visina);
                 PointF tacka1 = new PointF(panel2.Width / 2, 6 * visina);
                 Font font = new Font("Arial", (panel2.Height / 40 + panel2.Width / 40), stil, GraphicsUnit.Pixel);
                 g.DrawString("Biblioteka abstraktinih geometrijskih oblika", font, crnaCetka, tacka, format2);
                 g.DrawString("Sačekajte da se slika nacrta!!", font, crnaCetka, tacka1, format2);
             }
             else
             {
                 
                 PointF tacka = new PointF(panel2.Width / 2, 3 * visina);
                 PointF tacka1 = new PointF(panel2.Width / 2, 6 * visina);

                 Font font = new Font("Arial", (panel2.Height / 40 + panel2.Width / 40), stil, GraphicsUnit.Pixel);
           
                 g.DrawString("Biblioteka abstraktinih geometrijskih oblika", font, crnaCetka, tacka, format2);
                 g.DrawString("Klikom miša izaberite sliku koju želite nacrtati", font, crnaCetka, tacka1, format2);
             }
            
        }
       
        //Panel sa ikonicama za screenshot 
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel3.CreateGraphics();
           
            g.Clear(this.BackColor);
            int visina1 = panel3.Height / 4; //Podjelimo visina zbog centriranja
            Brush crnaCetka = new SolidBrush(Color.Black);
            FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            StringFormat format2 = new StringFormat();//Kreiramo novi objekat za Formatiranje teksta 
            format2.Alignment = StringAlignment.Center;//Postavimo horizontalno poravnjanje
            format2.LineAlignment = StringAlignment.Center;//Postavimo vertikalno poravnjanje
            Font font = new Font("Arial", (panel3.Height / 70 + panel3.Width/70), stil, GraphicsUnit.Pixel);
            PointF tacka = new PointF(panel3.Width/2, visina1*3);
           
            //Kreiranje ikonica za folder sa slikama i screenshot
            Image ikonica = Properties.Resources.Screenshot_icon_icons_com_55819;
            Image ikonica1 = Properties.Resources.iconfinder_icon_camera_211634;
            pictureBox1.Image = ikonica;
            pictureBox2.Image = ikonica1;
            pictureBox1.Location = new Point((4 * (panel3.Width / 16)), (1 * (panel3.Height / 10)));
            pictureBox2.Location = new Point((7 * (panel3.Width / 16) - pictureBox2.Width / 2), (1 * (panel3.Height / 10)));
           
             pictureBox1.Size = new Size((panel3.Width / 12), (panel3.Height / 4));
            pictureBox2.Size = new Size((panel3.Width / 12), (panel3.Height / 4));
             PointF tacka2 = new PointF(button3.Width / 2, button3.Height/2);
            float newSize = panel3.Height / 110 + panel3.Width / 110;
            g.Clear(this.BackColor);
            
             g.DrawString("Dragiša_Mitrović_1458_Biblioteka_apstraktnih_geometriskih oblika_Projekat_br.11_Računarska grafika", font, crnaCetka, tacka, format2);
           
           
        
        }


        //Ispisivanje teksta u dugme Gradual drawing
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = button1.CreateGraphics();
            Brush crnaCetka = new SolidBrush(Color.Black);
            FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            StringFormat format2 = new StringFormat();//Kreiramo novi objekat za Formatiranje teksta 
            format2.Alignment = StringAlignment.Center;//Postavimo horizontalno poravnjanje
            format2.LineAlignment = StringAlignment.Center;//Postavimo vertikalno poravnjanje
            Font font = new Font("Arial", (panel3.Height / 70 + panel3.Width / 70), stil, GraphicsUnit.Pixel);
            float newSize = panel3.Height / 110 + panel3.Width / 110;
            PointF tacka3 = new PointF(button1.Width / 2, button1.Height / 2);
            button1.Location = new Point((13 * (panel3.Width / 16) - button1.Width), (1 * (panel3.Height / 10)));
           
            button1.Size = new Size((panel3.Width / 8), (panel3.Height / 4));
           
            
            g1.DrawString("Gradual drawing", font, crnaCetka, tacka3, format2);
            button1.Font = new Font(button1.Font.FontFamily, newSize);
           
           
        }


        //Ispisivanje teksta u dugme slike
        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g3 = button3.CreateGraphics();
            Brush crnaCetka = new SolidBrush(Color.Black);
            FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            StringFormat format2 = new StringFormat();//Kreiramo novi objekat za Formatiranje teksta 
            format2.Alignment = StringAlignment.Center;//Postavimo horizontalno poravnjanje
            format2.LineAlignment = StringAlignment.Center;//Postavimo vertikalno poravnjanje
            Font font = new Font("Arial", (panel3.Height / 70 + panel3.Width / 70), stil, GraphicsUnit.Pixel);
            PointF tacka2 = new PointF(button3.Width / 2, button3.Height / 2);
            float newSize = panel3.Height / 110 + panel3.Width / 110;
            
            button3.Location = new Point((10 * (panel3.Width / 16) - button3.Width), (1 * (panel3.Height / 10)));
            button3.Size = new Size((panel3.Width / 12), (panel3.Height / 4));
            Font font1 = new Font("Arial", (panel3.Height / 120 + panel3.Width / 120), stil, GraphicsUnit.Pixel);
            g3.DrawString("Slike", font1, crnaCetka, tacka2, format2);
            button3.Font = new Font(button3.Font.FontFamily, newSize);
           
        }


        //Otvaranje foldera sa slikama
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.Filter = "pneg files|*.png";
            folderBrowser.InitialDirectory = @"../../Slike";
            folderBrowser.ShowDialog();
        }
        

        //Opis screenshot
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("Screenshot picture", pictureBox1);
        }

        //Opis foldera slike
        private void button3_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("Folder with Screenshots", button3);
        }

        //Opis sporog crtanja
        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("Gradual drawing a picture", button1);
        }
       
        //Opsi screenshot aplikacije
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("Screenshot aplication", pictureBox2);
        }


        //Screenshot slike
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            Graphics g =  panel1.CreateGraphics();    
            string time = DateTime.Now.ToString("HHmmss");
            string img = @"../../Slike/Slika_" + time + ".png";
            Bitmap bmpScreenshot = new Bitmap(panel1.Bounds.Width, panel1.Bounds.Height);
            g = Graphics.FromImage(bmpScreenshot);
            panel1.DrawToBitmap(bmpScreenshot, new Rectangle(panel1.Width - (panel1.Width - 1), panel1.Height - (panel1.Height - 1), panel1.Width, panel1.Height));
            bmpScreenshot.Save(img, ImageFormat.Png);
        }

        //Screenshot aplikacije
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            Graphics g = this.CreateGraphics();
            Rectangle bounds = this.Bounds;
            string time = DateTime.Now.ToString("HHmmss");
            string img = @"../../Slike/Cela_aplikacija_" + time + ".png";
            Bitmap bmpScreenshot = new Bitmap(bounds.Width, bounds.Height);
           g = Graphics.FromImage(bmpScreenshot);
          g.CopyFromScreen(new Point(bounds.Left , bounds.Top),Point.Empty, Bounds.Size);
          bmpScreenshot.Save(img, ImageFormat.Png);
        }


        //Dogadjaj klikom na sliku
        private void Slika_1_Click(object sender, EventArgs e)
        {
            PictureBox slike = (PictureBox)sender;
            ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            if (ime1 != "on")
            {
                ime = slike.Name;
            }
          
            
            button1.Enabled = true;
           
            
            panel1.Invalidate();

        }


        //Crtanje slika na panelu
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            Pen olovka = new Pen(Color.Black);
            olovka.Width = 0.4f;
            Rectangle okvir = new Rectangle(0, 0,  panel1.Width-1,  panel1.Height-1);


            if (ime == "Slika_1")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike(g);
               
            }
            else if (ime == "Slika_2")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike1(g);
            }

            else if (ime == "Slika_3")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike3(g);
            }
            else if (ime == "Slika_4")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike4(g);
            }
            else if (ime == "Slika_5")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike5(g);
            }
            else if (ime == "Slika_6")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike6(g);
            }
            else if (ime == "Slika_7")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike7(g);
            }
            else if (ime == "Slika_8")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike8(g);
            }
            else if (ime == "Slika_9")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike9(g);
            }
            else if (ime == "Slika_10")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike10(g);
            }
            else if (ime == "Slika_11")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike11(g);
            }
            else if (ime == "Slika_12")
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
                crtanjeslike12(g);
            }
            else
            {
                g.Clear(panel1.BackColor);
                g.DrawRectangle(olovka, okvir);
            }
           
        }

  
        //Promjena velicine panela
    private void panel1_Resize(object sender, EventArgs e)
    {
        
        panel1.Refresh();        
    }
    
        

        //crtanje prve slike
      void crtanjeslike(Graphics p)
        {
            int sirina = this.panel1.Width;
            int visina = this.panel1.Height;
            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Deklarisanje tacaka za geometriske figure

            var sestokrak = new PointF[6];
            var dvanestokrak = new PointF[12];
            var dvanestokrak1 = new PointF[12];
            var tacke = new PointF[12];
            var trougao = new PointF[3];

            //deklarisanje promjenjivih za radius geometriskih figura

            var sestokrakradius = sirina / 12.2f + visina / 12.2f;
            var osmokrakradius = sirina / 11.7f + visina / 11.7f;
            var sirtacke = sirina / 8f + visina / 8f;
            var radiustacke = sirina / 110 + visina / 110;
            var radiustacke1 = sirina / 45 + visina / 45;
            var dvanestokrakradius = sirina / 12.11f + visina / 12.11f;

            //crtanje velikog kruga

            g.DrawEllipse(olovka, sirina / 2 - sirtacke, visina / 2 - sirtacke, sirtacke + sirtacke, sirtacke + sirtacke);


            //crtanje malih krugova
            for (int a = 0; a < 12; a++)
            {

                float sir = sirina / 2 + sirtacke * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float vis = visina / 2 + sirtacke * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.FillEllipse(Brushes.Black, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, sir - radiustacke1, vis - radiustacke1, radiustacke1 + radiustacke1, radiustacke1 + radiustacke1);
                    tacke[a] = new PointF(sir, vis);
                }

            }

            g.DrawLine(olovka, tacke[3], tacke[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, tacke[1], tacke[7]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, tacke[5], tacke[11]);

            //crtanje sestokraka
            for (int a = 0; a < 6; a++)
            {
                sestokrak[a] = new PointF(
                    sirina / 2 + sestokrakradius * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    visina / 2 + sestokrakradius * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            //crtanje dvanestokraka
            int k = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + osmokrakradius * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + osmokrakradius * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvanestokrak1[k++] = new PointF(siro, viso);


                }
            }

            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvanestokrak1);


            //crtanje trougla

            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + dvanestokrakradius * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + dvanestokrakradius * (float)Math.Sin(a * 30 * Math.PI / 180f);



                dvanestokrak[a] = new PointF(siro, viso);

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestokrak[1], dvanestokrak[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestokrak[5], dvanestokrak[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestokrak[9], dvanestokrak[1]);

            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }

        }

        //Crtanje druge slike
        void crtanjeslike1(Graphics p)
        {
            int sirina = panel1.Width;
            int visina =panel1.Height;
            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var osmokrak = new PointF[8];
            var osmokrak1 = new PointF[8];
            var poligon = new Point[8];

            //Definisanje radiusa
            var radiustacke = sirina / 100 + visina / 100;
            var osmokrakradius = sirina / 8 + visina / 8;
            var osmokrakradius1 = sirina / 10 + visina / 10;
            var sirtacke = sirina / 15 + visina / 15;

            //Crtanje kruga
            g.DrawEllipse(olovka, sirina / 2 - sirtacke, visina / 2 - sirtacke, sirtacke + sirtacke, sirtacke + sirtacke);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            // velikog osmokraka
            for (int a = 0; a < 8; a++)
            {
                float siro = sirina / 2 + osmokrakradius * (float)Math.Cos(a * 45 * Math.PI / 180f);
                float viso = visina / 2 + osmokrakradius * (float)Math.Sin(a * 45 * Math.PI / 180f);
                osmokrak[a] = new PointF(siro, viso);
            }

            //Crtanje srednjeg osmokraka
            int k = 0;
            for (int a = 0; a < 16; a++)
            {

                float siro = sirina / 2 + osmokrakradius1 * (float)Math.Cos(a * 22.5 * Math.PI / 180f);
                float viso = visina / 2 + osmokrakradius1 * (float)Math.Sin(a * 22.5 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    osmokrak1[k++] = new PointF(siro, viso);
                }
            }
            g.DrawPolygon(olovka, osmokrak);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak1);


            //crtanje linijja
            for (int a = 0; a < 8; a++)
            {
                float siro = sirina / 2 + osmokrakradius * (float)Math.Cos(a * 45 * Math.PI / 180f);
                float viso = visina / 2 + osmokrakradius * (float)Math.Sin(a * 45 * Math.PI / 180f);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new Point(sirina / 2, visina / 2), new PointF(siro, viso));
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new Point(sirina / 2, visina / 2), osmokrak1[a]);
            }


            //Crtanje tacaka
            for (int a = 0; a < 16; a++)
            {

                float sir = sirina / 2 + sirtacke * (float)Math.Cos(a * 22.5 * Math.PI / 180f);
                float vis = visina / 2 + sirtacke * (float)Math.Sin(a * 22.5 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.FillEllipse(Brushes.Black, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);

                }

            }

            //povezivanje linija i bojenje trouglova
            int j = 1;
            for (int i = 0; i < 8; i++)
            {
                if (j < 8)
                {
                    PointF[] trougao = new PointF[] { osmokrak[i], osmokrak1[i], osmokrak[j] };
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.FillPolygon(Brushes.Black, trougao);
                }

                g.DrawLine(olovka, osmokrak[i], osmokrak1[i]);
                if (j < 8)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, osmokrak1[i], osmokrak[j++]);

                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[7], osmokrak[0]);
            
            g.DrawLine(olovka, osmokrak[7], osmokrak1[7]);
            
            g.DrawLine(olovka, osmokrak1[7], osmokrak[0]);
            
            PointF[] trougao1 = new PointF[] { osmokrak[7], osmokrak1[7], osmokrak[0] };
            g.FillPolygon(Brushes.Black, trougao1);
            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }
        }

        
               //Crtanje trece slike 
        void crtanjeslike3(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;
           
            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var sestokrak = new PointF[6];
            var dvanestokrak = new PointF[12];
            var dvanestokrak1 = new PointF[12];
            var dvanestokrak2 = new PointF[12];
            var tacke = new PointF[12];

            //Definisanje radiusa 
            var sestokrakradius = sirina / 10.53f + visina/10.53f;
            var dvanestokrakradius = sirina / 11.75f + visina / 11.75f;
            var dvanestokrakradius1 = sirina / 8f + visina / 8f;
            var sirtacke = sirina /12 + visina/12;
            var radiustacke = sirina / 180 + visina/180;
            var sirelipse = sirina / 8 + visina/8;

            //Crtanje elipse(velikog kruga)
            g.DrawEllipse(olovka, sirina / 2 - sirelipse, visina / 2 - sirelipse, sirelipse + sirelipse, sirelipse + sirelipse);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //Crtanje sestokraka
            for (int a = 0; a < 6; a++)
            {
                sestokrak[a] = new PointF(
                    sirina / 2 + sestokrakradius * (float)Math.Cos(a * 60 * Math.PI / 180f),
                    visina / 2 + sestokrakradius * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            //crtanje tacki
            for (int a = 0; a < 12; a++)
            {

                float sir = sirina / 2 + sirtacke * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float vis = visina / 2 + sirtacke * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.FillEllipse(Brushes.Black, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                 
                     tacke[a] = new PointF(sir, vis);
             
            }


            //Crtanje dvanestokraka velikog
            int k=0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + dvanestokrakradius * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + dvanestokrakradius * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvanestokrak[k++] = new PointF(siro, viso);


                }
            }

            //Crtanje dvanestokraka srednjeg
            int l = 0;
            int n = 0;
            for (int a = 0; a < 24; a++)
            {
                float siro = sirina / 2 + dvanestokrakradius1 * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + dvanestokrakradius1 * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvanestokrak1[l++] = new PointF(siro, viso);
                }
                if (a % 2 == 0)
                {

                    dvanestokrak2[n++] = new PointF(siro, viso);

                }

            }


            //Povezivanje linija
            int j = 1;
            for (int i = 0; i < 12;i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new Point(sirina / 2, visina / 2), dvanestokrak2[i]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, tacke[i], dvanestokrak1[i]);
                if (j < 12)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, dvanestokrak1[i], tacke[j++]);
                }
            }
            g.DrawLine(olovka, dvanestokrak1[11], tacke[0]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, tacke[1], tacke[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, tacke[5], tacke[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, tacke[9], tacke[1]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvanestokrak);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvanestokrak1);

            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }

        }


        //Crtanje četvrte slike
        void crtanjeslike4(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;
            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var osmokrak = new PointF[6];
            var osmokrak1 = new PointF[6];
            var osmokrak2 = new PointF[6];
            var osmokrak3 = new PointF[6];



            var sirtacke = sirina / 140 + visina / 140;
            var sirkruga = sirina / 11f + visina / 11;
            var osmokrakradius = sirina / 7 + visina / 7;
            var radiustacke = sirina / 180 + visina / 180;
            var osmokrakradius1 = sirina / 11f + visina / 11;
            var osmokrakradius2 = sirina / 16 + visina / 16;
            var osmokrakradius3 = sirina / 28 + visina / 28;



            //osmokrak veliki
            int k = 0;
            for (int a = 0; a < 12; a++)
            {

                float sir = sirina / 2 + osmokrakradius * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float vis = visina / 2 + osmokrakradius * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.FillEllipse(Brushes.Black, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    osmokrak[k++] = new PointF(sir, vis);
                }

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak);

            //osmokrak srednji
            k = 0;
            for (int a = 0; a < 12; a++)
            {

                float sir = sirina / 2 + osmokrakradius1 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float vis = visina / 2 + osmokrakradius1 * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.FillEllipse(Brushes.Black, sir - radiustacke, vis - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                    osmokrak1[k++] = new PointF(sir, vis);
                }

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak1);

            //osmokrak manji

            for (int a = 0; a < 6; a++)
            {

                float sir = sirina / 2 + osmokrakradius2 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float vis = visina / 2 + osmokrakradius2 * (float)Math.Sin(a * 60 * Math.PI / 180f);
                osmokrak2[a] = new PointF(sir, vis);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak2);

            //osmokrak najmanji
            for (int a = 0; a < 6; a++)
            {

                float sir = sirina / 2 + osmokrakradius3 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float vis = visina / 2 + osmokrakradius3 * (float)Math.Sin(a * 60 * Math.PI / 180f);
                osmokrak3[a] = new PointF(sir, vis);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak3);

            //Crtanje i popunjavanje elipse
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawEllipse(olovka, sirina / 2 - sirtacke, visina / 2 - sirtacke, sirtacke + sirtacke, sirtacke + sirtacke);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.FillEllipse(Brushes.Black, sirina / 2 - sirtacke, visina / 2 - sirtacke, sirtacke + sirtacke, sirtacke + sirtacke);

            //Povezivanje linija
            int j = 1;
            int n = 1;
            int m = 1;
            for (int i = 0; i < 6; i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, osmokrak2[i], osmokrak[i]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, osmokrak2[i], osmokrak1[i]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, osmokrak3[i], osmokrak2[i]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, osmokrak3[i], osmokrak1[i]);
                if (j < 6)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, osmokrak[i], osmokrak2[j++]);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, osmokrak1[i], osmokrak3[n++]);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, osmokrak1[i], osmokrak2[m++]);
                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak[5], osmokrak2[0]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[5], osmokrak3[0]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[5], osmokrak2[0]);


            //Crtanje elipse
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawEllipse(olovka, sirina / 2 - sirkruga, visina / 2 - sirkruga, sirkruga + sirkruga, sirkruga + sirkruga);
            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }
        }

        //Crtanje pete slike
        void crtanjeslike5(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var osmokrak = new PointF[12];
            var osmokrak1 = new PointF[12];
            var sestokrak = new PointF[6];
            var sestokrak1 = new PointF[6];
            var kvadrat = new PointF[4];
            var kvadrat1 = new PointF[4];

            //Definisanje radiusa
            var osmokrakradius = sirina / 8 + visina / 8;
            var osmokrakradius1 = sirina / 12f + visina / 12;
            var sestokrakradius = sirina / 36 + visina / 36;
            var sestokrakradius1 = sirina / 12f + visina / 12;
            var sirelipse = sirina / 12f + visina / 12;
            var sirkvadrata = sirina / 12f + visina / 12;
            var sirkvadrata1 = sirina / 12f + visina / 12;

            //osmokrak veliki

            int k = 0;
            for (int a = 0; a < 24; a++)
            {

                float sir = sirina / 2 + osmokrakradius * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float vis = visina / 2 + osmokrakradius * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {
                    osmokrak[k++] = new PointF(sir, vis);
                }

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak);

            //osmokrak najmanji
            for (int a = 0; a < 6; a++)
            {

                float sir = sirina / 2 + sestokrakradius * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float vis = visina / 2 + sestokrakradius * (float)Math.Sin(a * 60 * Math.PI / 180f);


                sestokrak[a] = new PointF(sir, vis);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.FillPolygon(Brushes.Black, sestokrak);


            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //krug

            g.DrawEllipse(olovka, sirina / 2 - sirelipse, visina / 2 - sirelipse, sirelipse + sirelipse, sirelipse + sirelipse);

            //kvadrat rotirani
            int m = 0;
            for (int a = 0; a < 8; a++)
            {

                float sir = sirina / 2 + sirkvadrata * (float)Math.Cos(a * 45 * Math.PI / 180f);
                float vis = visina / 2 + sirkvadrata * (float)Math.Sin(a * 45 * Math.PI / 180f);

                if (a % 2 != 0)
                {
                    kvadrat[m++] = new PointF(sir, vis);
                }

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, kvadrat);

            //kvadrat normalni
            for (int a = 0; a < 4; a++)
            {

                float sir = sirina / 2 + sirkvadrata1 * (float)Math.Cos(a * 90 * Math.PI / 180f);
                float vis = visina / 2 + sirkvadrata1 * (float)Math.Sin(a * 90 * Math.PI / 180f);

                kvadrat1[a] = new PointF(sir, vis);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, kvadrat1);


            //Isprekidani osmokrak

            for (int a = 0; a < 12; a++)
            {

                float sir = sirina / 2 + osmokrakradius1 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float vis = visina / 2 + osmokrakradius1 * (float)Math.Sin(a * 30 * Math.PI / 180f);


                osmokrak1[a] = new PointF(sir, vis);


            }
            //povezivanje linija
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[0], osmokrak1[1]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[2], osmokrak1[3]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[4], osmokrak1[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[6], osmokrak1[7]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[8], osmokrak1[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak1[10], osmokrak1[11]);

            //sestokrak srednji
            for (int a = 0; a < 6; a++)
            {

                float sir = sirina / 2 + sestokrakradius1 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float vis = visina / 2 + sestokrakradius1 * (float)Math.Sin(a * 60 * Math.PI / 180f);

                sestokrak1[a] = new PointF(sir, vis);
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak1);

            //Povezivanje poligona
            int j = 1;
            for (int i = 0; i < 12; i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new Point(sirina / 2, visina / 2), osmokrak1[i]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, osmokrak[i], osmokrak1[i]);
                if (j < 12)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, osmokrak[i], osmokrak1[j++]);
                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, osmokrak[11], osmokrak1[0]);


            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }
        }



        //Crtanje šeste slike
        void crtanjeslike6(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//kreiranje objekta olovka

            //Definisanje tacki
            var sestokrak = new PointF[6];
            var danaskrak = new PointF[12];
            var sestokrak1 = new PointF[6];

            //Definisanje radiusa
            var sestokrakradius = sirina / 8 + visina / 8;
            var sirkruga = sirina / 11f + visina / 11;
            var sirdvankrak = sirina / 11f + visina / 11;
            var sestokrakradius1 = sirina / 11f + visina / 11;
            var radiustacke = sirina / 180 + visina / 180;


            //sestokrak veliki
            int k = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + sestokrakradius * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + sestokrakradius * (float)Math.Sin(a * 30 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    sestokrak[k++] = new PointF(siro, viso);


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak);

            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //krug
            g.DrawEllipse(olovka, sirina / 2 - sirkruga, visina / 2 - sirkruga, sirkruga + sirkruga, sirkruga + sirkruga);

            //dvanastokrak
            int n = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + sirdvankrak * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + sirdvankrak * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    danaskrak[n++] = new PointF(siro, viso);


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, danaskrak);

            //crtanje tacki
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + sestokrakradius1 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + sestokrakradius1 * (float)Math.Sin(a * 60 * Math.PI / 180f);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, siro - radiustacke, viso - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.FillEllipse(Brushes.Black, siro - radiustacke, viso - radiustacke, radiustacke + radiustacke, radiustacke + radiustacke);

                sestokrak1[a] = new PointF(siro, viso);

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak1);

            //spajanje linijama

            for (int i = 0; i < 12; i++)
            {
                if (i < 6)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, new Point(sirina / 2, visina / 2), sestokrak1[i]);
                }
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new Point(sirina / 2, visina / 2), danaskrak[i]);


            }
            int j = 0;
            for (int i = 0; i < 12; i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, danaskrak[i], sestokrak[j]);
                if (i % 2 != 0)
                {
                    j++;
                }
            }

            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }
        }

        //Crtanje slike sedam
        void crtanjeslike7(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje ovjekra g
            Pen olovka = new Pen(Color.Black);//kreiranje objekta olovka

            //Definisanje tacki
            var dvankrak = new PointF[12];
            var tacke = new PointF[12];
            var dvankrak1 = new PointF[12];

            //Definisanje radiusa
            var tackeradius = sirina / 12 + visina / 12;
            var tackeradius1 = sirina / 100 + visina / 100;
            var tackeradius2 = sirina / 26.0f + visina / 26;
            var raddvankrak = sirina / 8 + visina / 8;
            var raddvankrak1 = sirina / 12 + visina / 12;
            var radiuskruga = sirina / 12 + visina / 12;


            //dansetokrak
            int n = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + raddvankrak * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvankrak[n++] = new PointF(siro, viso);


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvankrak);

            //crtanje krugova
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + tackeradius * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + tackeradius * (float)Math.Sin(a * 60 * Math.PI / 180f);


                tacke[a] = new PointF(siro, viso);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, siro - tackeradius1, viso - tackeradius1, tackeradius1 + tackeradius1, tackeradius1 + tackeradius1);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, siro - tackeradius2, viso - tackeradius2, tackeradius2 + tackeradius2, tackeradius2 + tackeradius2);

            }

            //isprekidani dvanestokrak
            for (int a = 0; a < 12; a++)
            {

                float sir = sirina / 2 + raddvankrak1 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float vis = visina / 2 + raddvankrak1 * (float)Math.Sin(a * 30 * Math.PI / 180f);


                dvankrak1[a] = new PointF(sir, vis);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), dvankrak1[a]);

            }
            //povezivanje linija
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[0], dvankrak1[1]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[2], dvankrak1[3]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[4], dvankrak1[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[6], dvankrak1[7]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[8], dvankrak1[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[10], dvankrak1[11]);


            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //crtanje kruga
            g.DrawEllipse(olovka, sirina / 2 - radiuskruga, visina / 2 - radiuskruga, radiuskruga + radiuskruga, radiuskruga + radiuskruga);

            //Povezivanje trouglova
            int j = 1;
            for (int i = 0; i < 12; i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, dvankrak1[i], dvankrak[i]);
                if (j < 12)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, dvankrak[i], dvankrak1[j++]);
                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak[11], dvankrak1[0]);


            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }

        }
       

        //Crtanje slike osam
        void crtanjeslike8(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka
            //Definisanje tacki
            var dvankrak = new PointF[12];
            var dvankrak1 = new PointF[12];
            var dvankrak2 = new PointF[12];
            var dvankrak3 = new PointF[12];
            var setokrak = new PointF[6];
            var setokrak1 = new PointF[6];
            var setokrak2 = new PointF[6];

            //Definisanje radiusa
            var radiussestokrak = sirina / 8.3f + visina / 8.3f;
            var radiussestokrak1 = sirina / 12f + visina / 12f;
            var radiussestokrak2 = sirina / 26f + visina / 26f;
            var raddvankrak = sirina / 8f + visina / 8f;
            var raddvankrak1 = sirina / 13.4f + visina / 13.4f;
            var raddvankrak2 = sirina / 8 + visina / 8;
            var raddvankrak3 = sirina / 13.8f + visina / 13.8f;
            var radiuskruga = sirina / 8 + visina / 8;
            var radiuskruga1 = sirina / 40 + visina / 40;

            //dansetokrak
            int n = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + raddvankrak * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvankrak[n++] = new PointF(siro, viso);


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvankrak);

            //crtanje linija iz centra
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + raddvankrak2 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak2 * (float)Math.Sin(a * 30 * Math.PI / 180f);

                dvankrak2[a] = new PointF(siro, viso);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), dvankrak2[a]);

            }

            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //crtanje kruga
            g.DrawEllipse(olovka, sirina / 2 - radiuskruga, visina / 2 - radiuskruga, radiuskruga + radiuskruga, radiuskruga + radiuskruga);

            //crtanje sestokraka
            int l = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radiussestokrak * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radiussestokrak * (float)Math.Sin(a * 30 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    setokrak[l++] = new PointF(siro, viso);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, siro - radiuskruga1, viso - radiuskruga1, radiuskruga1 + radiuskruga1, radiuskruga1 + radiuskruga1);

                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, setokrak);


            //srednji sestokrak
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + radiussestokrak1 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + radiussestokrak1 * (float)Math.Sin(a * 60 * Math.PI / 180f);

                setokrak1[a] = new PointF(siro, viso);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, setokrak1);

            //crtanje srednjeg dannestokraka
            int m = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + raddvankrak1 * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak1 * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvankrak1[m++] = new PointF(siro, viso);


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvankrak1);

            //mali sestokrak
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + radiussestokrak2 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + radiussestokrak2 * (float)Math.Sin(a * 60 * Math.PI / 180f);

                setokrak2[a] = new PointF(siro, viso);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, setokrak2);

            //spajanje malog i velikog sestokraka
            int j = 1;
            for (int i = 0; i < 6; i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, setokrak2[i], setokrak[i]);
                if (j < 6)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, setokrak[i], setokrak2[j++]);
                }

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, setokrak[5], setokrak2[0]);

            //crtanje malih trouglova
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + raddvankrak3 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak3 * (float)Math.Sin(a * 30 * Math.PI / 180f);

                dvankrak3[a] = new PointF(siro, viso);
            }

            //crtanje malih trouglova
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, setokrak2[0], dvankrak3[1]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak3[1], setokrak2[1]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, setokrak2[2], dvankrak3[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak3[5], setokrak2[3]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, setokrak2[4], dvankrak3[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak3[9], setokrak2[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, setokrak2[5], dvankrak3[9]);


            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }

        }


        //Crtanje slike devet
        void crtanjeslike9(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var sestokrak = new PointF[6];
            var sestokrak1 = new PointF[6];
            var dvanestkrak = new PointF[12];

            ///Definisanje radiusa
            var raddvankrak = sirina / 11 + visina / 11;
            var radiuskrug = sirina / 11 + visina / 11;
            var radsestkrak = sirina / 8f + visina / 8f;
            var radsestkrak1 = sirina / 11 + visina / 11;
            var tackeradius1 = sirina / 43.6f + visina / 43.6f;
            var tackeradius2 = sirina / 180 + visina / 180;

            //crtanje vanjskog sestokraka
            int t = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radsestkrak * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak * (float)Math.Sin(a * 30 * Math.PI / 180f);

                if (a % 2 != 0)
                {
                    sestokrak[t++] = new PointF(siro, viso);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), new PointF(siro, viso));

                }
            }

            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //crtanje kruga
            g.DrawEllipse(olovka, sirina / 2 - radiuskrug, visina / 2 - radiuskrug, radiuskrug + radiuskrug, radiuskrug + radiuskrug);

            //crtanje dvanestokraka
            int n = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + raddvankrak * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvanestkrak[n++] = new PointF(siro, viso);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), new PointF(siro, viso));


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvanestkrak);


            //crtanje setokraka srednjeg
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + radsestkrak1 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak1 * (float)Math.Sin(a * 60 * Math.PI / 180f);

                sestokrak1[a] = new PointF(siro, viso);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), sestokrak1[a]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, siro - tackeradius1, viso - tackeradius1, tackeradius1 + tackeradius1, tackeradius1 + tackeradius1);

            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestokrak1);

            //crtanje trouglova
            g.DrawLine(olovka, sestokrak[0], dvanestkrak[0]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestkrak[1], sestokrak[0]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestokrak[1], dvanestkrak[2]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestkrak[3], sestokrak[1]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestokrak[2], dvanestkrak[4]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestkrak[5], sestokrak[2]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestokrak[3], dvanestkrak[6]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestkrak[7], sestokrak[3]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestokrak[4], dvanestkrak[8]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestkrak[9], sestokrak[4]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestokrak[5], dvanestkrak[10]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvanestkrak[11], sestokrak[5]);

            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }

        }

        //Crtanje slike deset
        void crtanjeslike10(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var dvankrak = new PointF[12];
            var dvankrak1 = new PointF[12];
            var sestkrak = new PointF[6];
            var sestkrak1 = new PointF[6];
            var sestkrak2 = new PointF[6];



            //Definisanje radiusa
            var raddvankrak = sirina / 8.6f + visina / 8.6f;
            var raddvankrak1 = sirina / 9f + visina / 9f;
            var radsestkrak = sirina / 8.9f + visina / 8.9f;
            var radsestkrak1 = sirina / 13.4f + visina / 13.4f;
            var radsestkrak2 = sirina / 8.5f + visina / 8.5f;
            var radiuskruga = sirina / 51 + visina / 51;
            var radiuskruga1 = sirina / 23.7f + visina / 23.7f;

            //dansetokrak veliki
            int n = 0;
            for (int a = 0; a < 24; a++)
            {


                float siro = sirina / 2 + raddvankrak * (float)Math.Cos(a * 15 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak * (float)Math.Sin(a * 15 * Math.PI / 180f);

                if (a % 2 != 0)
                {

                    dvankrak[n++] = new PointF(siro, viso);


                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, dvankrak);

            //crtanje sestokraka
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + radsestkrak * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak * (float)Math.Sin(a * 60 * Math.PI / 180f);

                sestkrak[a] = new PointF(siro, viso);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, siro - radiuskruga, viso - radiuskruga, radiuskruga + radiuskruga, radiuskruga + radiuskruga);


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestkrak);

            //crtanje srednjih krugova
            int m = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radsestkrak1 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak1 * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    sestkrak1[m++] = new PointF(siro, viso);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, siro - radiuskruga1, viso - radiuskruga1, radiuskruga1 + radiuskruga1, radiuskruga1 + radiuskruga1);
                }


            }

            //crtanje linija iz centra

            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radsestkrak2 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak2 * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), new PointF(siro, viso));

                }

            }

            //crtanje trougla
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + raddvankrak1 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + raddvankrak1 * (float)Math.Sin(a * 30 * Math.PI / 180f);

                dvankrak1[a] = new PointF(siro, viso);
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[1], dvankrak1[5]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[5], dvankrak1[9]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, dvankrak1[9], dvankrak1[1]);

            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }

        }
        

        //Crtanje slike jedanaest
        void crtanjeslike11(Graphics p)
        {
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var sestkrak1 = new PointF[6];
            var sestkrak2 = new PointF[6];
            var sestkrak3 = new PointF[6];
            var sestkrak4 = new PointF[6];
            var sestkrak5 = new PointF[6];

            //Definisanje radiusa
            var radsestkrak1 = sirina / 13.7f + visina / 13.7f;
            var radsestkrak3 = sirina / 21f + visina / 21;
            var radsestkrak4 = sirina / 40 + visina / 40f;
            var radsestkrak5 = sirina / 15f + visina / 15f;
            var radiuskruga1 = sirina / 22 + visina / 22;
            var radiuskruga2 = sirina / 8.5f + visina / 8.5f;

            //crtanje krugova
            int m = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radsestkrak1 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak1 * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    sestkrak1[m++] = new PointF(siro, viso);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, siro - radiuskruga1, viso - radiuskruga1, radiuskruga1 + radiuskruga1, radiuskruga1 + radiuskruga1);
                }


            }

            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }

            //vanjski krug
            g.DrawEllipse(olovka, sirina / 2 - radiuskruga2, visina / 2 - radiuskruga2, radiuskruga2 + radiuskruga2, radiuskruga2 + radiuskruga2);

            //crtanje sestokraka

            int n = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radiuskruga2 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radiuskruga2 * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    sestkrak2[n++] = new PointF(siro, viso);
                }


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestkrak2);

            //crtanje sestrkaka srednjeg
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + radsestkrak3 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak3 * (float)Math.Sin(a * 60 * Math.PI / 180f);

                sestkrak3[a] = new PointF(siro, viso);
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestkrak3);

            //crtanje sestrkaka najmanjeg
            for (int a = 0; a < 6; a++)
            {


                float siro = sirina / 2 + radsestkrak4 * (float)Math.Cos(a * 60 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak4 * (float)Math.Sin(a * 60 * Math.PI / 180f);

                sestkrak4[a] = new PointF(siro, viso);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, sestkrak4[a], sestkrak3[a]);
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, sestkrak4);

            //odredjivanje tacka za mali trouglove
            n = 0;
            for (int a = 0; a < 12; a++)
            {


                float siro = sirina / 2 + radsestkrak5 * (float)Math.Cos(a * 30 * Math.PI / 180f);
                float viso = visina / 2 + radsestkrak5 * (float)Math.Sin(a * 30 * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    sestkrak5[n++] = new PointF(siro, viso);
                }


            }

            //crtanje malih trouglova
            int j = 1, l = 1;
            for (int a = 0; a < 6; a++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, sestkrak3[a], sestkrak5[a]);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, sestkrak3[a], sestkrak2[a]);
                if (j < 6)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, sestkrak3[j++], sestkrak5[a]);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, sestkrak3[l++], sestkrak2[a]);
                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestkrak5[5], sestkrak3[0]);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, sestkrak2[5], sestkrak3[0]);


            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }
        }


             //Crtanje slike dvanaest
        void crtanjeslike12(Graphics p)
        {
            
            int sirina = panel1.Width;
            int visina = panel1.Height;

            Graphics g = p;//Kreiranje objekta g
            Pen olovka = new Pen(Color.Black);//Kreiranje objekta olovka

            //Definisanje tacaka
            var krugovi = new PointF[8];
            var osmokrak = new PointF[8];
          
            //Definisanje radiusa
            var osmokrakradius = sirina / 8 + visina / 8;
            var krugovikradius = sirina / 10.2f + visina / 10.2f;
            var malikrugoviradius = sirina / 50 + visina / 50;
            var velikikrugoviradius = sirina / 26.85f + visina / 26.85f;
            var centralnikrugradius = sirina / 15.1f + visina / 15.1f;



            //Crtanje osmokraka i malih kruzica
            for (int a = 0; a < 8; a++)
            {
                float siro = sirina / 2 + osmokrakradius * (float)Math.Cos(a * 45 * Math.PI / 180f);
                float viso = visina / 2 + osmokrakradius * (float)Math.Sin(a * 45 * Math.PI / 180f);

                osmokrak[a] = new PointF(siro, viso);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawEllipse(olovka, siro - malikrugoviradius, viso - malikrugoviradius, malikrugoviradius + malikrugoviradius, malikrugoviradius + malikrugoviradius);
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), new PointF(siro, viso));


            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, osmokrak);

           
            //Crtanje velikih krugova i srednjeg osmokraka
            int n = 0;
            for (int a = 0; a < 16; a++)
            {
                float siro = sirina / 2 + krugovikradius * (float)Math.Cos(a * 22.5f * Math.PI / 180f);
                float viso = visina / 2 + krugovikradius * (float)Math.Sin(a * 22.5f * Math.PI / 180f);
                if (a % 2 != 0)
                {
                    krugovi[n++] = new PointF(siro, viso);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawEllipse(olovka, siro - velikikrugoviradius, viso - velikikrugoviradius, velikikrugoviradius + velikikrugoviradius, velikikrugoviradius + velikikrugoviradius);
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, new PointF(sirina / 2, visina / 2), new PointF(siro, viso));

                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawPolygon(olovka, krugovi);



            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //Crtanje centralnog kruga
            g.DrawEllipse(olovka, sirina / 2 - centralnikrugradius, visina / 2 - centralnikrugradius, centralnikrugradius + centralnikrugradius, centralnikrugradius + centralnikrugradius);
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            //Povezivanje malih trouglova
            int j = 1;
            for (int i = 0; i < 8; i++)
            {
                if (ime1 == "on")
                {
                    WaitMilliSec(500);
                }
                g.DrawLine(olovka, osmokrak[i], krugovi[i]);
                if (j < 8)
                {
                    if (ime1 == "on")
                    {
                        WaitMilliSec(500);
                    }
                    g.DrawLine(olovka, krugovi[i], osmokrak[j++]);
                }
            }
            if (ime1 == "on")
            {
                WaitMilliSec(500);
            }
            g.DrawLine(olovka, krugovi[7], osmokrak[0]);


            if (ime1 == "on")
            {
                button1.Text = "Gradual off";
                ime1 = "off";

                button1.Invalidate();
                panel2.Invalidate();
            }
           
            
        }


        //Dogadjag klikom za postepeno crtanje
        private void button1_Click(object sender, EventArgs e)
        {


            if (button1.Text == "Gradual off")
            {
                ime1 = "on";
                button1.Text = "Gradual on";
                panel2.Invalidate();
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
               
               
            }

            else if (button1.Text == "Gradual on")
            {
                ime1 = "off";
                button1.Text = "Gradual off";
                this.FormBorderStyle = FormBorderStyle.Sizable;


            }
           
            Slika_1.Invalidate();
           panel1.Invalidate();
        }


        //funkcija za pauzu
        private void WaitMilliSec(int millisecs)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddMilliseconds(millisecs) > DateTime.Now);
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Refresh();
        }

        private void button1_Resize(object sender, EventArgs e)
        {
            button1.Refresh();
        }

        private void button3_Resize(object sender, EventArgs e)
        {
            button1.Refresh();
        }

       
       

      

       

     
        

        

        







    




    }
}
