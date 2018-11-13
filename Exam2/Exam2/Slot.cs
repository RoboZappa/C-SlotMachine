using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Exam2.Form1;
/// <summary>
/// Developer:  Jordan J. Gilmore
/// Date:       10/14/2017
/// FileName:   Slot.cs
/// </summary>
namespace Exam2
{

    public class Slot
    {
        public Image Picture { get; set; }

        public int RandValue { get; set; }

        public int PictureValue { get; set; }
        
        /// <summary>
        /// Default constructor and only constructor need
        /// </summary>
        public Slot(Random rand)
        {
            RandValue = MakeRandom(rand);
            Picture = MakeImage(RandValue);
            PictureValue = GetPictureValue(RandValue);
        }
        public int GetPictureValue(int randValue)
        {
            int imageValue;
            if (randValue > 1 && randValue < 11)
            {
                return imageValue = 0;
            }
            else if (randValue > 10 && randValue < 21)
            {
                return imageValue = 1;
            }
            else if (randValue > 20 && randValue < 31)
            {
                return imageValue = 2;
            }
            else if (randValue > 30 && randValue < 41)
            {
                return imageValue = 3;
            }
            else if (randValue > 40 && randValue < 51)
            {
                return imageValue = 5;
            }
            else if (randValue > 50 && randValue < 61)
            {
                return imageValue = 6;
            }
            else if (randValue > 60 && randValue < 71)
            {
                return imageValue = 7;
            }
            else if (randValue > 70 && randValue < 81)
            {
                return imageValue = 8;
            }
            else if (randValue > 80 && randValue < 91)
            {
                return imageValue = 9;
            }
            else if (randValue > 90 && randValue < 101)
            {
                return imageValue = 10;
            }
            else if (randValue == 0)
            {
                return imageValue = 4;
            }

            return imageValue = 1;
        }
    
        public int MakeRandom(Random rand)
        {
            int toRand = rand.Next(0, 101);
            return toRand;
        }

        public Image MakeImage(int randValue)
        {
            Image newImage;
            if(randValue > 1 &&  randValue < 11)
            {
                return newImage = Properties.Resources.slot0;
            }
            else if (randValue > 10 && randValue < 21)
            {
                return newImage = Properties.Resources.slot1;
            }
            else if (randValue > 20 && randValue < 31)
            {
                return newImage = Properties.Resources.slot2;
            }
            else if (randValue > 30 && randValue < 41)
            {
                return newImage = Properties.Resources.slot3;
            }
            else if (randValue > 40 && randValue < 51)
            {
                return newImage = Properties.Resources.slot5;
            }
            else if (randValue > 50 && randValue < 61)
            {
                return newImage = Properties.Resources.slot6;
            }
            else if (randValue > 60 && randValue < 71)
            {
                return newImage = Properties.Resources.slot7;
            }
            else if (randValue > 70 && randValue < 81)
            {
                return newImage = Properties.Resources.slot8;
            }
            else if (randValue > 80 && randValue < 91)
            {
                return newImage = Properties.Resources.slot9;
            }
            else if (randValue > 90 && randValue < 101)
            {
                return newImage = Properties.Resources.slot10;
            }
            else if(randValue == 0)
            {
                return newImage = Properties.Resources.slot4;
            }
            else
            {
                return newImage = Properties.Resources.starterSlot;
            }
            
        }
    }

    
}
