namespace Djlastnight.Win32
{
    public static class Contants
    {
        public const int HCBT_MOVESIZE = 0;
        public const int HCBT_MINMAX = 1;
        public const int HCBT_QS = 2;
        public const int HCBT_CREATEWND = 3;
        public const int HCBT_DESTROYWND = 4;
        public const int HCBT_ACTIVATE = 5;
        public const int HCBT_CLICKSKIPPED = 6;
        public const int HCBT_KEYSKIPPED = 7;
        public const int HCBT_SYSCOMMAND = 8;
        public const int HCBT_SETFOCUS = 9;

        /// HELP_WM_HELP -> 0x000c
        public const int HELP_WM_HELP = 12;

        /// WM_INPUTLANGCHANGEREQUEST -> 0x0050
        public const int WM_INPUTLANGCHANGEREQUEST = 80;

        /// WM_CHOOSEFONT_SETLOGFONT -> (WM_USER + 101)
        public const int WM_CHOOSEFONT_SETLOGFONT = Contants.WM_USER + 101;

        /// WM_CHOOSEFONT_GETLOGFONT -> (WM_USER + 1)
        public const int WM_CHOOSEFONT_GETLOGFONT = Contants.WM_USER + 1;

        /// WM_IME_STARTCOMPOSITION -> 0x010D
        public const int WM_IME_STARTCOMPOSITION = 269;

        /// WM_IME_COMPOSITIONFULL -> 0x0284
        public const int WM_IME_COMPOSITIONFULL = 644;

        /// WM_CHOOSEFONT_SETFLAGS -> (WM_USER + 102)
        public const int WM_CHOOSEFONT_SETFLAGS = Contants.WM_USER + 102;

        /// WM_PSD_YAFULLPAGERECT -> (WM_USER+6)
        public const int WM_PSD_YAFULLPAGERECT = Contants.WM_USER + 6;

        /// WM_IME_ENDCOMPOSITION -> 0x010E
        public const int WM_IME_ENDCOMPOSITION = 270;

        /// WM_WTSSESSION_CHANGE -> 0x02B1
        public const int WM_WTSSESSION_CHANGE = 689;

        /// WM_WINDOWPOSCHANGING -> 0x0046
        public const int WM_WINDOWPOSCHANGING = 70;

        /// WM_PSD_MINMARGINRECT -> (WM_USER+2)
        public const int WM_PSD_MINMARGINRECT = Contants.WM_USER + 2;

        /// WM_PSD_GREEKTEXTRECT -> (WM_USER+4)
        public const int WM_PSD_GREEKTEXTRECT = Contants.WM_USER + 4;

        /// WM_PALETTEISCHANGING -> 0x0310
        public const int WM_PALETTEISCHANGING = 784;

        /// WM_CTLCOLORSCROLLBAR -> 0x0137
        public const int WM_CTLCOLORSCROLLBAR = 311;

        /// WM_WINDOWPOSCHANGED -> 0x0047
        public const int WM_WINDOWPOSCHANGED = 71;

        /// WM_VSCROLLCLIPBOARD -> 0x030A
        public const int WM_VSCROLLCLIPBOARD = 778;

        /// WM_RENDERALLFORMATS -> 0x0306
        public const int WM_RENDERALLFORMATS = 774;

        /// WM_PSD_PAGESETUPDLG -> (WM_USER  )
        public const int WM_PSD_PAGESETUPDLG = Contants.WM_USER;

        /// WM_PSD_FULLPAGERECT -> (WM_USER+1)
        public const int WM_PSD_FULLPAGERECT = Contants.WM_USER + 1;

        /// WM_PSD_ENVSTAMPRECT -> (WM_USER+5)
        public const int WM_PSD_ENVSTAMPRECT = Contants.WM_USER + 5;

        /// WM_HSCROLLCLIPBOARD -> 0x030E
        public const int WM_HSCROLLCLIPBOARD = 782;

        /// WM_DESTROYCLIPBOARD -> 0x0307
        public const int WM_DESTROYCLIPBOARD = 775;

        /// WM_UNINITMENUPOPUP -> 0x0125
        public const int WM_UNINITMENUPOPUP = 293;

        /// WM_QUERYNEWPALETTE -> 0x030F
        public const int WM_QUERYNEWPALETTE = 783;

        /// WM_QUERYENDSESSION -> 0x0011
        public const int WM_QUERYENDSESSION = 17;

        /// WM_NCXBUTTONDBLCLK -> 0x00AD
        public const int WM_NCXBUTTONDBLCLK = 173;

        /// WM_NCRBUTTONDBLCLK -> 0x00A6
        public const int WM_NCRBUTTONDBLCLK = 166;

        /// WM_NCMBUTTONDBLCLK -> 0x00A9
        public const int WM_NCMBUTTONDBLCLK = 169;

        /// WM_NCLBUTTONDBLCLK -> 0x00A3
        public const int WM_NCLBUTTONDBLCLK = 163;

        /// WM_INPUTLANGCHANGE -> 0x0051
        public const int WM_INPUTLANGCHANGE = 81;

        /// WM_IME_COMPOSITION -> 0x010F
        public const int WM_IME_COMPOSITION = 271;

        /// WM_CTLCOLORLISTBOX -> 0x0134
        public const int WM_CTLCOLORLISTBOX = 308;

        /// WM_ASKCBFORMATNAME -> 0x030C
        public const int WM_ASKCBFORMATNAME = 780;

        /// WM_SYSCOLORCHANGE -> 0x0015
        public const int WM_SYSCOLORCHANGE = 21;

        /// WM_PSD_MARGINRECT -> (WM_USER+3)
        public const int WM_PSD_MARGINRECT = Contants.WM_USER + 3;

        /// WM_POWERBROADCAST -> 0x0218
        public const int WM_POWERBROADCAST = 536;

        /// WM_PALETTECHANGED -> 0x0311
        public const int WM_PALETTECHANGED = 785;

        /// WM_PAINTCLIPBOARD -> 0x0309
        public const int WM_PAINTCLIPBOARD = 777;

        /// WM_MDIREFRESHMENU -> 0x0234
        public const int WM_MDIREFRESHMENU = 564;

        /// WM_MDIICONARRANGE -> 0x0228
        public const int WM_MDIICONARRANGE = 552;

        /// WM_IME_SETCONTEXT -> 0x0281
        public const int WM_IME_SETCONTEXT = 641;

        /// WM_ICONERASEBKGND -> 0x0027
        public const int WM_ICONERASEBKGND = 39;

        /// WM_CTLCOLORSTATIC -> 0x0138
        public const int WM_CTLCOLORSTATIC = 312;

        /// WM_CTLCOLORMSGBOX -> 0x0132
        public const int WM_CTLCOLORMSGBOX = 306;

        /// WM_CAPTURECHANGED -> 0x0215
        public const int WM_CAPTURECHANGED = 533;

        /// WM_XBUTTONDBLCLK -> 0x020D
        public const int WM_XBUTTONDBLCLK = 525;

        /// WM_UPDATEUISTATE -> 0x0128
        public const int WM_UPDATEUISTATE = 296;

        /// WM_STYLECHANGING -> 0x007C
        public const int WM_STYLECHANGING = 124;

        /// WM_SPOOLERSTATUS -> 0x002A
        public const int WM_SPOOLERSTATUS = 42;

        /// WM_SIZECLIPBOARD -> 0x030B
        public const int WM_SIZECLIPBOARD = 779;

        /// WM_SETTINGCHANGE -> WM_WININICHANGE
        public const int WM_SETTINGCHANGE = Contants.WM_WININICHANGE;

        /// WM_RBUTTONDBLCLK -> 0x0206
        public const int WM_RBUTTONDBLCLK = 518;

        /// WM_QUERYDRAGICON -> 0x0037
        public const int WM_QUERYDRAGICON = 55;

        /// WM_NCXBUTTONDOWN -> 0x00AB
        public const int WM_NCXBUTTONDOWN = 171;

        /// WM_NCRBUTTONDOWN -> 0x00A4
        public const int WM_NCRBUTTONDOWN = 164;

        /// WM_NCMBUTTONDOWN -> 0x00A7
        public const int WM_NCMBUTTONDOWN = 167;

        /// WM_NCLBUTTONDOWN -> 0x00A1
        public const int WM_NCLBUTTONDOWN = 161;

        /// WM_MOUSEACTIVATE -> 0x0021
        public const int WM_MOUSEACTIVATE = 33;

        /// WM_MENURBUTTONUP -> 0x0122
        public const int WM_MENURBUTTONUP = 290;

        /// WM_MENUGETOBJECT -> 0x0124
        public const int WM_MENUGETOBJECT = 292;

        /// WM_MBUTTONDBLCLK -> 0x0209
        public const int WM_MBUTTONDBLCLK = 521;

        /// WM_LBUTTONDBLCLK -> 0x0203
        public const int WM_LBUTTONDBLCLK = 515;

        /// WM_INITMENUPOPUP -> 0x0117
        public const int WM_INITMENUPOPUP = 279;

        /// WM_HANDHELDFIRST -> 0x0358
        public const int WM_HANDHELDFIRST = 856;

        /// WM_GETTEXTLENGTH -> 0x000E
        public const int WM_GETTEXTLENGTH = 14;

        /// WM_GETMINMAXINFO -> 0x0024
        public const int WM_GETMINMAXINFO = 36;

        /// WM_ENTERSIZEMOVE -> 0x0231
        public const int WM_ENTERSIZEMOVE = 561;

        /// WM_ENTERMENULOOP -> 0x0211
        public const int WM_ENTERMENULOOP = 529;

        /// WM_DRAWCLIPBOARD -> 0x0308
        public const int WM_DRAWCLIPBOARD = 776;

        /// WM_DISPLAYCHANGE -> 0x007E
        public const int WM_DISPLAYCHANGE = 126;

        /// WM_DEVMODECHANGE -> 0x001B
        public const int WM_DEVMODECHANGE = 27;

        /// WM_DDE_TERMINATE -> (WM_DDE_FIRST+1)
        public const int WM_DDE_TERMINATE = Contants.WM_DDE_FIRST + 1;

        /// WM_CHILDACTIVATE -> 0x0022
        public const int WM_CHILDACTIVATE = 34;

        /// WM_CHANGEUISTATE -> 0x0127
        public const int WM_CHANGEUISTATE = 295;

        /// WM_CHANGECBCHAIN -> 0x030D
        public const int WM_CHANGECBCHAIN = 781;

        /// WM_CANCELJOURNAL -> 0x004B
        public const int WM_CANCELJOURNAL = 75;

        /// WM_WININICHANGE -> 0x001A
        public const int WM_WININICHANGE = 26;

        /// WM_THEMECHANGED -> 0x031A
        public const int WM_THEMECHANGED = 794;

        /// WM_TABLET_FIRST -> 0x02c0
        public const int WM_TABLET_FIRST = 704;

        /// WM_STYLECHANGED -> 0x007D
        public const int WM_STYLECHANGED = 125;

        /// WM_RENDERFORMAT -> 0x0305
        public const int WM_RENDERFORMAT = 773;

        /// WM_QUERYUISTATE -> 0x0129
        public const int WM_QUERYUISTATE = 297;

        /// WM_PARENTNOTIFY -> 0x0210
        public const int WM_PARENTNOTIFY = 528;

        /// WM_NOTIFYFORMAT -> 0x0055
        public const int WM_NOTIFYFORMAT = 85;

        /// WM_NCMOUSELEAVE -> 0x02A2
        public const int WM_NCMOUSELEAVE = 674;

        /// WM_NCMOUSEHOVER -> 0x02A0
        public const int WM_NCMOUSEHOVER = 672;

        /// WM_MDIGETACTIVE -> 0x0229
        public const int WM_MDIGETACTIVE = 553;

        /// WM_HANDHELDLAST -> 0x035F
        public const int WM_HANDHELDLAST = 863;

        /// WM_EXITSIZEMOVE -> 0x0232
        public const int WM_EXITSIZEMOVE = 562;

        /// WM_EXITMENULOOP -> 0x0212
        public const int WM_EXITMENULOOP = 530;

        /// WM_DEVICECHANGE -> 0x0219
        public const int WM_DEVICECHANGE = 537;

        /// WM_DDE_UNADVISE -> (WM_DDE_FIRST+3)
        public const int WM_DDE_UNADVISE = Contants.WM_DDE_FIRST + 3;

        /// WM_DDE_INITIATE -> (WM_DDE_FIRST)
        public const int WM_DDE_INITIATE = Contants.WM_DDE_FIRST;

        /// WM_CTLCOLOREDIT -> 0x0133
        public const int WM_CTLCOLOREDIT = 307;

        /// WM_XBUTTONDOWN -> 0x020B
        public const int WM_XBUTTONDOWN = 523;

        /// WM_USERCHANGED -> 0x0054
        public const int WM_USERCHANGED = 84;

        /// WM_TABLET_LAST -> 0x02df
        public const int WM_TABLET_LAST = 735;

        /// WM_SYSDEADCHAR -> 0x0107
        public const int WM_SYSDEADCHAR = 263;

        /// WM_RBUTTONDOWN -> 0x0204
        public const int WM_RBUTTONDOWN = 516;

