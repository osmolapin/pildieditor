using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Pildieditimisprogramm
{
    public partial class Form1 : Form
    {
        //Globaalsed X ja Y väärtused mida ei muudeta peale väärtustamist
        //Väärtus tuleb btnSelect_Click funkt.-st
        int initialX, initialY;
        bool havePic = false; //Kontrolliks kas pilt on valitud
        bool haveMultiplePic = false; //Kontrolliks kas mitu pilti on valitud "havePic" on false siis
        bool haveToConvert = false;
        int counter;

        public Form1()
        {
            InitializeComponent();
        }

        //Faili valimise dialoogil "OK" vajutamisel näidatakse pilti
        //local string picture - pildi faili asukoht
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            xResInput.Text = null;
            yResInput.Text = null;


            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                listBox1.Items.Clear();
                counter = 0;

                havePic = false;
                haveMultiplePic = false;

                //Loetakse kokku mitu faili on valitud
                foreach (String file in openFileDialog1.FileNames) 
                {
                    counter++;
                }
                //Kui pilte on 1
                if (counter == 1)
                {
                    //Asjade eest ära võtmine ja juurde panemine et saaks näidata pilti
                    PicNotSelectedTxt.Visible = false;
                    listBox1.Visible = false;
                    haveMultiplePic = false;
                    pictureBox.Visible = true;

                    string picture = openFileDialog1.FileName;
                    //Salvestatakse pildi x ja y suurus
                    Image img = Image.FromFile(picture);
                    initialX = img.Width;
                    initialY = img.Height;
                    
                    pictureBox.ImageLocation = picture; //Kuvatakse pilti
                    //Kuvatakse pildi x ja y resolutsioon
                    initialResolution.Text = "Pildi resolutsioon: " + initialX + "x" + initialY;  //Kuvatakse algne pildi resolutsioon
                    initialResolution.Visible = true;

                    havePic = true;
                }
                //Kui pilte on rohkem kui 1
                else if (counter > 1)
                {
                    //Asjade eest ära võtmine ja juurde panemine et saaks näidata listi kus on pildid
                    PicNotSelectedTxt.Visible = false;
                    pictureBox.Visible = false;
                    havePic = false;
                    listBox1.Visible = true;
                    //Iga pilt pannakse listbox1-te koos oma x ja y suurusega
                    foreach (String path in openFileDialog1.FileNames)
                    {
                        //Faili nime eraldamine faili pathist
                        string filename = Path.GetFileName(path);

                        Image img = Image.FromFile(path);
                        int x = img.Width;
                        int y = img.Height;
                        listBox1.Items.Add(filename + " " + x + "x" + y);
                    }

                    haveMultiplePic = true;
                }
                //Kui pilte on 0
                else if (counter == 0) 
                {
                    havePic = false;
                    haveMultiplePic = false;
                } 
            }
        }
        //Arvutatakse puuduv y suurus ristkorrutise abil
        private int CalculateHeight(Bitmap bitmap, int widthToCalculate) 
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            return (height * widthToCalculate) / width;
        }

        //Muudetakse pildi heledust
        //Isiklikult ei tea kuidas töötab
        private Bitmap AdjustBrightness(Image image, float brightness)
        {
            // Make the ColorMatrix.
            float b = brightness;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Draw the image onto the new bitmap while applying the new ColorMatrix.
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }

            // Return the result.
            return bm;
        }

        //Avatakse pilt, tehakse "img"-st bitmap
        //"img"-i bitmapist tehakse koopia millele lisatakse soovitud resolutsioon
        //salvestatakse fail nimega "file300.jpg"
        //local string picture - pildi faili asukoht
        //bitmap - "picture" bitmap & newBitmap - "bitmap" koopia
        //funkt. vajab sisestada -> desiredX & desiredY - salvestatava pildi resolutsioon & counter - number mis tuleb pildi nime sisse
        private void SavePicture(Image img, int desiredX, int desiredY, int counter) 
        {
            int usedY;
            using Bitmap bitmap = (Bitmap)img;

            Bitmap colored = AdjustBrightness(bitmap, slider.Value/8.3f); //8.3 on faktor mis teeb slider.Value piisavalt väikseks et saaks kasutada AdjustBrightnessi funktsioonis

            if (haveToConvert)
            {
                usedY = CalculateHeight(colored, desiredX);
            }
            else
            {
                usedY = desiredY;
            }

            using Bitmap newBitmap = new Bitmap(colored, desiredX, usedY);
            newBitmap.Save("a" + counter + ".jpg");
        }
        //Slider pannakse tagasi algsesse asendisse
        private void ResetSlider_Click(object sender, EventArgs e)
        {
            slider.Value = 10;
        }

        //Plidi olemasolul salvestatakse pilt soovitud resolutsiooniga
        private void BtnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            //Vaadatakse kastides "x/yResInput" olevate soovitud suuruste väärtusi
            Int32.TryParse(xResInput.Text, out int x);
            Int32.TryParse(yResInput.Text, out int y);
            //Kui üheski kastis ei ole midagi siis ei salvestata midagi
            if (x == 0 && y == 0)
            {
                return;
            }
            //Kui x kastis on siis arvutatakse y väärtus
            else if (y == 0) 
            {
                haveToConvert = true;
            }

            if (havePic)
            {
                string picture = openFileDialog1.FileName;
                Image img = Image.FromFile(picture);
                //Salvestatakse pildi x, y ja counter pannakse 1 - [faili nimesse tuleb 1]
                SavePicture(img, x, y, 1);

                haveToConvert = false;
            }
            else if (haveMultiplePic) 
            {
                foreach (String file in openFileDialog1.FileNames) 
                {
                    i++;
                    Image img = Image.FromFile(file);
                    //Salvestatakse pildi x, y ja counter pannakse i - [faili nimesse tuleb i] i suureneb iga pildiga mis on
                    SavePicture(img, x, y, i);
                }

                haveToConvert = false;
            }
        }
    }
}
