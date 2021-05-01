using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Form1()
        {
            InitializeComponent();
        }

        //Faili valimise dialoogil "OK" vajutamisel näidatakse pilti
        //local string picture - pildi faili asukoht
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                foreach (String file in openFileDialog1.FileNames) 
                {
                    counter++;
                }

                if (counter > 1)
                {
                    pictureBox.ImageLocation = null;
                    initialResolution.Text = "Piltide kuvamine ei ole võimalik kuna on valitud rohkem kui 1 pilt";
                    initialResolution.Visible = true;
                    havePic = false;
                    haveMultiplePic = true;
                }
                else if (counter == 1)
                {
                    string picture = openFileDialog1.FileName;

                    Image img = Image.FromFile(picture);
                    initialX = img.Width;
                    initialY = img.Height;

                    pictureBox.ImageLocation = picture;

                    initialResolution.Text = "Pildi resolutsioon: " + initialX + "x" + initialY;  //Kuvatakse algne pildi resolutsioon
                    initialResolution.Visible = true;
                    havePic = true;
                }
                else if (counter == 0) 
                {
                    havePic = false;
                    haveMultiplePic = false;
                } 
            }
        }
        private int CalculateHeight(Bitmap bitmap, int widthToCalculate) 
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            return (height * widthToCalculate) / width;
        }
        //Avatakse pilt, salvestatakse tehakse "img"-st bitmap
        //"img"-i bitmapist tehakse koopia millele saab lisada resolutsiooni
        //salvestatakse fail nimega "file300.jpg"
        //local string picture - pildi faili asukoht
        //bitmap - "picture" bitmap & newBitmap - "bitmap" koopia
        //funkt. vajab sisestada -> desiredX & desiredY - salvestatava pildi resolutsioon
        private void SavePicture(Image img, int desiredX, int desiredY, int counter) 
        {
            int usedY;
            using (Bitmap bitmap = (Bitmap)img)
            {
                if (haveToConvert)
                {
                    usedY = CalculateHeight(bitmap, desiredX);
                }
                else 
                {
                    usedY = desiredY;
                }
                using (Bitmap newBitmap = new Bitmap(bitmap, desiredX, usedY))
                {
                    newBitmap.Save("a" + counter + ".jpg");
                }
            }
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
