using System;
using System.IO;
using System.Text;
using System.Data;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;



namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 65535;
            /* byte[] by = new byte[4];
             by[0] = 0xA1;
             by[1] = 0x02;
             by[2]=0x03;
             by[3] = 0x11;
            // Array.Reverse(by);
             Console.WriteLine("{0}", BitConverter.ToUInt32(by)); */

            // by[1] = 0xff;665
            // Console.WriteLine("{0}", );

            //  ArrayList AL = new ArrayList(2);
            /* ArrayList AL1 = new ArrayList();
             ArrayList AL2 = new ArrayList();
             AL1.Add("1");
             AL2.Add("2");
             string[] stringAL1 = AL1.ToArray(typeof(string)) as string[]; //电流
             string[] stringAL2 = AL2.ToArray(typeof(string)) as string[];//电压
             double[] doubleAL1 = new double[10000];
             double[] doubleAL2 = new double[10000];
             doubleAL1 = Array.ConvertAll<string, double>(stringAL1, double.Parse);
             doubleAL2 = Array.ConvertAll<string, double>(stringAL2, double.Parse); 

             Console.WriteLine("{0}",doubleAL1[0]+100);*/
            double b=0;
            for (int i = 0; i < 20; i++)
            {
                b = Math.Pow(2, i);
                Console.WriteLine("{0}",b);
            }
        }
    }
}
