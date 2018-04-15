# HidRawData

HidRawData is .NET class library written in C#.
It reads the raw data from HID devices (gamepads, mice, keyboards, etc..)

Using the code from WPF main window is very simple:
```cs
var reader = new HidDataReader(this);
reader.HidDataReceived += this.OnHidDataReceived;
```

Tested under Windows 7 and Windows 10.

WPF application, which uses the current library is available here:  
https://github.com/djlastnight/HidRawDataWatcher  

djlastnight,
2018
