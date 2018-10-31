using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Jordan J. Gilmore
/// Date:       Yes please.
/// FileName:   Gambler.cs
/// </summary>
namespace Exam2
{
    public class Gambler
    {
        //not enough cash! Stranger
        private double startingCash = 0;
        private double cash = 0;
        private double gain = 0;
        private double loss = 0;

        /// <summary>
        /// Default Gambler
        /// </summary>
        public Gambler() { }

        public Gambler(double startingCash, double cash, double gain, double loss)
        {
            this.startingCash = startingCash;
            this.cash = cash;
            this.gain = gain;
            this.loss = loss;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public double StartingCash { get; set; }
        public double Cash { get; set; }
        public double Gain { get; set; }
        public double Loss { get; set; }

    }
}
