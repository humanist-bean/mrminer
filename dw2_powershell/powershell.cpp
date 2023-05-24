#include <Windows.h>
#include <iostream>

// NOTE: this file is meant to be called by interop.cs

extern "C" __declspec(dllexport) void ExecutePowerShellCommand(const wchar_t *command, wchar_t *output, int outputSize)
{
    // Execute the PowerShell command
    // Store the output in the 'output' buffer

    // For example:
    _wsystem(command); // Executes the PowerShell command directly

    // Copy the output to the provided output buffer
    wcscpy_s(output, outputSize, L"Output of PowerShell command");
}
