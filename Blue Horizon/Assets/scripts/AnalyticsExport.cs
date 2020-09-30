using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public static class AnalyticsExport
{
    private static string filePath;
    
    private static List<String> exportList = new List<string>();

    public static void SendToExport(string exportString)
    {
        exportList.Append(exportString);
    }

    public static string ExportData()
    {
        
        //gross string addition. May clean if close down performance is bad, but shouldn't matter?
        String appExitTime = DateTime.Now.ToString();
        
        StringBuilder sb = new StringBuilder();
        foreach (char c in appExitTime)
        {
            if (!char.IsPunctuation(c))
                sb.Append(c);
        }

        appExitTime = sb.ToString();

        
        string filePath = "";
        filePath += Application.persistentDataPath;
        filePath += "/";
        filePath += appExitTime;
        
        System.IO.File.WriteAllText(filePath, "This is text that goes into the text file");

        return filePath;
    }
}
