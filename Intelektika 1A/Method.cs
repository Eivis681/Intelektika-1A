using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_1A
{
    public class Method
    {
        public string Calculate(string sport, string height, string weight, string neib)
        {
            Database database = new Database();
            List<Sport> sports = database.GetSpecificData(sport);
            List<string> varieties = new List<string>();
            for (int i = 0; i < sports.Count; i++)
            {
               if (varieties.Contains(sports[i].position) == false)
                {
                    varieties.Add(sports[i].position);
                }
            }
            List<Results> results = new List<Results>();
            
            for (int i = 0; i < sports.Count; i++)
            {
                double res = Math.Sqrt((Math.Pow(Int32.Parse(weight) - Int32.Parse(sports[i].weight), 2)) + (Math.Pow(Int32.Parse(height) - Int32.Parse(sports[i].height), 2)));
                results.Add(new Results { result = res, position = sports[i].position, sport = sports[i].sport});
            }
            results = results.OrderBy(o => o.result).ToList();


            List<Results> counter = new List<Results>();
            for (int i = 0; i<varieties.Count;i++)
            {
                counter.Add(new Results { position = varieties[i], result = 0 });
            }

            for (int i = 0; i<Int32.Parse(neib); i++)
            {
                for (int z= 0; z<counter.Count;z++)
                {
                    if (counter[z].position==results[i].position)
                    {
                        counter[z].result++;
                    }
                }
            }
            //counter = counter.OrderBy(o => o.result).ToList();
            counter = counter.OrderByDescending(o => o.result).ToList();
            if (counter[0].result == counter[1].result)
            {
                return "No";
            }
            else 
            {
                return counter[0].position;
            }
        }
    }
}
