using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitDateien {
    class Program {
        static void Main ( string [ ] args ) {
            FileStream fs = File.Open ( @"c:\einTest\datei.txt", FileMode.Open);
            StreamReader sr = new StreamReader ( fs );
            //Console.WriteLine ( sr.ReadToEnd() );
            //fs.Close();
            

            string line;

            //Console.WriteLine ( line);

            while ((line = sr.ReadLine() )!= null) {
                Console.WriteLine ( line);
            }
            sr.Close ( );

            fs.Close ( );

            // Schreiben

            FileStream fs2 = File.Open ( "datei.txt" , FileMode.OpenOrCreate );
            BufferedStream bs2 = new BufferedStream ( fs2 );

            StreamWriter sw = new StreamWriter ( bs2 );
            sw.WriteLine ( "unsere Daten!");
            sw.Close ( );
            bs2.Close ( );




            Console.Read ( );

        }
    }
}
