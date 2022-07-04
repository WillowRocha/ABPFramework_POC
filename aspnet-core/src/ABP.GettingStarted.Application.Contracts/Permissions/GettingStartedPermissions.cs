namespace ABP.GettingStarted.Permissions;

public static class GettingStartedPermissions
{
    public const string GroupName = "GettingStarted";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Product
        {
            public const string Default = GroupName + ".Product";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
}
