README for CS 433 Final Project - Mr. Miner
For code by: Alder French and Adam Case
Summary: This README contains 3 sections, each describes one of the 
programs we used to attempt to crypto mine on the Nvidia GeForce Now platform.

Browser Based Crypto Miner with MintMe
To implement browser CPU mining, we used a service called “MintMe”. “MintMe” offers their own scripts that can easily be embedded on any website, that will mine crypto using the CPU through the browser whenever the script is run. A percentage of the mined revenue goes to MintMe in return for letting us use their script, and the rest goes into our crypto wallet. To use MintMe, we embedded it on Alder’s personal website with a button that starts and stops the script, as opposed to having it run automatically when the site was loaded. That way we could control when our crypto mining script ran. 
MintMe: https://www.mintme.com/
Alder’s Personal Website: https://humanist-bean.github.io/

Drunken Wrestlers Mod #1 - Powershell with system.io
Our first crypto-mining game mod for “Nvidia GeForce Now” was designed for “Drunken Wrestlers 2” with its built in unity mod editor and C# scripts.. The mod contained C# code to start a process given its absolute path with a call to the “System.io” library’s “Process.start()” method that calls the string passed into it in PowerShell. The idea was to pass a string that gave the absolute path to a program like NiceHash that we could add to the mod files. This may have worked, except that the “Drunken Wrestler’s 2” mod editor blocked the compilation of any scripts that contained references to “System.io”. 
Source: https://github.com/humanist-bean/mrminer/blob/main/dw2_powershell/process.cs

Drunken Wrestlers Mod #2 - DLLs and Interop
Our second crypto-mining game mod for “Nvidia GeForce Now” also designed for “Drunken Wrestlers 2”. The idea behind this mod was similar to the first, i.e. use a system library to execute a powershell script. However, since our first mod blocked the usage of C#’s “System.io” library, we tried a workaround by creating a C++ script that is  passed a string and then calls that string with powershell. Then, we compile the C++ script to a .dll whose methods can be imported into a C# script. Finally, we package the .dll, the C# script, and a mining program like NiceHash into a mod. Our C# script calls the .dll method with an absolute path to the NiceHash program, and that starts it from powershell. We tested the mod and it worked with an “Echo hello world” script in powershell, and there was nothing stopping us from including NiceHash in the mod folder. However when we went to test the mod with the “Echo hello world” command in “Nvidia GeForce Now”, we discovered that they didn’t have “Drunken Wrestlers 2” in their library, so we were unable to run our mod on their platform. 
Source: https://github.com/humanist-bean/mrminer/tree/main/dw2_powershell