        /// WM_PRINTCLIENT -> 0x0318
        public const int WM_PRINTCLIENT = 792;

        /// WM_PENWINFIRST -> 0x0380
        public const int WM_PENWINFIRST = 896;

        /// WM_NCXBUTTONUP -> 0x00AC
        public const int WM_NCXBUTTONUP = 172;

        /// WM_NCRBUTTONUP -> 0x00A5
        public const int WM_NCRBUTTONUP = 165;

        /// WM_NCMOUSEMOVE -> 0x00A0
        public const int WM_NCMOUSEMOVE = 160;

        /// WM_NCMBUTTONUP -> 0x00A8
        public const int WM_NCMBUTTONUP = 168;

        /// WM_NCLBUTTONUP -> 0x00A2
        public const int WM_NCLBUTTONUP = 162;

        /// WM_MENUCOMMAND -> 0x0126
        public const int WM_MENUCOMMAND = 294;

        /// WM_MEASUREITEM -> 0x002C
        public const int WM_MEASUREITEM = 44;

        /// WM_MDIMAXIMIZE -> 0x0225
        public const int WM_MDIMAXIMIZE = 549;

        /// WM_MDIACTIVATE -> 0x0222
        public const int WM_MDIACTIVATE = 546;

        /// WM_MBUTTONDOWN -> 0x0207
        public const int WM_MBUTTONDOWN = 519;

        /// WM_LBUTTONDOWN -> 0x0201
        public const int WM_LBUTTONDOWN = 513;

        /// WM_IME_REQUEST -> 0x0288
        public const int WM_IME_REQUEST = 648;

        /// WM_IME_KEYLAST -> 0x010F
        public const int WM_IME_KEYLAST = 271;

        /// WM_IME_KEYDOWN -> 0x0290
        public const int WM_IME_KEYDOWN = 656;

        /// WM_IME_CONTROL -> 0x0283
        public const int WM_IME_CONTROL = 643;

        /// WM_DDE_REQUEST -> (WM_DDE_FIRST+6)
        public const int WM_DDE_REQUEST = Contants.WM_DDE_FIRST + 6;

        /// WM_DDE_EXECUTE -> (WM_DDE_FIRST+8)
        public const int WM_DDE_EXECUTE = Contants.WM_DDE_FIRST + 8;

        /// WM_CTLCOLORDLG -> 0x0136
        public const int WM_CTLCOLORDLG = 310;

        /// WM_CTLCOLORBTN -> 0x0135
        public const int WM_CTLCOLORBTN = 309;

        /// WM_CONTEXTMENU -> 0x007B
        public const int WM_CONTEXTMENU = 123;

        /// WM_COMPAREITEM -> 0x0039
        public const int WM_COMPAREITEM = 57;

        /// WM_ACTIVATEAPP -> 0x001C
        public const int WM_ACTIVATEAPP = 28;

        /// WM_VKEYTOITEM -> 0x002E
        public const int WM_VKEYTOITEM = 46;

        /// WM_TIMECHANGE -> 0x001E
        public const int WM_TIMECHANGE = 30;

        /// WM_SYSKEYDOWN -> 0x0104
        public const int WM_SYSKEYDOWN = 260;

        /// WM_SYSCOMMAND -> 0x0112
        public const int WM_SYSCOMMAND = 274;

        /// WM_SHOWWINDOW -> 0x0018
        public const int WM_SHOWWINDOW = 24;

        /// WM_PENWINLAST -> 0x038F
        public const int WM_PENWINLAST = 911;

        /// WM_NEXTDLGCTL -> 0x0028
        public const int WM_NEXTDLGCTL = 40;

        /// WM_NCCALCSIZE -> 0x0083
        public const int WM_NCCALCSIZE = 131;

        /// WM_NCACTIVATE -> 0x0086
        public const int WM_NCACTIVATE = 134;

        /// WM_MOUSEWHEEL -> 0x020A
        public const int WM_MOUSEWHEEL = 522;

        /// WM_MOUSELEAVE -> 0x02A3
        public const int WM_MOUSELEAVE = 675;

        /// WM_MOUSEHOVER -> 0x02A1
        public const int WM_MOUSEHOVER = 673;

        /// WM_MOUSEFIRST -> 0x0200
        public const int WM_MOUSEFIRST = 512;

        /// WM_MENUSELECT -> 0x011F
        public const int WM_MENUSELECT = 287;

        /// WM_MDISETMENU -> 0x0230
        public const int WM_MDISETMENU = 560;

        /// WM_MDIRESTORE -> 0x0223
        public const int WM_MDIRESTORE = 547;

        /// WM_MDIDESTROY -> 0x0221
        public const int WM_MDIDESTROY = 545;

        /// WM_MDICASCADE -> 0x0227
        public const int WM_MDICASCADE = 551;

        /// WM_INITDIALOG -> 0x0110
        public const int WM_INITDIALOG = 272;

        /// WM_IME_SELECT -> 0x0285
        public const int WM_IME_SELECT = 645;

        /// WM_IME_NOTIFY -> 0x0282
        public const int WM_IME_NOTIFY = 642;

        /// WM_GETDLGCODE -> 0x0087
        public const int WM_GETDLGCODE = 135;

        /// WM_FONTCHANGE -> 0x001D
        public const int WM_FONTCHANGE = 29;

        /// WM_ERASEBKGND -> 0x0014
        public const int WM_ERASEBKGND = 20;

        /// WM_ENDSESSION -> 0x0016
        public const int WM_ENDSESSION = 22;

        /// WM_DELETEITEM -> 0x002D
        public const int WM_DELETEITEM = 45;

        /// WM_DDE_ADVISE -> (WM_DDE_FIRST+2)
        public const int WM_DDE_ADVISE = Contants.WM_DDE_FIRST + 2;

        /// WM_COMPACTING -> 0x0041
        public const int WM_COMPACTING = 65;

        /// WM_COMMNOTIFY -> 0x0044
        public const int WM_COMMNOTIFY = 68;

        /// WM_CHARTOITEM -> 0x002F
        public const int WM_CHARTOITEM = 47;

        /// WM_CANCELMODE -> 0x001F
        public const int WM_CANCELMODE = 31;

        /// WM_APPCOMMAND -> 0x0319
        public const int WM_APPCOMMAND = 793;

        /// WM_XBUTTONUP -> 0x020C
        public const int WM_XBUTTONUP = 524;

        /// WM_SYNCPAINT -> 0x0088
        public const int WM_SYNCPAINT = 136;

        /// WM_SETREDRAW -> 0x000B
        public const int WM_SETREDRAW = 11;

        /// WM_SETHOTKEY -> 0x0032
        public const int WM_SETHOTKEY = 50;

        /// WM_SETCURSOR -> 0x0020
        public const int WM_SETCURSOR = 32;

        /// WM_RBUTTONUP -> 0x0205
        public const int WM_RBUTTONUP = 517;

        /// WM_QUEUESYNC -> 0x0023
        public const int WM_QUEUESYNC = 35;

        /// WM_QUERYOPEN -> 0x0013
        public const int WM_QUERYOPEN = 19;

        /// WM_PAINTICON -> 0x0026
        public const int WM_PAINTICON = 38;

        /// WM_NCHITTEST -> 0x0084
        public const int WM_NCHITTEST = 132;

        /// WM_NCDESTROY -> 0x0082
        public const int WM_NCDESTROY = 130;

        /// WM_MOUSEMOVE -> 0x0200
        public const int WM_MOUSEMOVE = 512;

        /// WM_MOUSELAST -> 0x020D
        public const int WM_MOUSELAST = 525;

        /// WM_MDICREATE -> 0x0220
        public const int WM_MDICREATE = 544;

        /// WM_MBUTTONUP -> 0x0208
        public const int WM_MBUTTONUP = 520;

        /// WM_LBUTTONUP -> 0x0202
        public const int WM_LBUTTONUP = 514;

        /// WM_KILLFOCUS -> 0x0008
        public const int WM_KILLFOCUS = 8;

        /// WM_IME_KEYUP -> 0x0291
        public const int WM_IME_KEYUP = 657;

        /// WM_GETOBJECT -> 0x003D
        public const int WM_GETOBJECT = 61;

        /// WM_GETHOTKEY -> 0x0033
        public const int WM_GETHOTKEY = 51;

        /// WM_ENTERIDLE -> 0x0121
        public const int WM_ENTERIDLE = 289;

        /// WM_DROPFILES -> 0x0233
        public const int WM_DROPFILES = 563;

        /// WM_DDE_FIRST -> 0x03E0
        public const int WM_DDE_FIRST = 992;

        /// WM_SYSKEYUP -> 0x0105
        public const int WM_SYSKEYUP = 261;

        /// WM_SETFOCUS -> 0x0007
        public const int WM_SETFOCUS = 7;

        /// WM_NEXTMENU -> 0x0213
        public const int WM_NEXTMENU = 531;

        /// WM_NCCREATE -> 0x0081
        public const int WM_NCCREATE = 129;

        /// WM_MENUDRAG -> 0x0123
        public const int WM_MENUDRAG = 291;

        /// WM_MENUCHAR -> 0x0120
        public const int WM_MENUCHAR = 288;

        /// WM_KEYFIRST -> 0x0100
        public const int WM_KEYFIRST = 256;

        /// WM_INITMENU -> 0x0116
        public const int WM_INITMENU = 278;

        /// WM_IME_CHAR -> 0x0286
        public const int WM_IME_CHAR = 646;

        /// WM_DRAWITEM -> 0x002B
        public const int WM_DRAWITEM = 43;

        /// WM_DEADCHAR -> 0x0103
        public const int WM_DEADCHAR = 259;

        /// WM_DDE_POKE -> (WM_DDE_FIRST+7)
        public const int WM_DDE_POKE = Contants.WM_DDE_FIRST + 7;

        /// WM_DDE_LAST -> (WM_DDE_FIRST+8)
        public const int WM_DDE_LAST = Contants.WM_DDE_FIRST + 8;

        /// WM_DDE_DATA -> (WM_DDE_FIRST+5)
        public const int WM_DDE_DATA = Contants.WM_DDE_FIRST + 5;

        /// WM_COPYDATA -> 0x004A
        public const int WM_COPYDATA = 74;

        /// WM_AFXFIRST -> 0x0360
        public const int WM_AFXFIRST = 864;

        /// WM_ACTIVATE -> 0x0006
        public const int WM_ACTIVATE = 6;

        /// WM_VSCROLL -> 0x0115
        public const int WM_VSCROLL = 277;

        /// WM_UNICHAR -> 0x0109
        public const int WM_UNICHAR = 265;

        /// WM_SYSCHAR -> 0x0106
        public const int WM_SYSCHAR = 262;

        /// WM_SETTEXT -> 0x000C
        public const int WM_SETTEXT = 12;

        /// WM_SETICON -> 0x0080
        public const int WM_SETICON = 128;

        /// WM_SETFONT -> 0x0030
        public const int WM_SETFONT = 48;

        /// WM_NCPAINT -> 0x0085
        public const int WM_NCPAINT = 133;

        /// WM_MDITILE -> 0x0226
        public const int WM_MDITILE = 550;

        /// WM_MDINEXT -> 0x0224
        public const int WM_MDINEXT = 548;

        /// WM_KEYLAST -> 0x0109
        public const int WM_KEYLAST = 265;

        /// WM_KEYDOWN -> 0x0100
        public const int WM_KEYDOWN = 256;

        /// WM_HSCROLL -> 0x0114
        public const int WM_HSCROLL = 276;

        /// WM_GETTEXT -> 0x000D
        public const int WM_GETTEXT = 13;

        /// WM_GETICON -> 0x007F
        public const int WM_GETICON = 127;

        /// WM_GETFONT -> 0x0031
        public const int WM_GETFONT = 49;

        /// WM_DESTROY -> 0x0002
        public const int WM_DESTROY = 2;

        /// WM_DDE_ACK -> (WM_DDE_FIRST+4)
        public const int WM_DDE_ACK = Contants.WM_DDE_FIRST + 4;

        /// WM_COMMAND -> 0x0111
        public const int WM_COMMAND = 273;

        /// WM_AFXLAST -> 0x037F
        public const int WM_AFXLAST = 895;

        /// WM_SIZING -> 0x0214
        public const int WM_SIZING = 532;

        /// WM_NOTIFY -> 0x004E
        public const int WM_NOTIFY = 78;

        /// WM_MOVING -> 0x0216
        public const int WM_MOVING = 534;

        /// WM_HOTKEY -> 0x0312
        public const int WM_HOTKEY = 786;

        /// WM_ENABLE -> 0x000A
        public const int WM_ENABLE = 10;

        /// WM_CREATE -> 0x0001
        public const int WM_CREATE = 1;

        /// WM_TIMER -> 0x0113
        public const int WM_TIMER = 275;

        /// WM_TCARD -> 0x0052
        public const int WM_TCARD = 82;

        /// WM_PRINT -> 0x0317
        public const int WM_PRINT = 791;

        /// WM_POWER -> 0x0048
        public const int WM_POWER = 72;

        /// WM_PASTE -> 0x0302
        public const int WM_PASTE = 770;

        /// WM_PAINT -> 0x000F
        public const int WM_PAINT = 15;

        /// WM_KEYUP -> 0x0101
        public const int WM_KEYUP = 257;

