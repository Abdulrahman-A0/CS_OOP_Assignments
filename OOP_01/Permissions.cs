namespace OOP_01
{
    [Flags]
    internal enum Permissions
    {
        Read = 1,
        write = 2,
        Delete = 4,
        Execute = 8
    }
}
