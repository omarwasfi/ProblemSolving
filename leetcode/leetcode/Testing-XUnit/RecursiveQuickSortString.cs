namespace Testing_XUnit;

using RecursiveQuickSort_String;

public class RecursiveQuickSortString
{
    [Fact]
    public void ReadStrings()
    {
        ReadAndSort readAndSort = new ReadAndSort();

        Assert.Equal(readAndSort.ReadListOfStrings("/Users/omarwasfi/Documents/GitHub/ProblemSolving/leetcode/leetcode/RecursiveQuickSort-String/1000strings.txt").Count, 1000);
    }

    [Fact]
    public void ReadAndSortStrings()
    {
        ReadAndSort readAndSort = new ReadAndSort();

        List<string> strings = readAndSort.ReadListOfStrings("/Users/omarwasfi/Documents/GitHub/ProblemSolving/leetcode/leetcode/RecursiveQuickSort-String/1000strings.txt");

        List<string> stringsSorted = readAndSort.QuickSort(strings);

        List<string> expectedSorting = strings;
        expectedSorting.Sort();


        Assert.Equal(strings.Count, 1000);

        Assert.Equal(stringsSorted, expectedSorting);

    }

}