        /// WM_INPUT -> 0x00FF
        public const int WM_INPUT = 255;

        /// WM_CLOSE -> 0x0010
        public const int WM_CLOSE = 16;

        /// WM_CLEAR -> 0x0303
        public const int WM_CLEAR = 771;

        /// WM_USER -> 0x0400
        public const int WM_USER = 1024;

        /// WM_UNDO -> 0x0304
        public const int WM_UNDO = 772;

        /// WM_SIZE -> 0x0005
        public const int WM_SIZE = 5;

        /// WM_QUIT -> 0x0012
        public const int WM_QUIT = 18;

        /// WM_NULL -> 0x0000
        public const int WM_NULL = 0;

        /// WM_MOVE -> 0x0003
        public const int WM_MOVE = 3;

        /// WM_HELP -> 0x0053
        public const int WM_HELP = 83;

        /// WM_COPY -> 0x0301
        public const int WM_COPY = 769;

        /// WM_CUT -> 0x0300
        public const int WM_CUT = 768;

        /// WM_APP -> 0x8000
        public const int WM_APP = 32768;

        /// WM_CHAR -> 0x0102
        public const int WM_CHAR = 258;

        public const int RID_INPUT = 0x10000003;
        public const int RID_HEADER = 0x10000005;

        /// <summary>
        /// Possible value taken by wParam for WM_INPUT.
        /// <para />
        /// Input occurred while the application was in the foreground. The application must call DefWindowProc so the system can perform cleanup.
        /// </summary>
        public const int RIM_INPUT = 0;

        /// <summary>
        /// Possible value taken by wParam for WM_INPUT.
        /// <para />
        /// Input occurred while the application was not in the foreground. The application must call DefWindowProc so the system can perform the cleanup.
        /// </summary>
        public const int RIM_INPUTSINK = 1;

        /// <summary>
        /// This value can be taken by RAWKEYBOARD.MakeCode.
        /// </summary>
        public const ushort KEYBOARD_OVERRUN_MAKE_CODE = 0x00FF;

        public const int APPCOMMAND_BROWSER_BACKWARD = 1;
        public const int APPCOMMAND_VOLUME_MUTE = 8;
        public const int APPCOMMAND_VOLUME_DOWN = 9;
        public const int APPCOMMAND_VOLUME_UP = 10;
        public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;
        public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;
        public const int APPCOMMAND_MEDIA_STOP = 13;
        public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;
        public const int APPCOMMAND_MEDIA_PLAY = 46;
        public const int APPCOMMAND_MEDIA_PAUSE = 47;
        public const int APPCOMMAND_MEDIA_RECORD = 48;
        public const int APPCOMMAND_MEDIA_FAST_FORWARD = 49;
        public const int APPCOMMAND_MEDIA_REWIND = 50;
        public const int APPCOMMAND_MEDIA_CHANNEL_UP = 51;
        public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 52;

        public const int FAPPCOMMAND_MASK = 0xF000;
        public const int FAPPCOMMAND_MOUSE = 0x8000;
        public const int FAPPCOMMAND_KEY = 0;
        public const int FAPPCOMMAND_OEM = 0x1000;

        public const uint FSCTL_REQUEST_OPLOCK_LEVEL_1 = 0x00090000;
        public const uint FSCTL_REQUEST_OPLOCK_LEVEL_2 = 0x00090004;
        public const uint FSCTL_REQUEST_BATCH_OPLOCK = 0x00090008;
        public const uint FSCTL_OPLOCK_BREAK_ACKNOWLEDGE = 0x0009000c;
        public const uint FSCTL_OPBATCH_ACK_CLOSE_PENDING = 0x00090010;
        public const uint FSCTL_OPLOCK_BREAK_NOTIFY = 0x00090014;
        public const uint FSCTL_LOCK_VOLUME = 0x00090018;
        public const uint FSCTL_UNLOCK_VOLUME = 0x0009001c;
        public const uint FSCTL_DISMOUNT_VOLUME = 0x00090020;
        public const uint FSCTL_IS_VOLUME_MOUNTED = 0x00090028;
        public const uint FSCTL_IS_PATHNAME_VALID = 0x0009002c;
        public const uint FSCTL_MARK_VOLUME_DIRTY = 0x00090030;
        public const uint FSCTL_QUERY_RETRIEVAL_POINTERS = 0x0009003b;
        public const uint FSCTL_GET_COMPRESSION = 0x0009003c;
        public const uint FSCTL_SET_COMPRESSION = 0x00090040;
        public const uint FSCTL_MARK_AS_SYSTEM_HIVE = 0x0009004f;
        public const uint FSCTL_OPLOCK_BREAK_ACK_NO_2 = 0x00090050;
        public const uint FSCTL_INVALIDATE_VOLUMES = 0x00090054;
        public const uint FSCTL_QUERY_FAT_BPB = 0x00090058;
        public const uint FSCTL_REQUEST_FILTER_OPLOCK = 0x0009005c;
        public const uint FSCTL_FILESYSTEM_GET_STATISTICS = 0x00090060;
        public const uint FSCTL_GET_NTFS_VOLUME_DATA = 0x00090064;
        public const uint FSCTL_GET_NTFS_FILE_RECORD = 0x00090068;
        public const uint FSCTL_GET_VOLUME_BITMAP = 0x0009006f;
        public const uint FSCTL_GET_RETRIEVAL_POINTERS = 0x00090073;
        public const uint FSCTL_MOVE_FILE = 0x00090074;
        public const uint FSCTL_IS_VOLUME_DIRTY = 0x00090078;
        public const uint FSCTL_ALLOW_EXTENDED_DASD_IO = 0x00090083;
        public const uint FSCTL_FIND_FILES_BY_SID = 0x0009008f;
        public const uint FSCTL_SET_OBJECT_ID = 0x00090098;
        public const uint FSCTL_GET_OBJECT_ID = 0x0009009c;
        public const uint FSCTL_DELETE_OBJECT_ID = 0x000900a0;
        public const uint FSCTL_SET_REPARSE_POINT = 0x000900a4;
        public const uint FSCTL_GET_REPARSE_POINT = 0x000900a8;
        public const uint FSCTL_DELETE_REPARSE_POINT = 0x000900ac;
        public const uint FSCTL_ENUM_USN_DATA = 0x000900b3;
        public const uint FSCTL_SECURITY_ID_CHECK = 0x000940b7;
        public const uint FSCTL_READ_USN_JOURNAL = 0x000900bb;
        public const uint FSCTL_SET_OBJECT_ID_EXTENDED = 0x000900bc;
        public const uint FSCTL_CREATE_OR_GET_OBJECT_ID = 0x000900c0;
        public const uint FSCTL_SET_SPARSE = 0x000900c4;
        public const uint FSCTL_SET_ZERO_DATA = 0x000980c8;
        public const uint FSCTL_QUERY_ALLOCATED_RANGES = 0x000940cf;
        public const uint FSCTL_SET_ENCRYPTION = 0x000900d7;
        public const uint FSCTL_ENCRYPTION_FSCTL_IO = 0x000900db;
        public const uint FSCTL_WRITE_RAW_ENCRYPTED = 0x000900df;
        public const uint FSCTL_READ_RAW_ENCRYPTED = 0x000900e3;
        public const uint FSCTL_CREATE_USN_JOURNAL = 0x000900e7;
        public const uint FSCTL_READ_FILE_USN_DATA = 0x000900eb;
        public const uint FSCTL_WRITE_USN_CLOSE_RECORD = 0x000900ef;
        public const uint FSCTL_EXTEND_VOLUME = 0x000900f0;
        public const uint FSCTL_QUERY_USN_JOURNAL = 0x000900f4;
        public const uint FSCTL_DELETE_USN_JOURNAL = 0x000900f8;
        public const uint FSCTL_MARK_HANDLE = 0x000900fc;
        public const uint FSCTL_SIS_COPYFILE = 0x00090100;
        public const uint FSCTL_SIS_LINK_FILES = 0x0009c104;
        public const uint FSCTL_HSM_MSG = 0x0009c108;
        public const uint FSCTL_HSM_DATA = 0x0009c113;
        public const uint FSCTL_RECALL_FILE = 0x00090117;
        public const uint FSCTL_READ_FROM_PLEX = 0x0009411e;
        public const uint FSCTL_FILE_PREFETCH = 0x00090120;

