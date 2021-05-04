using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_9
{
    class Generator
    {
        double[] stats=new double[5];
        public double[] freq = new double[5];
        public double[] ps = new double[5];
        Random rnd = new Random();
        double alpha;
        void generateEvent()
        {
            alpha = rnd.NextDouble();
            for (int i = 0; i < 5; i++)
            {
                alpha -= ps[i];
                if (alpha < 0)
                {
                    stats[i]++;
                    break;
                }
            }
        }

        public void createExperiments(double n)
        {
            for (int i = 0; i < n; i++)
            {
                generateEvent();
            }
            for (int i = 0; i < 5; i++)
            {
                freq[i] = stats[i] / n;
            }
            for (int i = 0; i < 5; i++)
            {
                stats[i] = 0;
            }
        }

        public bool isNorm()
        {
            double p=0;
            foreach (var pr in ps)
            {
                p += pr;
            }
            if (p == 1)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
