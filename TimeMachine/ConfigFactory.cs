namespace TimeMachine;

public static class ConfigFactory
{
    public static string GetConnectionString() => string.Format("server=localhost;user id=sa;password={0};initial catalog=timemachine;TrustServerCertificate=True", GetDbPass());

    private static string GetDbPass() 
        => Environment.GetEnvironmentVariable("TIMEMACHINE_DBPASS") 
        ?? throw new ArgumentException("missing environment variable TIMEMACHINE_DBPASS");
}
