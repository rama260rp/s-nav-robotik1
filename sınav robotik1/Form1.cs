using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_robotik1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


int trig = 7; // Mesafe sensörü trig pini için D7 portunu belirle
int echo = 8; // Mesafe sensörü echo pini için D8 portunu belirle
int hiz = 150; // Motor dönüş hızını belirle
void setup()
{
    pinMode(5, OUTPUT);// sağ motor ileri pini
    pinMode(6, OUTPUT);// sağ motor geri pini
    pinMode(9, OUTPUT);// sol motor ileri pini
    pinMode(10, OUTPUT);// sol motor geri pini 
    pinMode(trig, OUTPUT); // Mesafe sensörü trig pini çıkış için
    pinMode(echo, INPUT); // Mesafe sensörü echo pini giriş için
}
void loop()
{
    digitalWrite(trig, 1);
    delay(1);
    digitalWrite(trig, 0);
    int sure = pulseIn(echo, 1);
    int mesafe = (sure / 2) / 28.97;
    if (mesafe < 30) // mesafe 30cm’den küçük ise robotu geri gel.
    {
        analogWrite(5, 0);
        analogWrite(6, hiz);
        analogWrite(9, 0);
        analogWrite(10, hiz);
    }
    else // mesafe 30cm’den büyük ise dur.
    {
        analogWrite(5, 0);
        analogWrite(6, 0);
        analogWrite(9, 0);
        analogWrite(10, 0);
    }
}














int trig = 7; // Mesafe sensörü trig pini için D7 portunu belirle
int echo = 8; // Mesafe sensörü trig pini için D8 portunu belirle
int hiz = 100; // Motor dönüş hızını belirle
void setup()
{
    pinMode(5, OUTPUT);// sağ motor ileri pini
    pinMode(6, OUTPUT);// sağ motor geri pini
    pinMode(9, OUTPUT);// sol motor ileri pini
    pinMode(10, OUTPUT);// sol motor geri pini 
    pinMode(trig, OUTPUT); // Mesafe sensörü trig pini çıkış için
    pinMode(echo, INPUT); // Mesafe sensörü echo pini giriş için
}
void loop()
{
    digitalWrite(trig, 1);
    delay(1);
    digitalWrite(trig, 0);
    int sure = pulseIn(echo, 1);
    int mesafe = (sure / 2) / 28.97;
    if (mesafe < 30) // mesafe 30cm’den küçük ise robotu geri al ve döndür.
    {
        analogWrite(5, 0);
        analogWrite(6, hiz);
        analogWrite(9, 0);
        analogWrite(10, hiz);
        delay(150);
        analogWrite(5, 0);
        analogWrite(6, hiz);
        analogWrite(9, hiz);
        analogWrite(10, 0);
        delay(250);
    }
    else // mesafe 30cm’den büyük ise düz git.
    {
        analogWrite(5, hiz);
        analogWrite(6, 0);
        analogWrite(9, hiz);
        analogWrite(10, 0);
    }
}

