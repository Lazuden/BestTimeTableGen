using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulApp
{
    // Популяция
    class Generation
    {
        List<Individual> Individs;

        int rateSum;
        int maxRate;
        int aveRate;
        double Dispersion;

        public Generation()
        {
            Individs = new List<Individual>(Properties.Settings.Default.PopulationCount);
            GenerateStartPopulation();
            CalcStats();
        }

        public void Next()
        {
            int randomCount = Individs.Count * 20 / 100;
            int childsCount = Individs.Count * 60 / 100;
            int lastCount = Individs.Count - randomCount - childsCount;
            Rand.Shuffle(Individs);
            List<Individual> childs = new List<Individual>(childsCount);
            List<Individual> random = new List<Individual>(Individs.Skip(Math.Max(0, Individs.Count - randomCount)));

            int index, firstRnd, firstParent, secondRnd, secondParent, curSum;
            for (int i = 0; i < 30; i++)
            {
                index = curSum = firstParent = secondParent = 0;
                firstRnd = ThreadSafeRandom.ThisThreadsRandom.Next(rateSum);
                secondRnd = ThreadSafeRandom.ThisThreadsRandom.Next(rateSum);
                while(index + 1 < Individs.Count && (curSum < firstRnd || curSum < secondRnd))
                {
                    if (curSum < firstRnd)
                        firstParent++;
                    if (curSum < secondRnd)
                        secondParent++;
                    curSum += Individs[index++].Rating;
                }
                firstParent = firstParent > Individs.Count ? Individs.Count - 1 : firstParent;
                secondParent = secondParent > Individs.Count ? Individs.Count - 1 : firstParent; 
                childs.Add(new Individual(Individs[firstParent], Individs[secondParent]));
                childs.Add(new Individual(Individs[secondParent], Individs[firstParent]));                
            }

            Individs.Sort(delegate (Individual x, Individual y)
            {
                return -x.Rating.CompareTo(y.Rating);
            });

            Parallel.ForEach(childs, (curChild) => curChild.BuildAndColorize());

            Individs.RemoveRange(lastCount, Individs.Count - lastCount);

            Individs.AddRange(childs);
            Individs.AddRange(random);
            CalcStats();
        }

        private void GenerateStartPopulation()
        {
            Data.Instance.InitializeSupportData();
            int startCount = Data.Instance.IndividualCount;
            for (int i = 0; i < startCount; i++)
                Individs.Add(new Individual());
            Parallel.ForEach(Individs, (curIndivid) => curIndivid.BuildAndColorize());
        }

        private void CalcStats()
        {
            Dispersion = rateSum = aveRate = maxRate = 0;
            foreach (Individual indiv in Individs)
            {
                maxRate = indiv.Rating > maxRate ? indiv.Rating : maxRate;
                rateSum += indiv.Rating;
            }

            aveRate = rateSum/Individs.Count;

            foreach (Individual indiv in Individs)
            {
                Dispersion += Math.Pow((indiv.Rating - aveRate), 2);
            }
            Dispersion /= Individs.Count;
        }

        public override string ToString()
        {
            return String.Format("maxRate: {0}, aveRate: {1}, dispersion: {2, -8} \n", maxRate, aveRate, Dispersion);
            //return Dispersion.ToString() + '\n';
        }

        public DataTable BestSolution()
        {
            return Individs.Max().CreateTimeTable();
        }

        public DataTable TeacherTable()
        {
            return Individs.Max().CreateTeacherTimeTable();
        }
    }
}
