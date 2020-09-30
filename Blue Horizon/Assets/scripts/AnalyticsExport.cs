using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class AnalyticsExport
{
    private static List<String> exportList = new List<string>();

    public static void SendToExport(string exportString)
    {
        exportList.Append(exportString);
    }

    public static void ExportData()
    {
        
    }
}
