using Avalonia;
using System.Diagnostics.Metrics;

namespace Names;

internal static class HeatmapTask
{
    public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
    { 
        string[] month = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        string[] data = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
        double[,] intensityPoints = new double[30, 12];
        for (int i = 0; i < names.Length; i++)
        {
            if(names[i].BirthDate.Day!=1)
                intensityPoints[names[i].BirthDate.Day -2, names[i].BirthDate.Month - 1]++;
        }
        return new HeatmapData(
            "Пример карты интенсивностей",
            intensityPoints, 
            data, 
            month);
    }
}