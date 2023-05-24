using System.Runtime.InteropServices;
using UnityEngine;

// Description: this file contains the code to call and execute the powershell.dll 
// file generated from the powershell.cpp file
// within the unity editor. It actually compiles fine in unity, but when run it
// gives error: "DllNotFoundException: .dll not found at PATH" even when the dll
// is defintely at that path location. This is probably because the powershell.cpp
// file imports "Windows.h", and the compiler can't find the windows.h .dll, and for
// some reason raises the .dll path of powershell.cpp even though it finds it
// instead of the missing libraries .dll path (according to stack overflow)

public class PowerShellExample : MonoBehaviour
{
    [DllImport("powershell.dll", CharSet = CharSet.Unicode)]
    private static extern void ExecutePowerShellCommand(string command, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder output, int outputSize);

    void Start()
    {
        // Define the PowerShell command
        string command = "Write-Host 'hello world'";

        // Set the output buffer size
        int outputSize = 1024;
        StringBuilder output = new StringBuilder(outputSize);

        // Call the C++/C function to execute the PowerShell command
        ExecutePowerShellCommand(command, output, outputSize);

        // Display the output in the Unity console
        UnityEngine.Debug.Log(output.ToString());
    }
}
