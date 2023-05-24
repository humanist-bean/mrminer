using System.Diagnostics;
using UnityEngine;

// NOTE: This code would work except it gets blocked by DW2's security checks with error:
// Compilation failed, "SecurityException: Security check failed because System.IO is prohibited."

public class PowerShellExample : MonoBehaviour
{
    void Start()
    {
        // Create a new process to run PowerShell
        Process process = new Process();

        // Set the start information for the process
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "powershell.exe";
        startInfo.Arguments = "ECHO hello world";
        startInfo.RedirectStandardOutput = true;
        startInfo.UseShellExecute = false;
        startInfo.CreateNoWindow = true;

        process.StartInfo = startInfo;

        // Start the process
        process.Start();

        // Read the output of the PowerShell command
        string output = process.StandardOutput.ReadToEnd();

        // Wait for the process to exit
        process.WaitForExit();

        // Display the output in the Unity console
        UnityEngine.Debug.Log(output);
    }
}
