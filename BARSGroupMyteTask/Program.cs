using System;
using System.Collections.Generic;

namespace BARSGroupMyteTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of realisation
            List<Section> sectionList = new SectionFileReader().ReadFromFile(@"\InputSections.txt");
            new SectionSorter().Sort(sectionList);
            foreach (var section in sectionList)
            {
                Console.WriteLine(section.GetLenght());
            }
        }
    }
}
