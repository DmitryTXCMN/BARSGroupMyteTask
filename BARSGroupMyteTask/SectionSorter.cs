using System.Collections.Generic;

namespace BARSGroupMyteTask
{
    public class SectionSorter
    {
        private static void Swap(List<Section> inputList, int index1, int index2)
        {
            var temp = inputList[index1];
            inputList[index1] = inputList[index2];
            inputList[index2] = temp;
        }

        private static int Partition(List<Section> inputList, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (inputList[i].GetLenghtMagnitude() < inputList[maxIndex].GetLenghtMagnitude())
                {
                    pivot++;
                    Swap(inputList, pivot, i);
                }
            }

            pivot++;
            Swap(inputList, pivot, maxIndex);

            return pivot;
        }

        private List<Section> SortIteration(List<Section> inputList, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return inputList;
            }

            var pivotIndex = Partition(inputList, minIndex, maxIndex);
            SortIteration(inputList, minIndex, pivotIndex - 1);
            SortIteration(inputList, pivotIndex + 1, maxIndex);

            return inputList;
        }
        public List<Section> Sort(List<Section> inputList)
        {
            return SortIteration(inputList, 0, inputList.Count - 1);
        }
    }
}
