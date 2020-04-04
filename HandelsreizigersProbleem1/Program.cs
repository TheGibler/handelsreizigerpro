using System;

namespace HandelsreizigersProbleem1
{
    class Program
    {
        public static Double[,] steden = new Double[6, 2] { { 52.23, 4.56 }, { 51.55, 4.29 }, { 52.05, 4.19 }, { 52.06, 5.07 }, { 51.27, 5.29 }, { 53.13, 6.34 } };
        public static int huidig, bestemming, Utrecht;
        static double totaf, afstand;
        static double minafstand1 = 100, minafstand2 = 100, minafstand3 = 100;

        public static string[] stadnaam = new string[] { "Amsterdam ,", "Rotterdam ,", "Den Haag ,", "Utrecht ", "Eindhoven ,", "Groningen ," };
        public static string stadnaam1, stadnaam2, stadnaam3, stadnaam4, stadnaam5;

        public static string min1stadnaam1, min1stadnaam2, min1stadnaam3, min1stadnaam4, min1stadnaam5;
        public static string min2stadnaam1, min2stadnaam2, min2stadnaam3, min2stadnaam4, min2stadnaam5;
        public static string min3stadnaam1, min3stadnaam2, min3stadnaam3, min3stadnaam4, min3stadnaam5;


        static void Main(string[] args)
        {
            Utrecht = 3;
            huidig = 0;
            bestemming = 0;
            Program n = new Program();
            n.bereken();

            Console.WriteLine("kortste afstand: " + minafstand1 + "     route: Utrecht, " + min1stadnaam1 + min1stadnaam2 + min1stadnaam3 + min1stadnaam4 + min1stadnaam5 + "Utrecht");
            Console.WriteLine("1na kortste afstand: " + minafstand2 + "     route: Utrecht, " + min2stadnaam1 + min2stadnaam2 + min2stadnaam3 + min2stadnaam4 + min2stadnaam5 + "Utrecht");
            Console.WriteLine("2na kortste afstand: " + minafstand3 + "     route: Utrecht, " + min3stadnaam1 + min3stadnaam2 + min3stadnaam3 + min3stadnaam4 + min3stadnaam5 + "Utrecht");
            Console.ReadLine();
        }

        public void bereken()
        {
            Program m = new Program();
            Program r = new Program();
            Console.WriteLine("hello");
            for (int x0 = 0; x0 < 6; x0++)                                                  //de eerste stad na utrecht
            {
                if (x0 != Utrecht)
                    for (int x1 = 0; x1 < 6; x1++)                                          // de tweede stad
                    {
                        if (x1 != x0 && x1 != Utrecht)
                            for (int x2 = 0; x2 < 6; x2++)                                  //de derde
                            {
                                if (x2 != x0 && x2 != x1 && x2 != Utrecht)
                                    for (int x3 = 0; x3 < 6; x3++)                          //de vierde
                                    {
                                        if (x3 != x0 && x3 != x1 && x3 != x2 && x3 != Utrecht) 
                                            for (int x4 = 0; x4 < 6; x4++)                  //de vijfde
                                            {
                                                if (x4 != x0 && x4 != x1 && x4 != x2 && x4 != x3 && x4 != Utrecht)
                                                {
                                                    totaf = 0;
                                                    afstand = m.berekenafstand(Utrecht, x0); //vanaf utrecht naar eerste stad
                                                    totaf = totaf + afstand;
                                                    stadnaam1 = stadnaam[x0];

                                                    afstand = m.berekenafstand(x0, x1); //tweede
                                                    totaf = totaf + afstand;
                                                    stadnaam2 = stadnaam[x1];

                                                    afstand = m.berekenafstand(x1, x2); //derde
                                                    totaf = totaf + afstand;
                                                    stadnaam3 = stadnaam[x2];

                                                    afstand = m.berekenafstand(x2, x3); //vierde
                                                    totaf = totaf + afstand;
                                                    stadnaam4 = stadnaam[x3];

                                                    afstand = m.berekenafstand(x3, x4); //vijfde
                                                    totaf = totaf + afstand;
                                                    stadnaam5 = stadnaam[x4];

                                                    afstand = m.berekenafstand(x4, Utrecht); //van de vijfde stad naar utrecht
                                                    totaf = totaf + afstand;
                                                    if (totaf < minafstand3)
                                                        r.remember();
                                                    
                                                }
                                            }
                                    }
                            }
                    }
            }

        }

        public double berekenafstand(int stadhuidig, int stadrichting)
        {
            double hx, hy, rx, ry;
            hx = steden[stadhuidig, 0];
            hy = steden[stadhuidig, 1];
            rx = steden[stadrichting, 0];
            ry = steden[stadrichting, 1];
            afstand = Math.Sqrt((hx-rx)* (hx - rx) + (hy - ry)*( hy- ry));
            return afstand;
        }

        public void remember()
        {
            if (Math.Round(totaf, 5) != Math.Round(minafstand1, 5) && Math.Round(totaf, 5) != Math.Round(minafstand2, 5) && Math.Round(totaf, 5) != Math.Round(minafstand3, 5))
            {
                if (totaf < minafstand2)
                {

                    if (totaf < minafstand1)
                    {
                        minafstand1 = totaf;
                        min1stadnaam1 = stadnaam1;
                        min1stadnaam2 = stadnaam2;
                        min1stadnaam3 = stadnaam3;
                        min1stadnaam4 = stadnaam4;
                        min1stadnaam5 = stadnaam5;
                    }

                    else
                    {
                        minafstand2 = totaf;
                        min2stadnaam1 = stadnaam1;
                        min2stadnaam2 = stadnaam2;
                        min2stadnaam3 = stadnaam3;
                        min2stadnaam4 = stadnaam4;
                        min2stadnaam5 = stadnaam5;
                    }

                }

                else
                {
                    minafstand3 = totaf;
                    min3stadnaam1 = stadnaam1;
                    min3stadnaam2 = stadnaam2;
                    min3stadnaam3 = stadnaam3;
                    min3stadnaam4 = stadnaam4;
                    min3stadnaam5 = stadnaam5;
                }
            }
        }
    }
}
