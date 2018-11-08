# Support me on Patreon
<a href="https://www.patreon.com/djlastnight" style="font-size:50px">
  <img src="https://c5.patreon.com/external/logo/rebrandLogoIconMark@2x.png"
       height="40"
       style="vertical-align:top" />
  Click here to become a patron and get your reward!
    <img src="https://c5.patreon.com/external/logo/rebrandLogoIconMark@2x.png"
       height="40"
       style="vertical-align:top" />
</a>

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
