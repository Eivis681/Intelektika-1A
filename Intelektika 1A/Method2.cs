using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_1A
{
    public class Method2
    {
        public List<string> Calculate(string height, string weight, string neib)
        {
            Database database = new Database();
            List<Sport> sports = database.GetData();
            List<string> varieties = new List<string>();
            for (int i = 0; i < sports.Count; i++)
            {
                if (varieties.Contains(sports[i].position) == false)
                {
                    varieties.Add(sports[i].position);
                }
            }
            List<string> sportoSaka = new List<string>();
            for (int i = 0; i <sports.Count;i++)
            {
                if(sportoSaka.Contains(sports[i].sport)==false)
                {
                    sportoSaka.Add(sports[i].sport);
                }
            }

            List<Results> results = new List<Results>();
            for (int i = 0; i < sports.Count; i++)
            {
                double res = Math.Sqrt((Math.Pow(Int32.Parse(weight) - Int32.Parse(sports[i].weight), 2)) + (Math.Pow(Int32.Parse(height) - Int32.Parse(sports[i].height), 2)));
                results.Add(new Results { result = res, position = sports[i].position, sport = sports[i].sport });
            }
            results = results.OrderBy(o => o.result).ToList();


            List<Results> counter = new List<Results>();
            for (int i = 0; i < varieties.Count; i++)
            {
                counter.Add(new Results { position = varieties[i], result = 0 });
            }

            for (int i = 0; i < Int32.Parse(neib); i++)
            {
                for (int z = 0; z < counter.Count; z++)
                {
                    if (counter[z].position == results[i].position)
                    {
                        counter[z].result++;
                    }
                }
            }
            counter = counter.OrderByDescending(o => o.result).ToList();
            List<string> backResult = new List<string>();
            if (counter[0].result == counter[1].result)
            {
                backResult.Add("No");
                return backResult;
            }
            else
            {
                var random = new Random();
                int index = random.Next(sportoSaka.Count);
                backResult.Add(counter[0].position);
                backResult.Add(sportoSaka[index]);
                return backResult;
            }
        }
    }
}
