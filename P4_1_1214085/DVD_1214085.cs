using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214085
{
    internal class DVD_1214085 : Product_1214085
    {
        protected string duration;

        public DVD_1214085(string title, string duration) //method constructor dengan 2 parameter
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD!!!");
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

    }
}
