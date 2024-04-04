using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace övning2t4
{
    internal class Person
    {
        private string namn;
        private string efternamn;
        private DateTime födelsedag;
        private bool myndig;
        private int år;
        private double vikt;
        private double längd;
        private double bmi;
        public double Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }
        public double Längd
        {
            get { return längd; }
            set { längd = value; }
        }
        public double BMI
        {
            get { return bmi; }
            set { bmi = value; }
        }
        public DateTime Födelsedag
        {
            get { return födelsedag; }
            set
            {
                födelsedag = value;
            }
        }
        public int År
        {
            get { return år; }
            set
            {
                år = BeräknaÅlder(födelsedag);

                if (år >= 18)
                {
                    Myndig = true;
                }
                else
                {
                    Myndig = false;
                }
            }
        }

        public bool Myndig
        {
            get { return myndig; }
            set
            { myndig = value; }
        }
        public int BeräknaÅlder(DateTime födelsedag)
        {
            DateTime nu = DateTime.Today;
            int år = nu.Year - födelsedag.Year;

            if (födelsedag.Date > nu.AddYears(-år))
            {
                år--;
            }
            return år;
        }
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; }
        }
    }
}
