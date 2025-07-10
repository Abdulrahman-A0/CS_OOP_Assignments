namespace OOP_02
{
    [Flags]
    public enum SecurityLevel
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8,
    }
}