        public const uint IOCTL_1394_CLASS = 0x22021d;
        public const uint IOCTL_1394_TOGGLE_ENUM_TEST_OFF = 0x220224;
        public const uint IOCTL_1394_TOGGLE_ENUM_TEST_ON = 0x220220;
        public const uint IOCTL_61883_CLASS = 0x220245;
        public const uint IOCTL_AACS_END_SESSION = 0x3350cc;
        public const uint IOCTL_AACS_GENERATE_BINDING_NONCE = 0x33d0f0;
        public const uint IOCTL_AACS_GET_CERTIFICATE = 0x3350d4;
        public const uint IOCTL_AACS_GET_CHALLENGE_KEY = 0x3350d8;
        public const uint IOCTL_AACS_READ_BINDING_NONCE = 0x3350ec;
        public const uint IOCTL_AACS_READ_MEDIA_ID = 0x3350e8;
        public const uint IOCTL_AACS_READ_MEDIA_KEY_BLOCK = 0x3350c4;
        public const uint IOCTL_AACS_READ_MEDIA_KEY_BLOCK_SIZE = 0x3350c0;
        public const uint IOCTL_AACS_READ_SERIAL_NUMBER = 0x3350e4;
        public const uint IOCTL_AACS_READ_VOLUME_ID = 0x3350e0;
        public const uint IOCTL_AACS_SEND_CERTIFICATE = 0x3350d0;
        public const uint IOCTL_AACS_SEND_CHALLENGE_KEY = 0x3350dc;
        public const uint IOCTL_AACS_START_SESSION = 0x3350c8;
        public const uint IOCTL_ABORT_PIPE = 0x80002004;
        public const uint IOCTL_ACPI_ACQUIRE_GLOBAL_LOCK = 0x32c010;
        public const uint IOCTL_ACPI_ASYNC_EVAL_METHOD = 0x32c000;
        public const uint IOCTL_ACPI_ASYNC_EVAL_METHOD_EX = 0x32c01c;
        public const uint IOCTL_ACPI_ENUM_CHILDREN = 0x32c020;
        public const uint IOCTL_ACPI_EVAL_METHOD = 0x32c004;
        public const uint IOCTL_ACPI_EVAL_METHOD_EX = 0x32c018;
        public const uint IOCTL_ACPI_RELEASE_GLOBAL_LOCK = 0x32c014;
        public const uint IOCTL_ARP_SEND_REQUEST = 0x67;
        public const uint IOCTL_ATA_MINIPORT = 0x4d034;
        public const uint IOCTL_ATA_PASS_THROUGH = 0x4d02c;
        public const uint IOCTL_ATA_PASS_THROUGH_DIRECT = 0x4d030;
        public const uint IOCTL_AVCSTRM_CLASS = 0x22024d;
        public const uint IOCTL_AVC_BUS_RESET = 0x2a0008;
        public const uint IOCTL_AVC_CLASS = 0x220248;
        public const uint IOCTL_AVC_REMOVE_VIRTUAL_SUBUNIT_INFO = 0x2a0004;
        public const uint IOCTL_AVC_UPDATE_VIRTUAL_SUBUNIT_INFO = 0x2a0000;
        public const uint IOCTL_AVIO_ALLOCATE_STREAM = 0xff0004;
        public const uint IOCTL_AVIO_FREE_STREAM = 0xff0008;
        public const uint IOCTL_AVIO_MODIFY_STREAM = 0xff000c;
        public const uint IOCTL_BATTERY_QUERY_INFORMATION = 0x294044;
        public const uint IOCTL_BATTERY_QUERY_STATUS = 0x29404c;
        public const uint IOCTL_BATTERY_QUERY_TAG = 0x294040;
        public const uint IOCTL_BATTERY_SET_INFORMATION = 0x298048;
        public const uint IOCTL_BEEP_SET = 0x10000;
        public const uint IOCTL_BIOMETRIC_CALIBRATE = 0x44000c;
        public const uint IOCTL_BIOMETRIC_CAPTURE_DATA = 0x440014;
        public const uint IOCTL_BIOMETRIC_GET_ATTRIBUTES = 0x440004;
        public const uint IOCTL_BIOMETRIC_GET_INDICATOR = 0x440020;
        public const uint IOCTL_BIOMETRIC_GET_SENSOR_STATUS = 0x440010;
        public const uint IOCTL_BIOMETRIC_GET_SUPPORTED_ALGORITHMS = 0x44001c;
        public const uint IOCTL_BIOMETRIC_RESET = 0x440008;
        public const uint IOCTL_BIOMETRIC_SET_INDICATOR = 0x440024;
        public const uint IOCTL_BIOMETRIC_UPDATE_FIRMWARE = 0x440018;
        public const uint IOCTL_BIOMETRIC_VENDOR = 0x442000;
        public const uint IOCTL_BTH_DISCONNECT_DEVICE = 0x41000c;
        public const uint IOCTL_BTH_EIR_GET_RECORDS = 0x410040;
        public const uint IOCTL_BTH_EIR_REMOVE_RECORD = 0x41004c;
        public const uint IOCTL_BTH_EIR_SUBMIT_RECORD = 0x410044;
        public const uint IOCTL_BTH_EIR_UPDATE_RECORD = 0x410048;
        public const uint IOCTL_BTH_GET_DEVICE_INFO = 0x410008;
        public const uint IOCTL_BTH_GET_DEVICE_RSSI = 0x410014;
        public const uint IOCTL_BTH_GET_LOCAL_INFO = 0x410000;
        public const uint IOCTL_BTH_GET_RADIO_INFO = 0x410004;
        public const uint IOCTL_BTH_HCI_VENDOR_COMMAND = 0x410050;
        public const uint IOCTL_BTH_SDP_ATTRIBUTE_SEARCH = 0x41020c;
        public const uint IOCTL_BTH_SDP_CONNECT = 0x410200;
        public const uint IOCTL_BTH_SDP_DISCONNECT = 0x410204;
        public const uint IOCTL_BTH_SDP_REMOVE_RECORD = 0x410218;
        public const uint IOCTL_BTH_SDP_SERVICE_ATTRIBUTE_SEARCH = 0x410210;
        public const uint IOCTL_BTH_SDP_SERVICE_SEARCH = 0x410208;
        public const uint IOCTL_BTH_SDP_SUBMIT_RECORD = 0x410214;
        public const uint IOCTL_BTH_SDP_SUBMIT_RECORD_WITH_INFO = 0x41021c;
        public const uint IOCTL_CANCEL_DEVICE_WAKE = 0x298008;
        public const uint IOCTL_CANCEL_GET_SEND_MESSAGE = 0x2b0038;
        public const uint IOCTL_CANCEL_IO = 0x80002004;
        public const uint IOCTL_CDROM_CHECK_VERIFY = 0x24800;
        public const uint IOCTL_CDROM_CURRENT_POSITION = 0x1;
        public const uint IOCTL_CDROM_DISK_TYPE = 0x20040;
        public const uint IOCTL_CDROM_EJECT_MEDIA = 0x24808;
        public const uint IOCTL_CDROM_ENABLE_STREAMING = 0x24068;
        public const uint IOCTL_CDROM_EXCLUSIVE_ACCESS = 0x2c05c;
        public const uint IOCTL_CDROM_FIND_NEW_DEVICES = 0x24818;
        public const uint IOCTL_CDROM_GET_CONFIGURATION = 0x24058;
        public const uint IOCTL_CDROM_GET_CONTROL = 0x24034;
        public const uint IOCTL_CDROM_GET_DRIVE_GEOMETRY = 0x2404c;
        public const uint IOCTL_CDROM_GET_DRIVE_GEOMETRY_EX = 0x24050;
        public const uint IOCTL_CDROM_GET_INQUIRY_DATA = 0x24064;
        public const uint IOCTL_CDROM_GET_LAST_SESSION = 0x24038;
        public const uint IOCTL_CDROM_GET_PERFORMANCE = 0x24070;
        public const uint IOCTL_CDROM_GET_VOLUME = 0x24014;
        public const uint IOCTL_CDROM_LOAD_MEDIA = 0x2480c;
        public const uint IOCTL_CDROM_MEDIA_CATALOG = 0x2;
        public const uint IOCTL_CDROM_MEDIA_REMOVAL = 0x24804;
        public const uint IOCTL_CDROM_PAUSE_AUDIO = 0x2400c;
        public const uint IOCTL_CDROM_PLAY_AUDIO_MSF = 0x24018;
        public const uint IOCTL_CDROM_RAW_READ = 0x2403e;
        public const uint IOCTL_CDROM_READ_Q_CHANNEL = 0x2402c;
        public const uint IOCTL_CDROM_READ_TOC = 0x24000;
        public const uint IOCTL_CDROM_READ_TOC_EX = 0x24054;
        public const uint IOCTL_CDROM_RELEASE = 0x24814;
        public const uint IOCTL_CDROM_RESERVE = 0x24810;
        public const uint IOCTL_CDROM_RESUME_AUDIO = 0x24010;
        public const uint IOCTL_CDROM_SEEK_AUDIO_MSF = 0x24004;
        public const uint IOCTL_CDROM_SEND_OPC_INFORMATION = 0x2c06c;
        public const uint IOCTL_CDROM_SET_SPEED = 0x24060;
        public const uint IOCTL_CDROM_SET_VOLUME = 0x24028;
        public const uint IOCTL_CDROM_SIMBAD = 0x2400c;
        public const uint IOCTL_CDROM_STOP_AUDIO = 0x24008;
        public const uint IOCTL_CDROM_SUB_Q_CHANNEL = 0x0;
        public const uint IOCTL_CDROM_TRACK_ISRC = 0x3;
        public const uint IOCTL_CDROM_UNLOAD_DRIVER = 0x25008;
        public const uint IOCTL_CHANGER_EXCHANGE_MEDIUM = 0x304020;
        public const uint IOCTL_CHANGER_GET_ELEMENT_STATUS = 0x30c014;
        public const uint IOCTL_CHANGER_GET_PARAMETERS = 0x304000;
        public const uint IOCTL_CHANGER_GET_PRODUCT_DATA = 0x304008;
        public const uint IOCTL_CHANGER_GET_STATUS = 0x304004;
        public const uint IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS = 0x304018;
        public const uint IOCTL_CHANGER_MOVE_MEDIUM = 0x304024;
        public const uint IOCTL_CHANGER_QUERY_VOLUME_TAGS = 0x30c02c;
        public const uint IOCTL_CHANGER_REINITIALIZE_TRANSPORT = 0x304028;
        public const uint IOCTL_CHANGER_SET_ACCESS = 0x30c010;
        public const uint IOCTL_CHANGER_SET_POSITION = 0x30401c;
        public const uint IOCTL_DISK_CHECK_VERIFY = 0x74800;
        public const uint IOCTL_DISK_CONTROLLER_NUMBER = 0x70044;
        public const uint IOCTL_DISK_COPY_DATA = 0x7c064;
        public const uint IOCTL_DISK_CREATE_DISK = 0x7c058;
        public const uint IOCTL_DISK_DELETE_DRIVE_LAYOUT = 0x7c100;
        public const uint IOCTL_DISK_EJECT_MEDIA = 0x74808;
        public const uint IOCTL_DISK_FIND_NEW_DEVICES = 0x74818;
        public const uint IOCTL_DISK_FORMAT_DRIVE = 0x7c3cc;
        public const uint IOCTL_DISK_FORMAT_TRACKS = 0x7c018;
        public const uint IOCTL_DISK_FORMAT_TRACKS_EX = 0x7c02c;
        public const uint IOCTL_DISK_GET_CACHE_INFORMATION = 0x740d4;
        public const uint IOCTL_DISK_GET_CACHE_SETTING = 0x740e0;
        public const uint IOCTL_DISK_GET_DISK_ATTRIBUTES = 0x700f0;
        public const uint IOCTL_DISK_GET_DRIVE_GEOMETRY = 0x70000;
        public const uint IOCTL_DISK_GET_DRIVE_GEOMETRY_EX = 0x700a0;
        public const uint IOCTL_DISK_GET_DRIVE_LAYOUT = 0x7400c;
        public const uint IOCTL_DISK_GET_DRIVE_LAYOUT_EX = 0x70050;
        public const uint IOCTL_DISK_GET_LENGTH_INFO = 0x7405c;
        public const uint IOCTL_DISK_GET_MEDIA_TYPES = 0x70c00;
        public const uint IOCTL_DISK_GET_PARTITION_ATTRIBUTES = 0x700e8;
        public const uint IOCTL_DISK_GET_PARTITION_INFO = 0x74004;
        public const uint IOCTL_DISK_GET_PARTITION_INFO_EX = 0x70048;
        public const uint IOCTL_DISK_GET_SAN_SETTINGS = 0x74200;
        public const uint IOCTL_DISK_GET_SNAPSHOT_INFO = 0x74208;
        public const uint IOCTL_DISK_GET_WRITE_CACHE_STATE = 0x740dc;
        public const uint IOCTL_DISK_GROW_PARTITION = 0x7c0d0;
        public const uint IOCTL_DISK_HISTOGRAM_DATA = 0x70034;
        public const uint IOCTL_DISK_HISTOGRAM_RESET = 0x70038;
        public const uint IOCTL_DISK_HISTOGRAM_STRUCTURE = 0x70030;
        public const uint IOCTL_DISK_INTERNAL_CLEAR_VERIFY = 0x70407;
        public const uint IOCTL_DISK_INTERNAL_SET_NOTIFY = 0x70408;
        public const uint IOCTL_DISK_INTERNAL_SET_VERIFY = 0x70403;
        public const uint IOCTL_DISK_IS_CLUSTERED = 0x700f8;
        public const uint IOCTL_DISK_IS_WRITABLE = 0x70024;
        public const uint IOCTL_DISK_LOAD_MEDIA = 0x7480c;
        public const uint IOCTL_DISK_LOGGING = 0x70028;
        public const uint IOCTL_DISK_MEDIA_REMOVAL = 0x74804;
        public const uint IOCTL_DISK_PERFORMANCE = 0x70020;
        public const uint IOCTL_DISK_PERFORMANCE_OFF = 0x70060;
        public const uint IOCTL_DISK_REASSIGN_BLOCKS = 0x7c01c;
        public const uint IOCTL_DISK_REASSIGN_BLOCKS_EX = 0x7c0a4;
        public const uint IOCTL_DISK_RELEASE = 0x74814;
        public const uint IOCTL_DISK_REQUEST_DATA = 0x70040;
        public const uint IOCTL_DISK_REQUEST_STRUCTURE = 0x7003c;
        public const uint IOCTL_DISK_RESERVE = 0x74810;
        public const uint IOCTL_DISK_RESET_SNAPSHOT_INFO = 0x7c210;
        public const uint IOCTL_DISK_SENSE_DEVICE = 0x703e0;
        public const uint IOCTL_DISK_SET_CACHE_INFORMATION = 0x7c0d8;
        public const uint IOCTL_DISK_SET_CACHE_SETTING = 0x7c0e4;
        public const uint IOCTL_DISK_SET_DISK_ATTRIBUTES = 0x7c0f4;
        public const uint IOCTL_DISK_SET_DRIVE_LAYOUT = 0x7c010;
        public const uint IOCTL_DISK_SET_DRIVE_LAYOUT_EX = 0x7c054;
        public const uint IOCTL_DISK_SET_PARTITION_ATTRIBUTES = 0x7c0ec;
        public const uint IOCTL_DISK_SET_PARTITION_INFO = 0x7c008;
        public const uint IOCTL_DISK_SET_PARTITION_INFO_EX = 0x7c04c;
        public const uint IOCTL_DISK_SET_SAN_SETTINGS = 0x7c204;
        public const uint IOCTL_DISK_SET_SNAPSHOT_INFO = 0x7c20c;
        public const uint IOCTL_DISK_SIMBAD = 0x7d000;
        public const uint IOCTL_DISK_UPDATE_DRIVE_SIZE = 0x7c0c8;
        public const uint IOCTL_DISK_UPDATE_PROPERTIES = 0x70140;
        public const uint IOCTL_DISK_VERIFY = 0x70014;
        public const uint IOCTL_DOT4_ADD_ACTIVITY_BROADCAST = 0x3a2014;
        public const uint IOCTL_DOT4_CLOSE_CHANNEL = 0x3a2008;
        public const uint IOCTL_DOT4_CREATE_SOCKET = 0x3a2022;
        public const uint IOCTL_DOT4_DESTROY_SOCKET = 0x3a202a;
        public const uint IOCTL_DOT4_LAST = 0x80a;
        public const uint IOCTL_DOT4_OPEN_CHANNEL = 0x3a2006;
        public const uint IOCTL_DOT4_READ = 0x3a200e;
        public const uint IOCTL_DOT4_REMOVE_ACTIVITY_BROADCAST = 0x3a2018;
        public const uint IOCTL_DOT4_WAIT_ACTIVITY_BROADCAST = 0x3a201e;
        public const uint IOCTL_DOT4_WAIT_FOR_CHANNEL = 0x3a2026;
        public const uint IOCTL_DOT4_WRITE = 0x3a2011;
        public const uint IOCTL_DVD_END_SESSION = 0x33500c;
        public const uint IOCTL_DVD_GET_REGION = 0x335014;
        public const uint IOCTL_DVD_READ_KEY = 0x335004;
        public const uint IOCTL_DVD_READ_STRUCTURE = 0x335140;
        public const uint IOCTL_DVD_SEND_KEY = 0x335008;
        public const uint IOCTL_DVD_SEND_KEY2 = 0x33d018;
        public const uint IOCTL_DVD_SET_READ_AHEAD = 0x335010;
        public const uint IOCTL_DVD_START_SESSION = 0x335000;
        public const uint IOCTL_EHSTOR_DEVICE_ENUMERATE_PDOS = 0x2d1410;
        public const uint IOCTL_EHSTOR_DEVICE_GET_AUTHZ_STATE = 0x2d1408;
        public const uint IOCTL_EHSTOR_DEVICE_SET_AUTHZ_STATE = 0x2d1404;
        public const uint IOCTL_EHSTOR_DEVICE_SILO_COMMAND = 0x2d140c;
        public const uint IOCTL_ENTER_PRIORITY_RECEIVE = 0x0000;
        public const uint IOCTL_FSVIDEO_COPY_FRAME_BUFFER = 0x340800;
        public const uint IOCTL_FSVIDEO_REVERSE_MOUSE_POINTER = 0x340808;
        public const uint IOCTL_FSVIDEO_SET_CURRENT_MODE = 0x34080c;
        public const uint IOCTL_FSVIDEO_SET_CURSOR_POSITION = 0x340814;
        public const uint IOCTL_FSVIDEO_SET_SCREEN_INFORMATION = 0x340810;
        public const uint IOCTL_FSVIDEO_WRITE_TO_FRAME_BUFFER = 0x340804;
        public const uint IOCTL_GET_CHANNEL_ALIGN_RQST = 0x80002014;
        public const uint IOCTL_GET_DEVICE_DESCRIPTOR = 0x80002018;
        public const uint IOCTL_GET_HCD_DRIVERKEY_NAME = 0x220424;
        public const uint IOCTL_GET_NUM_DEVICE_INPUT_BUFFERS = 0xb01a0;
        public const uint IOCTL_GET_PHYSICAL_DESCRIPTOR = 0xb019a;
        public const uint IOCTL_GET_PIPE_CONFIGURATION = 0x80002028;
        public const uint IOCTL_GET_PROCESSOR_OBJ_INFO = 0x294180;
        public const uint IOCTL_GET_SYS_BUTTON_CAPS = 0x294140;
        public const uint IOCTL_GET_SYS_BUTTON_EVENT = 0x294144;
        public const uint IOCTL_GET_TUPLE_DATA = 0x42ee0;
        public const uint IOCTL_GET_USB_DESCRIPTOR = 0x80002020;
        public const uint IOCTL_GET_VERSION = 0x80002000;
        public const uint IOCTL_HID_ACTIVATE_DEVICE = 0xb001f;
        public const uint IOCTL_HID_DEACTIVATE_DEVICE = 0xb0023;
        public const uint IOCTL_HID_DISABLE_SECURE_READ = 0xb020f;
        public const uint IOCTL_HID_ENABLE_SECURE_READ = 0xb020b;
        public const uint IOCTL_HID_FLUSH_QUEUE = 0xb0197;
        public const uint IOCTL_HID_GET_COLLECTION_DESCRIPTOR = 0xb0193;
        public const uint IOCTL_HID_GET_COLLECTION_INFORMATION = 0xb01a8;
        public const uint IOCTL_HID_GET_DEVICE_ATTRIBUTES = 0xb0027;
        public const uint IOCTL_HID_GET_DEVICE_DESCRIPTOR = 0xb0003;
        public const uint IOCTL_HID_GET_DRIVER_CONFIG = 0xb0190;
        public const uint IOCTL_HID_GET_FEATURE = 0xb0192;
        public const uint IOCTL_HID_GET_FRIENDLY_NAME = 0x0000;
        public const uint IOCTL_HID_GET_HARDWARE_ID = 0xb019e;
        public const uint IOCTL_HID_GET_INDEXED_STRING = 0xb01e2;
        public const uint IOCTL_HID_GET_INPUT_REPORT = 0xb01a2;
        public const uint IOCTL_HID_GET_MANUFACTURER_STRING = 0xb01ba;
        public const uint IOCTL_HID_GET_MS_GENRE_DESCRIPTOR = 0xb01e6;
        public const uint IOCTL_HID_GET_POLL_FREQUENCY_MSEC = 0xb0198;
        public const uint IOCTL_HID_GET_PRODUCT_STRING = 0xb01be;
        public const uint IOCTL_HID_GET_REPORT_DESCRIPTOR = 0xb0007;
        public const uint IOCTL_HID_GET_SERIALNUMBER_STRING = 0xb01c2;
        public const uint IOCTL_HID_GET_STRING = 0xb0013;
        public const uint IOCTL_HID_READ_REPORT = 0xb000b;
        public const uint IOCTL_HID_SEND_IDLE_NOTIFICATION_REQUEST = 0xb002b;
        public const uint IOCTL_HID_SET_DRIVER_CONFIG = 0xb0194;
        public const uint IOCTL_HID_SET_FEATURE = 0xb0191;
        public const uint IOCTL_HID_SET_OUTPUT_REPORT = 0xb0195;
        public const uint IOCTL_HID_SET_POLL_FREQUENCY_MSEC = 0xb019c;
        public const uint IOCTL_HID_WRITE_REPORT = 0xb000f;
        public const uint IOCTL_IDE_PASS_THROUGH = 0x4d028;
        public const uint IOCTL_IEEE1284_GET_MODE = 0x160014;
        public const uint IOCTL_IEEE1284_NEGOTIATE = 0x160018;
        public const uint IOCTL_IEEE1394_API_REQUEST = 0x220400;
        public const uint IOCTL_INTERNAL_BTHENUM_GET_DEVINFO = 0x41000b;
        public const uint IOCTL_INTERNAL_BTHENUM_GET_ENUMINFO = 0x410007;
        public const uint IOCTL_INTERNAL_BTH_SUBMIT_BRB = 0x410003;
        public const uint IOCTL_INTERNAL_DESELECT_DEVICE = 0x160060;
        public const uint IOCTL_INTERNAL_DISABLE_END_OF_CHAIN_BUS_RESCAN = 0x1600d8;
        public const uint IOCTL_INTERNAL_DISCONNECT_IDLE = 0x160080;
        public const uint IOCTL_INTERNAL_ENABLE_END_OF_CHAIN_BUS_RESCAN = 0x1600dc;
        public const uint IOCTL_INTERNAL_GET_MORE_PARALLEL_PORT_INFO = 0x160044;
        public const uint IOCTL_INTERNAL_GET_PARALLEL_PNP_INFO = 0x160054;
        public const uint IOCTL_INTERNAL_GET_PARALLEL_PORT_INFO = 0x160030;
        public const uint IOCTL_INTERNAL_GET_PARPORT_FDO = 0x160074;
        public const uint IOCTL_INTERNAL_I8042_CONTROLLER_WRITE_BUFFER = 0xb3fcb;
        public const uint IOCTL_INTERNAL_I8042_HOOK_KEYBOARD = 0xb3fc3;
        public const uint IOCTL_INTERNAL_I8042_HOOK_MOUSE = 0xf3fc3;
        public const uint IOCTL_INTERNAL_I8042_KEYBOARD_START_INFORMATION = 0xb3fcf;
        public const uint IOCTL_INTERNAL_I8042_KEYBOARD_WRITE_BUFFER = 0xb3fc7;
        public const uint IOCTL_INTERNAL_I8042_MOUSE_START_INFORMATION = 0xf3fcf;
        public const uint IOCTL_INTERNAL_I8042_MOUSE_WRITE_BUFFER = 0xf3fc7;
        public const uint IOCTL_INTERNAL_INIT_1284_3_BUS = 0x160058;
        public const uint IOCTL_INTERNAL_KEYBOARD_CONNECT = 0xb0203;
        public const uint IOCTL_INTERNAL_KEYBOARD_DISABLE = 0xb1003;
        public const uint IOCTL_INTERNAL_KEYBOARD_DISCONNECT = 0xb0403;
        public const uint IOCTL_INTERNAL_KEYBOARD_ENABLE = 0xb0803;
        public const uint IOCTL_INTERNAL_LOCK_PORT = 0x160094;
        public const uint IOCTL_INTERNAL_LOCK_PORT_NO_SELECT = 0x1600d0;
        public const uint IOCTL_INTERNAL_MOUSE_CONNECT = 0xf0203;
        public const uint IOCTL_INTERNAL_MOUSE_DISABLE = 0xf1003;
        public const uint IOCTL_INTERNAL_MOUSE_DISCONNECT = 0xf0403;
        public const uint IOCTL_INTERNAL_MOUSE_ENABLE = 0xf0803;
        public const uint IOCTL_INTERNAL_PARALLEL_CLEAR_CHIP_MODE = 0x160050;
        public const uint IOCTL_INTERNAL_PARALLEL_CONNECT_INTERRUPT = 0x160034;
        public const uint IOCTL_INTERNAL_PARALLEL_DISCONNECT_INTERRUPT = 0x160038;
        public const uint IOCTL_INTERNAL_PARALLEL_PORT_ALLOCATE = 0x16002c;
        public const uint IOCTL_INTERNAL_PARALLEL_PORT_FREE = 0x1600a0;
        public const uint IOCTL_INTERNAL_PARALLEL_SET_CHIP_MODE = 0x16004c;
        public const uint IOCTL_INTERNAL_PARCHIP_CONNECT = 0x160048;
        public const uint IOCTL_INTERNAL_PARCLASS_CONNECT = 0x160078;
        public const uint IOCTL_INTERNAL_PARCLASS_DISCONNECT = 0x16007c;
        public const uint IOCTL_INTERNAL_PARDOT3_CONNECT = 0x1600a4;
        public const uint IOCTL_INTERNAL_PARDOT3_DISCONNECT = 0x1600a8;
        public const uint IOCTL_INTERNAL_PARDOT3_RESET = 0x1600ac;
        public const uint IOCTL_INTERNAL_PARDOT3_SIGNAL = 0x1600b0;
        public const uint IOCTL_INTERNAL_REGISTER_FOR_REMOVAL_RELATIONS = 0x1600c8;
        public const uint IOCTL_INTERNAL_RELEASE_PARALLEL_PORT_INFO = 0x16003c;
        public const uint IOCTL_INTERNAL_SELECT_DEVICE = 0x16005c;
        public const uint IOCTL_INTERNAL_SERENUM_REMOVE_SELF = 0x370207;
        public const uint IOCTL_INTERNAL_UNLOCK_PORT = 0x160098;
        public const uint IOCTL_INTERNAL_UNLOCK_PORT_NO_DESELECT = 0x1600d4;
        public const uint IOCTL_INTERNAL_UNREGISTER_FOR_REMOVAL_RELATIONS = 0x1600cc;
        public const uint IOCTL_INTERNAL_USB_CYCLE_PORT = 0x22001f;
        public const uint IOCTL_INTERNAL_USB_ENABLE_PORT = 0x220017;
        public const uint IOCTL_INTERNAL_USB_GET_BUSGUID_INFO = 0x220428;
        public const uint IOCTL_INTERNAL_USB_GET_BUS_INFO = 0x220420;
        public const uint IOCTL_INTERNAL_USB_GET_CONTROLLER_NAME = 0x220424;
        public const uint IOCTL_INTERNAL_USB_GET_DEVICE_CONFIG_INFO = 0x22044f;
        public const uint IOCTL_INTERNAL_USB_GET_DEVICE_HANDLE = 0x220433;
        public const uint IOCTL_INTERNAL_USB_GET_DEVICE_HANDLE_EX = 0x220437;
        public const uint IOCTL_INTERNAL_USB_GET_HUB_COUNT = 0x22001b;
        public const uint IOCTL_INTERNAL_USB_GET_HUB_NAME = 0x220020;
        public const uint IOCTL_INTERNAL_USB_GET_PARENT_HUB_INFO = 0x22042c;
        public const uint IOCTL_INTERNAL_USB_GET_PORT_STATUS = 0x220013;
        public const uint IOCTL_INTERNAL_USB_GET_ROOTHUB_PDO = 0x22000f;
        public const uint IOCTL_INTERNAL_USB_GET_TOPOLOGY_ADDRESS = 0x22043f;
        public const uint IOCTL_INTERNAL_USB_GET_TT_DEVICE_HANDLE = 0x22043b;
        public const uint IOCTL_INTERNAL_USB_NOTIFY_IDLE_READY = 0x220443;
        public const uint IOCTL_INTERNAL_USB_RECORD_FAILURE = 0x22002b;
        public const uint IOCTL_INTERNAL_USB_REQ_GLOBAL_RESUME = 0x22044b;
        public const uint IOCTL_INTERNAL_USB_REQ_GLOBAL_SUSPEND = 0x220447;
        public const uint IOCTL_INTERNAL_USB_RESET_PORT = 0x220007;
        public const uint IOCTL_INTERNAL_USB_SUBMIT_IDLE_NOTIFICATION = 0x220027;
        public const uint IOCTL_INTERNAL_USB_SUBMIT_URB = 0x220003;
        public const uint IOCTL_IP_ADDCHANGE_NOTIFY_REQUEST = 0x66;
        public const uint IOCTL_IP_GET_BEST_INTERFACE = 0x69;
        public const uint IOCTL_IP_INTERFACE_INFO = 0x68;
        public const uint IOCTL_IP_RTCHANGE_NOTIFY_REQUEST = 0x65;
        public const uint IOCTL_IP_SET_FIREWALL_HOOK = 0x128030;
        public const uint IOCTL_IP_UNIDIRECTIONAL_ADAPTER_ADDRESS = 0x6a;
        public const uint IOCTL_IR_ENTER_PRIORITY_RECEIVE = 0xf608028;
        public const uint IOCTL_IR_ENTER_PRIORITY_RECEIVE_PARAMS = 0x0000;
        public const uint IOCTL_IR_EXIT_PRIORITY_RECEIVE = 0xf60802c;
        public const uint IOCTL_IR_FLASH_RECEIVER = 0xf60800c;
        public const uint IOCTL_IR_GET_DEVCAPS = 0x0000;
        public const uint IOCTL_IR_GET_DEV_CAPS = 0xf604004;
        public const uint IOCTL_IR_GET_EMITTERS = 0xf604008;
        public const uint IOCTL_IR_HANDSHAKE = 0xf600024;
        public const uint IOCTL_IR_PRIORITY_RECEIVE = 0xf604022;
        public const uint IOCTL_IR_RECEIVE = 0xf60401a;
        public const uint IOCTL_IR_RESET_DEVICE = 0xf608010;
        public const uint IOCTL_IR_SET_WAKE_PATTERN = 0xf608038;
        public const uint IOCTL_IR_TRANSMIT = 0xf608015;
        public const uint IOCTL_IR_USER_CLOSE = 0xf608034;
        public const uint IOCTL_IR_USER_OPEN = 0xf608030;
        public const uint IOCTL_KEYBOARD_INSERT_DATA = 0xb0100;
        public const uint IOCTL_KEYBOARD_QUERY_ATTRIBUTES = 0xb0000;
        public const uint IOCTL_KEYBOARD_QUERY_IME_STATUS = 0xb1000;
        public const uint IOCTL_KEYBOARD_QUERY_INDICATORS = 0xb0040;
        public const uint IOCTL_KEYBOARD_QUERY_INDICATOR_TRANSLATION = 0xb0080;
        public const uint IOCTL_KEYBOARD_QUERY_TYPEMATIC = 0xb0020;
        public const uint IOCTL_KEYBOARD_SET_IME_STATUS = 0xb1004;
        public const uint IOCTL_KEYBOARD_SET_INDICATORS = 0xb0008;
        public const uint IOCTL_KEYBOARD_SET_TYPEMATIC = 0xb0004;
        public const uint IOCTL_KS_DISABLE_EVENT = 0x2f000b;
        public const uint IOCTL_KS_ENABLE_EVENT = 0x2f0007;
        public const uint IOCTL_KS_HANDSHAKE = 0x2f001f;
        public const uint IOCTL_KS_METHOD = 0x2f000f;
        public const uint IOCTL_KS_PROPERTY = 0x2f0003;
        public const uint IOCTL_KS_READ_STREAM = 0x2f4017;
        public const uint IOCTL_KS_RESET_STATE = 0x2f001b;
        public const uint IOCTL_KS_WRITE_STREAM = 0x2f8013;
        public const uint IOCTL_LMR_ARE_FILE_OBJECTS_ON_SAME_SERVER = 0x1400f0;
        public const uint IOCTL_MINIPORT_PROCESS_SERVICE_IRP = 0x4d038;
        public const uint IOCTL_MODEM_CHECK_FOR_MODEM = 0x2b002c;
        public const uint IOCTL_MODEM_GET_DLE = 0x2b0010;
        public const uint IOCTL_MODEM_GET_MESSAGE = 0x2b0020;
        public const uint IOCTL_MODEM_GET_PASSTHROUGH = 0x2b0004;
        public const uint IOCTL_MODEM_SEND_GET_MESSAGE = 0x2b0024;
        public const uint IOCTL_MODEM_SEND_LOOPBACK_MESSAGE = 0x2b0028;
        public const uint IOCTL_MODEM_SEND_MESSAGE = 0x2b001c;
        public const uint IOCTL_MODEM_SET_DLE_MONITORING = 0x2b000c;
        public const uint IOCTL_MODEM_SET_DLE_SHIELDING = 0x2b0014;
        public const uint IOCTL_MODEM_SET_MIN_POWER = 0x2b0030;
        public const uint IOCTL_MODEM_SET_PASSTHROUGH = 0x2b0008;
        public const uint IOCTL_MODEM_STOP_WAVE_RECEIVE = 0x2b0018;
        public const uint IOCTL_MODEM_WATCH_FOR_RESUME = 0x2b0034;
        public const uint IOCTL_MOUNTDEV_LINK_CREATED = 0x4dc010;
        public const uint IOCTL_MOUNTDEV_LINK_DELETED = 0x4dc014;
        public const uint IOCTL_MOUNTDEV_QUERY_DEVICE_NAME = 0x4d0008;
        public const uint IOCTL_MOUNTDEV_QUERY_STABLE_GUID = 0x4d0018;
        public const uint IOCTL_MOUNTDEV_QUERY_SUGGESTED_LINK_NAME = 0x4d000c;
        public const uint IOCTL_MOUNTDEV_QUERY_UNIQUE_ID = 0x4d0000;
        public const uint IOCTL_MOUNTMGR_AUTO_DL_ASSIGNMENTS = 0x6dc014;
        public const uint IOCTL_MOUNTMGR_BOOT_DL_ASSIGNMENT = 0x6dc044;
        public const uint IOCTL_MOUNTMGR_CHANGE_NOTIFY = 0x6d4020;
        public const uint IOCTL_MOUNTMGR_CHECK_UNPROCESSED_VOLUMES = 0x6d4028;
        public const uint IOCTL_MOUNTMGR_CREATE_POINT = 0x6dc000;
        public const uint IOCTL_MOUNTMGR_DELETE_POINTS = 0x6dc004;
        public const uint IOCTL_MOUNTMGR_DELETE_POINTS_DBONLY = 0x6dc00c;
        public const uint IOCTL_MOUNTMGR_KEEP_LINKS_WHEN_OFFLINE = 0x6dc024;
        public const uint IOCTL_MOUNTMGR_NEXT_DRIVE_LETTER = 0x6dc010;
        public const uint IOCTL_MOUNTMGR_QUERY_AUTO_MOUNT = 0x6d003c;
        public const uint IOCTL_MOUNTMGR_QUERY_DOS_VOLUME_PATH = 0x6d0030;
        public const uint IOCTL_MOUNTMGR_QUERY_DOS_VOLUME_PATHS = 0x6d0034;
        public const uint IOCTL_MOUNTMGR_QUERY_POINTS = 0x6d0008;
        public const uint IOCTL_MOUNTMGR_SCRUB_REGISTRY = 0x6dc038;
        public const uint IOCTL_MOUNTMGR_SET_AUTO_MOUNT = 0x6dc040;
        public const uint IOCTL_MOUNTMGR_TRACELOG_CACHE = 0x6d4048;
        public const uint IOCTL_MOUNTMGR_VOLUME_ARRIVAL_NOTIFICATION = 0x6d402c;
        public const uint IOCTL_MOUNTMGR_VOLUME_MOUNT_POINT_CREATED = 0x6dc018;
        public const uint IOCTL_MOUNTMGR_VOLUME_MOUNT_POINT_DELETED = 0x6dc01c;
        public const uint IOCTL_MOUSE_INSERT_DATA = 0xf0004;
        public const uint IOCTL_MOUSE_QUERY_ATTRIBUTES = 0xf0000;
        public const uint IOCTL_MPDSM_DEREGISTER = 0x736dc008;
        public const uint IOCTL_MPDSM_REGISTER = 0x736dc004;
        public const uint IOCTL_MPIO_PASS_THROUGH_PATH = 0x4d03c;
        public const uint IOCTL_MPIO_PASS_THROUGH_PATH_DIRECT = 0x4d040;
        public const uint IOCTL_MTP_CUSTOM_COMMAND = 0x3150544d;
        public const uint IOCTL_NDIS_ADD_TDI_DEVICE = 0x170014;
        public const uint IOCTL_NDIS_DO_PNP_OPERATION = 0x170008;
        public const uint IOCTL_NDIS_ENUMERATE_INTERFACES = 0x170010;
        public const uint IOCTL_NDIS_GET_LOG_DATA = 0x17001e;
        public const uint IOCTL_NDIS_GET_VERSION = 0x170020;
        public const uint IOCTL_NDIS_QUERY_ALL_STATS = 0x170006;
        public const uint IOCTL_NDIS_QUERY_GLOBAL_STATS = 0x170002;
        public const uint IOCTL_NDIS_QUERY_SELECTED_STATS = 0x17000e;
        public const uint IOCTL_NDIS_RESERVED1 = 0x170024;
        public const uint IOCTL_NDIS_RESERVED10 = 0x170048;
        public const uint IOCTL_NDIS_RESERVED11 = 0x17004c;
        public const uint IOCTL_NDIS_RESERVED12 = 0x170050;
        public const uint IOCTL_NDIS_RESERVED13 = 0x170054;
        public const uint IOCTL_NDIS_RESERVED14 = 0x170058;
        public const uint IOCTL_NDIS_RESERVED15 = 0x17005c;
        public const uint IOCTL_NDIS_RESERVED16 = 0x170060;
        public const uint IOCTL_NDIS_RESERVED17 = 0x170064;
        public const uint IOCTL_NDIS_RESERVED18 = 0x170068;
        public const uint IOCTL_NDIS_RESERVED19 = 0x17006c;
        public const uint IOCTL_NDIS_RESERVED2 = 0x170028;
        public const uint IOCTL_NDIS_RESERVED20 = 0x170070;
        public const uint IOCTL_NDIS_RESERVED21 = 0x170074;
        public const uint IOCTL_NDIS_RESERVED22 = 0x170078;
        public const uint IOCTL_NDIS_RESERVED3 = 0x17002c;
        public const uint IOCTL_NDIS_RESERVED4 = 0x170030;
        public const uint IOCTL_NDIS_RESERVED5 = 0x170034;
        public const uint IOCTL_NDIS_RESERVED6 = 0x178038;
        public const uint IOCTL_NDIS_RESERVED7 = 0x17003e;
        public const uint IOCTL_NDIS_RESERVED8 = 0x170040;
        public const uint IOCTL_NDIS_RESERVED9 = 0x170044;
        public const uint IOCTL_NOTIFY_SWITCH_EVENT = 0x294100;
        public const uint IOCTL_PAR_ECP_HOST_RECOVERY = 0x160034;
        public const uint IOCTL_PAR_GET_DEFAULT_MODES = 0x160028;
        public const uint IOCTL_PAR_GET_DEVICE_CAPS = 0x160024;
        public const uint IOCTL_PAR_GET_READ_ADDRESS = 0x160038;
        public const uint IOCTL_PAR_GET_WRITE_ADDRESS = 0x16003c;
        public const uint IOCTL_PAR_IS_PORT_FREE = 0x160054;
        public const uint IOCTL_PAR_PING = 0x16002c;
        public const uint IOCTL_PAR_QUERY_DEVICE_ID = 0x16000c;
        public const uint IOCTL_PAR_QUERY_DEVICE_ID_SIZE = 0x160010;
        public const uint IOCTL_PAR_QUERY_INFORMATION = 0x160004;
        public const uint IOCTL_PAR_QUERY_LOCATION = 0x160058;
        public const uint IOCTL_PAR_QUERY_RAW_DEVICE_ID = 0x160030;
        public const uint IOCTL_PAR_SET_INFORMATION = 0x160008;
        public const uint IOCTL_PAR_SET_READ_ADDRESS = 0x160020;
        public const uint IOCTL_PAR_SET_WRITE_ADDRESS = 0x16001c;
        public const uint IOCTL_PAR_TEST = 0x160050;
        public const uint IOCTL_PCMCIA_HIDE_DEVICE = 0x4af08;
        public const uint IOCTL_PCMCIA_REVEAL_DEVICE = 0x4af0c;
        public const uint IOCTL_PF_SET_EXTENSION_POINTER = 0x128058;
        public const uint IOCTL_PMI_GET_CAPABILITIES = 0x454000;
        public const uint IOCTL_PMI_GET_CONFIGURATION = 0x454004;
        public const uint IOCTL_PMI_GET_MEASUREMENT = 0x45400c;
        public const uint IOCTL_PMI_REGISTER_EVENT_NOTIFY = 0x45c010;
        public const uint IOCTL_PMI_SET_CONFIGURATION = 0x458008;
        public const uint IOCTL_QUERY_DEVICE_POWER_STATE = 0x294000;
        public const uint IOCTL_QUERY_LID = 0x2940c0;
        public const uint IOCTL_READ_REGISTERS = 0x8000200c;
        public const uint IOCTL_REDIR_QUERY_PATH = 0x14018f;
        public const uint IOCTL_REDIR_QUERY_PATH_EX = 0x140193;
        public const uint IOCTL_RESET_PIPE = 0x8000201c;
        public const uint IOCTL_RUN_ACTIVE_COOLING_METHOD = 0x298088;
        public const uint IOCTL_SCSISCAN_CMD = 0x190012;
        public const uint IOCTL_SCSISCAN_GET_INFO = 0x190022;
        public const uint IOCTL_SCSISCAN_LOCKDEVICE = 0x190016;
        public const uint IOCTL_SCSISCAN_SET_TIMEOUT = 0x19001c;
        public const uint IOCTL_SCSISCAN_UNLOCKDEVICE = 0x19001a;
        public const uint IOCTL_SCSI_EXECUTE_IN = 0x1b0011;
        public const uint IOCTL_SCSI_EXECUTE_NONE = 0x1b0013;
        public const uint IOCTL_SCSI_EXECUTE_OUT = 0x1b0012;
        public const uint IOCTL_SCSI_FREE_DUMP_POINTERS = 0x41024;
        public const uint IOCTL_SCSI_GET_ADDRESS = 0x41018;
        public const uint IOCTL_SCSI_GET_CAPABILITIES = 0x41010;
        public const uint IOCTL_SCSI_GET_DUMP_POINTERS = 0x41020;
        public const uint IOCTL_SCSI_GET_INQUIRY_DATA = 0x4100c;
        public const uint IOCTL_SCSI_MINIPORT = 0x4d008;
        public const uint IOCTL_SCSI_MINIPORT_DISABLE_SMART = 0x1b0505;
        public const uint IOCTL_SCSI_MINIPORT_ENABLE_DISABLE_AUTOSAVE = 0x1b0507;
        public const uint IOCTL_SCSI_MINIPORT_ENABLE_DISABLE_AUTO_OFFLINE = 0x1b050a;
        public const uint IOCTL_SCSI_MINIPORT_ENABLE_SMART = 0x1b0504;
        public const uint IOCTL_SCSI_MINIPORT_EXECUTE_OFFLINE_DIAGS = 0x1b0509;
        public const uint IOCTL_SCSI_MINIPORT_IDENTIFY = 0x1b0501;
        public const uint IOCTL_SCSI_MINIPORT_NOT_CLUSTER_CAPABLE = 0x1b0521;
        public const uint IOCTL_SCSI_MINIPORT_NOT_QUORUM_CAPABLE = 0x1b0520;
        public const uint IOCTL_SCSI_MINIPORT_NVCACHE = 0x1b0600;
        public const uint IOCTL_SCSI_MINIPORT_READ_SMART_ATTRIBS = 0x1b0502;
        public const uint IOCTL_SCSI_MINIPORT_READ_SMART_LOG = 0x1b050b;
        public const uint IOCTL_SCSI_MINIPORT_READ_SMART_THRESHOLDS = 0x1b0503;
        public const uint IOCTL_SCSI_MINIPORT_RETURN_STATUS = 0x1b0506;
        public const uint IOCTL_SCSI_MINIPORT_SAVE_ATTRIBUTE_VALUES = 0x1b0508;
        public const uint IOCTL_SCSI_MINIPORT_SMART_VERSION = 0x1b0500;
        public const uint IOCTL_SCSI_MINIPORT_WRITE_SMART_LOG = 0x1b050c;
        public const uint IOCTL_SCSI_PASS_THROUGH = 0x4d004;
        public const uint IOCTL_SCSI_PASS_THROUGH_DIRECT = 0x4d014;
        public const uint IOCTL_SCSI_RESCAN_BUS = 0x4101c;
        public const uint IOCTL_SD_SUBMIT_REQUEST = 0x43073;
        public const uint IOCTL_SEND_USB_REQUEST = 0x80002024;
        public const uint IOCTL_SERENUM_EXPOSE_HARDWARE = 0x370200;
        public const uint IOCTL_SERENUM_GET_PORT_NAME = 0x37020c;
        public const uint IOCTL_SERENUM_PORT_DESC = 0x370208;
        public const uint IOCTL_SERENUM_REMOVE_HARDWARE = 0x370204;
        public const uint IOCTL_SERIAL_CLEAR_STATS = 0x1b0090;
        public const uint IOCTL_SERIAL_CLR_DTR = 0x1b0028;
        public const uint IOCTL_SERIAL_CLR_RTS = 0x1b0034;
        public const uint IOCTL_SERIAL_CONFIG_SIZE = 0x1b0080;
        public const uint IOCTL_SERIAL_GET_BAUD_RATE = 0x1b0050;
        public const uint IOCTL_SERIAL_GET_CHARS = 0x1b0058;
        public const uint IOCTL_SERIAL_GET_COMMCONFIG = 0x1b0084;
        public const uint IOCTL_SERIAL_GET_COMMSTATUS = 0x1b006c;
        public const uint IOCTL_SERIAL_GET_DTRRTS = 0x1b0078;
        public const uint IOCTL_SERIAL_GET_HANDFLOW = 0x1b0060;
        public const uint IOCTL_SERIAL_GET_LINE_CONTROL = 0x1b0054;
        public const uint IOCTL_SERIAL_GET_MODEMSTATUS = 0x1b0068;
        public const uint IOCTL_SERIAL_GET_MODEM_CONTROL = 0x1b0094;
        public const uint IOCTL_SERIAL_GET_PROPERTIES = 0x1b0074;
        public const uint IOCTL_SERIAL_GET_STATS = 0x1b008c;
        public const uint IOCTL_SERIAL_GET_TIMEOUTS = 0x1b0020;
        public const uint IOCTL_SERIAL_GET_WAIT_MASK = 0x1b0040;
        public const uint IOCTL_SERIAL_IMMEDIATE_CHAR = 0x1b0018;
        public const uint IOCTL_SERIAL_INTERNAL_BASIC_SETTINGS = 0x1b000c;
        public const uint IOCTL_SERIAL_INTERNAL_CANCEL_WAIT_WAKE = 0x1b0008;
        public const uint IOCTL_SERIAL_INTERNAL_DO_WAIT_WAKE = 0x1b0004;
        public const uint IOCTL_SERIAL_INTERNAL_RESTORE_SETTINGS = 0x1b0010;
        public const uint IOCTL_SERIAL_LSRMST_INSERT = 0x1b007c;
        public const uint IOCTL_SERIAL_PURGE = 0x1b004c;
        public const uint IOCTL_SERIAL_RESET_DEVICE = 0x1b002c;
        public const uint IOCTL_SERIAL_SET_BAUD_RATE = 0x1b0004;
        public const uint IOCTL_SERIAL_SET_BREAK_OFF = 0x1b0014;
        public const uint IOCTL_SERIAL_SET_BREAK_ON = 0x1b0010;
        public const uint IOCTL_SERIAL_SET_CHARS = 0x1b005c;
        public const uint IOCTL_SERIAL_SET_COMMCONFIG = 0x1b0088;
        public const uint IOCTL_SERIAL_SET_DTR = 0x1b0024;
        public const uint IOCTL_SERIAL_SET_FIFO_CONTROL = 0x1b009c;
        public const uint IOCTL_SERIAL_SET_HANDFLOW = 0x1b0064;
        public const uint IOCTL_SERIAL_SET_LINE_CONTROL = 0x1b000c;
        public const uint IOCTL_SERIAL_SET_MODEM_CONTROL = 0x1b0098;
        public const uint IOCTL_SERIAL_SET_QUEUE_SIZE = 0x1b0008;
        public const uint IOCTL_SERIAL_SET_RTS = 0x1b0030;
        public const uint IOCTL_SERIAL_SET_TIMEOUTS = 0x1b001c;
        public const uint IOCTL_SERIAL_SET_WAIT_MASK = 0x1b0044;
        public const uint IOCTL_SERIAL_SET_XOFF = 0x1b0038;
        public const uint IOCTL_SERIAL_SET_XON = 0x1b003c;
        public const uint IOCTL_SERIAL_WAIT_ON_MASK = 0x1b0048;
        public const uint IOCTL_SERIAL_XOFF_COUNTER = 0x1b0070;
        public const uint IOCTL_SET_DEVICE_WAKE = 0x298004;
        public const uint IOCTL_SET_NUM_DEVICE_INPUT_BUFFERS = 0xb01a4;
        public const uint IOCTL_SET_SERVER_STATE = 0x2b003c;
        public const uint IOCTL_SET_SYS_MESSAGE_INDICATOR = 0x2981c0;
        public const uint IOCTL_SET_TIMEOUT = 0x8000202c;
        public const uint IOCTL_SFFDISK_DEVICE_COMMAND = 0x79e84;
        public const uint IOCTL_SFFDISK_DEVICE_PASSWORD = 0x79e88;
        public const uint IOCTL_SFFDISK_QUERY_DEVICE_PROTOCOL = 0x71e80;
        public const uint IOCTL_SMARTCARD_CONFISCATE = 0x310010;
        public const uint IOCTL_SMARTCARD_EJECT = 0x310018;
        public const uint IOCTL_SMARTCARD_GET_ATTRIBUTE = 0x310008;
        public const uint IOCTL_SMARTCARD_GET_LAST_ERROR = 0x31003c;
        public const uint IOCTL_SMARTCARD_GET_PERF_CNTR = 0x310040;
        public const uint IOCTL_SMARTCARD_GET_STATE = 0x310038;
        public const uint IOCTL_SMARTCARD_IS_ABSENT = 0x31002c;
        public const uint IOCTL_SMARTCARD_IS_PRESENT = 0x310028;
        public const uint IOCTL_SMARTCARD_POWER = 0x310004;
        public const uint IOCTL_SMARTCARD_SET_ATTRIBUTE = 0x31000c;
        public const uint IOCTL_SMARTCARD_SET_PROTOCOL = 0x310030;
        public const uint IOCTL_SMARTCARD_SWALLOW = 0x31001c;
        public const uint IOCTL_SMARTCARD_TRANSMIT = 0x310014;
        public const uint IOCTL_SOCKET_INFORMATION = 0x42ef0;
        public const uint IOCTL_STORAGE_ALLOCATE_BC_STREAM = 0x2dd804;
        public const uint IOCTL_STORAGE_BC_VERSION = 0x1;
        public const uint IOCTL_STORAGE_BREAK_RESERVATION = 0x2d5014;
        public const uint IOCTL_STORAGE_CHECK_PRIORITY_HINT_SUPPORT = 0x2d1880;
        public const uint IOCTL_STORAGE_CHECK_VERIFY = 0x2d4800;
        public const uint IOCTL_STORAGE_CHECK_VERIFY2 = 0x2d0800;
        public const uint IOCTL_STORAGE_EJECTION_CONTROL = 0x2d0940;
        public const uint IOCTL_STORAGE_EJECT_MEDIA = 0x2d4808;
        public const uint IOCTL_STORAGE_FIND_NEW_DEVICES = 0x2d4818;
        public const uint IOCTL_STORAGE_FREE_BC_STREAM = 0x2dd808;
        public const uint IOCTL_STORAGE_GET_BC_PROPERTIES = 0x2d5800;
        public const uint IOCTL_STORAGE_GET_DEVICE_NUMBER = 0x2d1080;
        public const uint IOCTL_STORAGE_GET_HOTPLUG_INFO = 0x2d0c14;
        public const uint IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER = 0x2d0c10;
        public const uint IOCTL_STORAGE_GET_MEDIA_TYPES = 0x2d0c00;
        public const uint IOCTL_STORAGE_GET_MEDIA_TYPES_EX = 0x2d0c04;
        public const uint IOCTL_STORAGE_LOAD_MEDIA = 0x2d480c;
        public const uint IOCTL_STORAGE_LOAD_MEDIA2 = 0x2d080c;
        public const uint IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES = 0x2d9404;
        public const uint IOCTL_STORAGE_MCN_CONTROL = 0x2d0944;
        public const uint IOCTL_STORAGE_MEDIA_REMOVAL = 0x2d4804;
        public const uint IOCTL_STORAGE_PERSISTENT_RESERVE_IN = 0x2d5018;
        public const uint IOCTL_STORAGE_PERSISTENT_RESERVE_OUT = 0x2dd01c;
        public const uint IOCTL_STORAGE_PREDICT_FAILURE = 0x2d1100;
        public const uint IOCTL_STORAGE_QUERY_PROPERTY = 0x2d1400;
        public const uint IOCTL_STORAGE_READ_CAPACITY = 0x2d5140;
        public const uint IOCTL_STORAGE_RELEASE = 0x2d4814;
        public const uint IOCTL_STORAGE_RESERVE = 0x2d4810;
        public const uint IOCTL_STORAGE_RESET_BUS = 0x2d5000;
        public const uint IOCTL_STORAGE_RESET_DEVICE = 0x2d5004;
        public const uint IOCTL_STORAGE_SET_HOTPLUG_INFO = 0x2dcc18;
        public const uint IOCTL_STORAGE_SET_READ_AHEAD = 0x2d4400;
        public const uint IOCTL_SWENUM_GET_BUS_ID = 0x2a400b;
        public const uint IOCTL_SWENUM_INSTALL_INTERFACE = 0x2a0000;
        public const uint IOCTL_SWENUM_REMOVE_INTERFACE = 0x2a0004;
        public const uint IOCTL_TAPE_CHECK_VERIFY = 0x1f4800;
        public const uint IOCTL_TAPE_CREATE_PARTITION = 0x1fc028;
        public const uint IOCTL_TAPE_EJECT_MEDIA = 0x1f4808;
        public const uint IOCTL_TAPE_ERASE = 0x1fc000;
        public const uint IOCTL_TAPE_FIND_NEW_DEVICES = 0x74818;
        public const uint IOCTL_TAPE_GET_DRIVE_PARAMS = 0x1f4014;
        public const uint IOCTL_TAPE_GET_MEDIA_PARAMS = 0x1f401c;
        public const uint IOCTL_TAPE_GET_POSITION = 0x1f400c;
        public const uint IOCTL_TAPE_GET_STATUS = 0x1f4024;
        public const uint IOCTL_TAPE_LOAD_MEDIA = 0x1f480c;
        public const uint IOCTL_TAPE_MEDIA_REMOVAL = 0x1f4804;
        public const uint IOCTL_TAPE_PREPARE = 0x1f4004;
        public const uint IOCTL_TAPE_RELEASE = 0x1f4814;
        public const uint IOCTL_TAPE_RESERVE = 0x1f4810;
        public const uint IOCTL_TAPE_SET_DRIVE_PARAMS = 0x1fc018;
        public const uint IOCTL_TAPE_SET_MEDIA_PARAMS = 0x1f4020;
        public const uint IOCTL_TAPE_SET_POSITION = 0x1f4010;
        public const uint IOCTL_TAPE_WRITE_MARKS = 0x1fc008;
        public const uint IOCTL_TCP_QUERY_INFORMATION_EX = 0x120003;
        public const uint IOCTL_TDI_ACCEPT = 0x210000;
        public const uint IOCTL_TDI_ACTION = 0x210036;
        public const uint IOCTL_TDI_ASSOCIATE_ADDRESS = 0x21002c;
        public const uint IOCTL_TDI_CONNECT = 0x210004;
        public const uint IOCTL_TDI_DISASSOCIATE_ADDRESS = 0x210030;
        public const uint IOCTL_TDI_DISCONNECT = 0x210008;
        public const uint IOCTL_TDI_LISTEN = 0x21000c;
        public const uint IOCTL_TDI_MAGIC_BULLET = 0x2101ff;
        public const uint IOCTL_TDI_QUERY_DIRECT_SENDDG_HANDLER = 0x210207;
        public const uint IOCTL_TDI_QUERY_DIRECT_SEND_HANDLER = 0x210203;
        public const uint IOCTL_TDI_QUERY_INFORMATION = 0x210012;
        public const uint IOCTL_TDI_RECEIVE = 0x210016;
        public const uint IOCTL_TDI_RECEIVE_DATAGRAM = 0x21001a;
        public const uint IOCTL_TDI_SEND = 0x21001d;
        public const uint IOCTL_TDI_SEND_DATAGRAM = 0x210021;
        public const uint IOCTL_TDI_SET_EVENT_HANDLER = 0x210024;
        public const uint IOCTL_TDI_SET_INFORMATION = 0x210029;
        public const uint IOCTL_TDI_TL_IO_CONTROL_ENDPOINT = 0x210038;
        public const uint IOCTL_THERMAL_QUERY_INFORMATION = 0x294080;
        public const uint IOCTL_THERMAL_SET_COOLING_POLICY = 0x298084;
        public const uint IOCTL_USBPRINT_GET_1284_ID = 0x220034;
        public const uint IOCTL_USBPRINT_GET_LPT_STATUS = 0x220030;
        public const uint IOCTL_USBPRINT_SOFT_RESET = 0x220040;
        public const uint IOCTL_USBPRINT_VENDOR_GET_COMMAND = 0x22003c;
        public const uint IOCTL_USBPRINT_VENDOR_SET_COMMAND = 0x220038;
        public const uint IOCTL_USB_DIAGNOSTIC_MODE_OFF = 0x220404;
        public const uint IOCTL_USB_DIAGNOSTIC_MODE_ON = 0x220400;
        public const uint IOCTL_USB_DIAG_IGNORE_HUBS_OFF = 0x22041c;
        public const uint IOCTL_USB_DIAG_IGNORE_HUBS_ON = 0x220418;
        public const uint IOCTL_USB_GET_DESCRIPTOR_FROM_NODE_CONNECTION = 0x220410;
        public const uint IOCTL_USB_GET_HUB_CAPABILITIES = 0x22043c;
        public const uint IOCTL_USB_GET_HUB_CAPABILITIES_EX = 0x220450;
        public const uint IOCTL_USB_GET_NODE_CONNECTION_ATTRIBUTES = 0x220440;
        public const uint IOCTL_USB_GET_NODE_CONNECTION_DRIVERKEY_NAME = 0x220420;
        public const uint IOCTL_USB_GET_NODE_CONNECTION_INFORMATION = 0x22040c;
        public const uint IOCTL_USB_GET_NODE_CONNECTION_INFORMATION_EX = 0x220448;
        public const uint IOCTL_USB_GET_NODE_CONNECTION_NAME = 0x220414;
        public const uint IOCTL_USB_GET_NODE_INFORMATION = 0x220408;
        public const uint IOCTL_USB_GET_ROOT_HUB_NAME = 0x220408;
        public const uint IOCTL_USB_HCD_DISABLE_PORT = 0x220430;
        public const uint IOCTL_USB_HCD_ENABLE_PORT = 0x220434;
        public const uint IOCTL_USB_HCD_GET_STATS_1 = 0x2203fc;
        public const uint IOCTL_USB_HCD_GET_STATS_2 = 0x220428;
        public const uint IOCTL_USB_HUB_CYCLE_PORT = 0x220444;
        public const uint IOCTL_USB_RESET_HUB = 0x22044c;
        public const uint IOCTL_USB_USER_REQUEST = 0x220438;
        public const uint IOCTL_VIDEO_DISABLE_CURSOR = 0x230424;
        public const uint IOCTL_VIDEO_DISABLE_POINTER = 0x23043c;
        public const uint IOCTL_VIDEO_DISABLE_VDM = 0x230004;
        public const uint IOCTL_VIDEO_ENABLE_CURSOR = 0x230420;
        public const uint IOCTL_VIDEO_ENABLE_POINTER = 0x230438;
        public const uint IOCTL_VIDEO_ENABLE_VDM = 0x230000;
        public const uint IOCTL_VIDEO_ENUM_MONITOR_PDO = 0x230018;
        public const uint IOCTL_VIDEO_FREE_PUBLIC_ACCESS_RANGES = 0x230464;
        public const uint IOCTL_VIDEO_GET_BANK_SELECT_CODE = 0x230454;
        public const uint IOCTL_VIDEO_GET_CHILD_STATE = 0x230480;
        public const uint IOCTL_VIDEO_GET_OUTPUT_DEVICE_POWER_STATE = 0x230010;
        public const uint IOCTL_VIDEO_GET_POWER_MANAGEMENT = 0x230470;
        public const uint IOCTL_VIDEO_HANDLE_VIDEOPARAMETERS = 0x230020;
        public const uint IOCTL_VIDEO_INIT_WIN32K_CALLBACKS = 0x23001c;
        public const uint IOCTL_VIDEO_IS_VGA_DEVICE = 0x230024;
        public const uint IOCTL_VIDEO_LOAD_AND_SET_FONT = 0x230414;
        public const uint IOCTL_VIDEO_MAP_VIDEO_MEMORY = 0x230458;
        public const uint IOCTL_VIDEO_MONITOR_DEVICE = 0x230014;
        public const uint IOCTL_VIDEO_PREPARE_FOR_EARECOVERY = 0x23002c;
        public const uint IOCTL_VIDEO_QUERY_AVAIL_MODES = 0x230400;
        public const uint IOCTL_VIDEO_QUERY_COLOR_CAPABILITIES = 0x230468;
        public const uint IOCTL_VIDEO_QUERY_CURRENT_MODE = 0x230408;
        public const uint IOCTL_VIDEO_QUERY_CURSOR_ATTR = 0x23042c;
        public const uint IOCTL_VIDEO_QUERY_CURSOR_POSITION = 0x230434;
        public const uint IOCTL_VIDEO_QUERY_DISPLAY_BRIGHTNESS = 0x230498;
        public const uint IOCTL_VIDEO_QUERY_NUM_AVAIL_MODES = 0x230404;
        public const uint IOCTL_VIDEO_QUERY_POINTER_ATTR = 0x230444;
        public const uint IOCTL_VIDEO_QUERY_POINTER_CAPABILITIES = 0x230450;
        public const uint IOCTL_VIDEO_QUERY_POINTER_POSITION = 0x23044c;
        public const uint IOCTL_VIDEO_QUERY_PUBLIC_ACCESS_RANGES = 0x230460;
        public const uint IOCTL_VIDEO_QUERY_SUPPORTED_BRIGHTNESS = 0x230494;
        public const uint IOCTL_VIDEO_REGISTER_VDM = 0x230008;
        public const uint IOCTL_VIDEO_RESET_DEVICE = 0x230410;
        public const uint IOCTL_VIDEO_RESTORE_HARDWARE_STATE = 0x230204;
        public const uint IOCTL_VIDEO_SAVE_HARDWARE_STATE = 0x230200;
        public const uint IOCTL_VIDEO_SET_BANK_POSITION = 0x230490;
        public const uint IOCTL_VIDEO_SET_CHILD_STATE_CONFIGURATION = 0x230488;
        public const uint IOCTL_VIDEO_SET_COLOR_LUT_DATA = 0x23047c;
        public const uint IOCTL_VIDEO_SET_COLOR_REGISTERS = 0x23041c;
        public const uint IOCTL_VIDEO_SET_CURRENT_MODE = 0x23040c;
        public const uint IOCTL_VIDEO_SET_CURSOR_ATTR = 0x230428;
        public const uint IOCTL_VIDEO_SET_CURSOR_POSITION = 0x230430;
        public const uint IOCTL_VIDEO_SET_DISPLAY_BRIGHTNESS = 0x23049c;
        public const uint IOCTL_VIDEO_SET_OUTPUT_DEVICE_POWER_STATE = 0x23000c;
        public const uint IOCTL_VIDEO_SET_PALETTE_REGISTERS = 0x230418;
        public const uint IOCTL_VIDEO_SET_POINTER_ATTR = 0x230440;
        public const uint IOCTL_VIDEO_SET_POINTER_POSITION = 0x230448;
        public const uint IOCTL_VIDEO_SET_POWER_MANAGEMENT = 0x23046c;
        public const uint IOCTL_VIDEO_SHARE_VIDEO_MEMORY = 0x230474;
        public const uint IOCTL_VIDEO_SWITCH_DUALVIEW = 0x23048c;
        public const uint IOCTL_VIDEO_UNMAP_VIDEO_MEMORY = 0x23045c;
        public const uint IOCTL_VIDEO_UNSHARE_VIDEO_MEMORY = 0x230478;
        public const uint IOCTL_VIDEO_USE_DEVICE_IN_SESSION = 0x230028;
        public const uint IOCTL_VIDEO_VALIDATE_CHILD_STATE_CONFIGURATION = 0x230484;
        public const uint IOCTL_VOLSNAP_FLUSH_AND_HOLD_WRITES = 0x53c000;
        public const uint IOCTL_VOLUME_ALLOCATE_BC_STREAM = 0x56c040;
        public const uint IOCTL_VOLUME_BC_VERSION = 0x1;
        public const uint IOCTL_VOLUME_FREE_BC_STREAM = 0x56c044;
        public const uint IOCTL_VOLUME_GET_BC_PROPERTIES = 0x56403c;
        public const uint IOCTL_VOLUME_GET_GPT_ATTRIBUTES = 0x560038;
        public const uint IOCTL_VOLUME_GET_VOLUME_DISK_EXTENTS = 0x560000;
        public const uint IOCTL_VOLUME_IS_CLUSTERED = 0x560030;
        public const uint IOCTL_VOLUME_IS_DYNAMIC = 0x560048;
        public const uint IOCTL_VOLUME_IS_IO_CAPABLE = 0x560014;
        public const uint IOCTL_VOLUME_IS_OFFLINE = 0x560010;
        public const uint IOCTL_VOLUME_IS_PARTITION = 0x560028;
        public const uint IOCTL_VOLUME_LOGICAL_TO_PHYSICAL = 0x560020;
        public const uint IOCTL_VOLUME_OFFLINE = 0x56c00c;
        public const uint IOCTL_VOLUME_ONLINE = 0x56c008;
        public const uint IOCTL_VOLUME_PHYSICAL_TO_LOGICAL = 0x560024;
        public const uint IOCTL_VOLUME_PREPARE_FOR_CRITICAL_IO = 0x56c04c;
        public const uint IOCTL_VOLUME_PREPARE_FOR_SHRINK = 0x56c05c;
        public const uint IOCTL_VOLUME_QUERY_ALLOCATION_HINT = 0x564052;
        public const uint IOCTL_VOLUME_QUERY_FAILOVER_SET = 0x560018;
        public const uint IOCTL_VOLUME_QUERY_MINIMUM_SHRINK_SIZE = 0x564058;
        public const uint IOCTL_VOLUME_QUERY_VOLUME_NUMBER = 0x56001c;
        public const uint IOCTL_VOLUME_READ_PLEX = 0x56402e;
        public const uint IOCTL_VOLUME_SET_GPT_ATTRIBUTES = 0x560034;
        public const uint IOCTL_VOLUME_SUPPORTS_ONLINE_OFFLINE = 0x560004;
        public const uint IOCTL_VOLUME_UPDATE_PROPERTIES = 0x560054;
        public const uint IOCTL_WAIT_ON_DEVICE_EVENT = 0x80002008;
        public const uint IOCTL_WMP_DEVICE_CAN_SYNC = 0x32504d57;
        public const uint IOCTL_WMP_METADATA_ROUND_TRIP = 0x31504d57;
        public const uint IOCTL_WPD_MESSAGE_READWRITE_ACCESS = 0x40c108;
        public const uint IOCTL_WPD_MESSAGE_READ_ACCESS = 0x404108;
        public const uint IOCTL_WRITE_REGISTERS = 0x80002010;
    }
}
