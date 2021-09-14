using System;
using System.Collections.Generic;

namespace BARSGroupMyteTask
{
    class Program
    {
        static void Main()
        {
            //example of realisation
            List<Section> sectionList = SectionFileReader.ReadFromFile(@"\InputSections.txt");
            sectionList.Sort();
            foreach (var section in sectionList)
            {
                Console.WriteLine(section.ToString());
            }
        }
    }
}
