using System;
using System.Timers;

namespace EXPOSEETIMER
{
    class aTimer
    {
        public static Timer ATimer;
        public static void Maain2()
        {
            // Creer un timer a 59 secondes interval.
            double interval = 59000;
            ATimer = new System.Timers.Timer(interval);
        }
        

}
}
