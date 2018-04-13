namespace Djlastnight.Win32.Win32CreateFile
{
    using System;

    [Flags]
    internal enum FileAccess : uint
    {
        NONE = 0,

        GENERIC_ALL = 0x10000000,
        GENERIC_EXECUTE = 0x20000000,
        GENERIC_READ = 0x80000000,
        GENERIC_WRITE = 0x40000000,

        FILE_READ_DATA = (0x0001),  // file & pipe
        FILE_LIST_DIRECTORY = (0x0001),  // directory

        FILE_WRITE_DATA = (0x0002),   // file & pipe
        FILE_ADD_FILE = (0x0002),  // directory

        FILE_APPEND_DATA = (0x0004), // file
        FILE_ADD_SUBDIRECTORY = (0x0004),  // directory
        FILE_CREATE_PIPE_INSTANCE = (0x0004),   // named pipe

        FILE_READ_EA = (0x0008),  // file & directory

        FILE_WRITE_EA = (0x0010),    // file & directory

        FILE_EXECUTE = (0x0020),    // file
        FILE_TRAVERSE = (0x0020),    // directory

        FILE_DELETE_CHILD = (0x0040),    // directory

        FILE_READ_ATTRIBUTES = (0x0080),    // all

        FILE_WRITE_ATTRIBUTES = (0x0100),    // all

        FILE_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF),

        FILE_GENERIC_READ = (STANDARD_RIGHTS_READ | FILE_READ_DATA | FILE_READ_ATTRIBUTES | FILE_READ_EA | SYNCHRONIZE),
        FILE_GENERIC_WRITE = (STANDARD_RIGHTS_WRITE | FILE_WRITE_DATA | FILE_WRITE_ATTRIBUTES | FILE_WRITE_EA | FILE_APPEND_DATA | SYNCHRONIZE),
        FILE_GENERIC_EXECUTE = (STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE),

        DELETE = (0x00010000),
        READ_CONTROL = (0x00020000),
        WRITE_DAC = (0x00040000),
        WRITE_OWNER = (0x00080000),
        SYNCHRONIZE = (0x00100000),

        STANDARD_RIGHTS_REQUIRED = (0x000F0000),

        STANDARD_RIGHTS_READ = (READ_CONTROL),
        STANDARD_RIGHTS_WRITE = (READ_CONTROL),
        STANDARD_RIGHTS_EXECUTE = (READ_CONTROL),

        STANDARD_RIGHTS_ALL = (0x001F0000),

        SPECIFIC_RIGHTS_ALL = (0x0000FFFF),

        ACCESS_SYSTEM_SECURITY = (0x01000000),

        MAXIMUM_ALLOWED = (0x02000000)
    }
}