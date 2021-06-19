namespace CodingAssignment.Contracts.V1
{
  public static class ApiRoutes
  {
    public const string Version = "v1";
    public const string Root = "api";
    public const string Base = Root + "/" + Version;

    public static class Files
    {
      public const string GetAll = Base + "/files";
      public const string Get = Base + "/files/{fileId}";
      public const string Create = Base + "/files";
      public const string Update = Base + "/files/{fileId}";
      public const string Delete = Base + "/files/{fileId}";
    }
  }
}