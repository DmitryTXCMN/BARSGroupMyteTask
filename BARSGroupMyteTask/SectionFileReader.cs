using System;
using System.IO;
using System.Collections.Generic;

namespace BARSGroupMyteTask
{
    public class SectionFileReader
    {
        public List<Section> ReadFromFile(string location)
        {
            var list = new List<Section>();
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + location))
            {
                while (!reader.EndOfStream)
                {
                    var args = reader.ReadLine().Split(' ', ';');
                    list.Add(new Section(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]), Convert.ToDouble(args[2]), Convert.ToDouble(args[3])));
                }
            }
            return list;
        }
    }
}
