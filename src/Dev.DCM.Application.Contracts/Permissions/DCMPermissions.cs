namespace Dev.DCM.Permissions;

public static class DCMPermissions
{
    public const string GroupName = "DCM";
    public const string Locations = GroupName + ".Location";
    public const string Parameter = GroupName + ".Parameter";
    
    public static class Parameters
    {
        public const string Default = GroupName + ".Parameter";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class ServiceTypes
    {
        public const string Default = GroupName + ".ServiceType";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class LineStatusCodes
    {
        public const string Default = GroupName + ".LineStatusCode";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class JobCodes
    {
        public const string Default = GroupName + ".JobCode";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class IdentityTypes
    {
        public const string Default = GroupName + ".IdentityType";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class CustomerMovementCodes
    {
        public const string Default = GroupName + ".CustomerMovementCode";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    public static class Districts
    {
        public const string Default = Locations + ".District";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    public static class Cities
    {
        public const string Default = Locations + ".City";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    public static class Countries
    {
        public const string Default = Locations + ".Country"; 
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
