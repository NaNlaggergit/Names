namespace Names;

internal static class HistogramTask
{
    public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
    {
        string[] data = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
        double[] countName = new double[31];
        for (int i= 0, day=0; i < names.Length; i++)
        {
            if(names[i].Name == name)
            {
                day=names[i].BirthDate.Day;
                countName[day-1]++;
            }
        }
        countName[0] = 0d;
        return new HistogramData(
            $"Рождаемость людей с именем '{name}'", 
            data,
            countName);
    }
}