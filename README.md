# HidRawData

HidRawData is .NET class library written in C#.
It reads the raw data from HID devices (gamepads, mice, keyboards, etc..)

Using the code is very simple from WPF main window:
```cs
var reader = new HidDataReader(this);
reader.HidDataReceived += this.OnHidDataReceived;
```

Tested under Windows 7 and Windows 10.

GUI, which uses the current library is available here:  
https://github.com/djlastnight/HidRawDataWatcher  

djlastnight,
2018
