using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySingleton
{
    public class SingletonData
    {
        private static SingletonData instance;

        public List<Data> Data { get; private set; }

        private SingletonData(Dictionary<int?, int> mp) {

            List<Data> data = new List<Data>();

            foreach (var pair in mp)
            {
                data.Add(new Data() { sum = pair.Key, cnt = pair.Value });
            }

            Data = data;
        }

        public static SingletonData getInstance(Dictionary<int?, int> mp)
        {
            if (instance == null)
            {
                instance = new SingletonData(mp);
            }
            return instance;
        }
    }
}
