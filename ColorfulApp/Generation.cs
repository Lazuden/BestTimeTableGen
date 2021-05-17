using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ColorfulApp
{
    // Популяция
    class Generation
    {
        private List<Individual> _individs;
        private int _rateSum;
        private int _maxRate;
        private int _aveRate;
        private double _dispersion;

        public Generation()
        {
            _individs = new List<Individual>(Properties.Settings.Default.PopulationCount);
            GenerateStartPopulation();
            CalcStats();
        }

        public void Next()
        {
            int randomCount = _individs.Count * 20 / 100;
            int childsCount = _individs.Count * 60 / 100;
            int lastCount = _individs.Count - randomCount - childsCount;
            Rand.Shuffle(_individs);
            var childs = new List<Individual>(childsCount);
            var random = new List<Individual>(_individs.Skip(Math.Max(0, _individs.Count - randomCount)));

            int index, firstRnd, firstParent, secondRnd, secondParent, curSum;
            for (int i = 0; i < 30; i++)
            {
                index = curSum = firstParent = secondParent = 0;
                firstRnd = ThreadSafeRandom.ThisThreadsRandom.Next(_rateSum);
                secondRnd = ThreadSafeRandom.ThisThreadsRandom.Next(_rateSum);
                while (index + 1 < _individs.Count && (curSum < firstRnd || curSum < secondRnd))
                {
                    if (curSum < firstRnd)
                        firstParent++;
                    if (curSum < secondRnd)
                        secondParent++;
                    curSum += _individs[index++].Rating;
                }
                firstParent = firstParent > _individs.Count ? _individs.Count - 1 : firstParent;
                secondParent = secondParent > _individs.Count ? _individs.Count - 1 : firstParent;
                childs.Add(new Individual(_individs[firstParent], _individs[secondParent]));
                childs.Add(new Individual(_individs[secondParent], _individs[firstParent]));
            }

            _individs.Sort((x, y) => -x.Rating.CompareTo(y.Rating));

            Parallel.ForEach(childs, (curChild) => curChild.BuildAndColorize());

            _individs.RemoveRange(lastCount, _individs.Count - lastCount);

            _individs.AddRange(childs);
            _individs.AddRange(random);
            CalcStats();
        }

        private void GenerateStartPopulation()
        {
            Data.Instance.InitializeSupportData();
            int startCount = Data.Instance.IndividualCount;
            for (int i = 0; i < startCount; i++)
                _individs.Add(new Individual());
            Parallel.ForEach(_individs, (curIndivid) => curIndivid.BuildAndColorize());
        }

        private void CalcStats()
        {
            _dispersion = _rateSum = _aveRate = _maxRate = 0;
            foreach (Individual indiv in _individs)
            {
                _maxRate = indiv.Rating > _maxRate ? indiv.Rating : _maxRate;
                _rateSum += indiv.Rating;
            }

            _aveRate = _rateSum / _individs.Count;

            foreach (Individual indiv in _individs)
            {
                _dispersion += Math.Pow(indiv.Rating - _aveRate, 2);
            }
            _dispersion /= _individs.Count;
        }

        public override string ToString()
        {
            return $"maxRate: {_maxRate}, aveRate: {_aveRate}, dispersion: {_dispersion,-8} \n";
        }

        public DataTable BestSolution()
        {
            return _individs.Max().CreateTimeTable();
        }

        public DataTable TeacherTable()
        {
            return _individs.Max().CreateTeacherTimeTable();
        }
    }
}
