namespace BookModule;

public static class BookModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "BookModule";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "BookModule";
}
