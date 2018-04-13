namespace Djlastnight.Win32.Win32CreateFile
{
    internal enum CreationDisposition : uint
    {
        /// <summary>
        /// Creates a new file. The function fails if a specified file exists.
        /// </summary>
        CREATE_NEW = 1,

        /// <summary>
        /// Creates a new file, always.
        /// If a file exists, the function overwrites the file, clears the existing attributes, combines the specified file attributes,
        /// and flags with FILE_ATTRIBUTE_ARCHIVE, but does not set the security descriptor that the SECURITY_ATTRIBUTES structure specifies.
        /// </summary>
        CREATE_ALWAYS = 2,

        /// <summary>
        /// Opens a file. The function fails if the file does not exist.
        /// </summary>
        OPEN_EXISTING = 3,

        /// <summary>
        /// Opens a file, always.
        /// If a file does not exist, the function creates a file as if dwCreationDisposition is CREATE_NEW.
        /// </summary>
        OPEN_ALWAYS = 4,

        /// <summary>
        /// Opens a file and truncates it so that its size is 0 (zero) bytes. The function fails if the file does not exist.
        /// The calling process must open the file with the GENERIC_WRITE access right.
        /// </summary>
        TRUNCATE_EXISTING = 5
    }
}