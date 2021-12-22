using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class CommandLineArgumentParser
{
    public static void TestCommandLine()
    {
        string[] arguments = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < arguments.Length; i++)
        {
            if (arguments[i] == "filepath" && i + 1 < arguments.Length)
            {
                string filepath = arguments[i + 1];
                StreamWriter writer = new StreamWriter(filepath);
                writer.WriteLine("Unity is Launched!!!");
                writer.Close();
                break;
            }
        }
    }
}
