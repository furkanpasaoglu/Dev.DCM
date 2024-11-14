namespace Dev.DCM.Permissions;

public static class DCMPermissions
{
    public const string GroupName = "DCM";

    // Genel İzinler
    public const string LocationPermission = GroupName + ".Locations";
    public const string ParameterPermission = GroupName + ".Parameters";
    public const string TenantDetailPermission = GroupName + ".TenantDetails";
    
    // Tenant Detayları
    public static class TenantDetails
    {
        public const string Default = GroupName + ".TenantDetails";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    // Parametreler
    public static class Parameters
    {
        public const string Default = GroupName + ".Parameters";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    
    // Türler Menüsü İzinleri
    public static class Types
    {
        // Servis Türleri
        public static class ServiceTypes
        {
            public const string Default = GroupName + ".Types.ServiceTypes";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        // Hat Durum Kodları
        public static class LineStatusCodes
        {
            public const string Default = GroupName + ".Types.LineStatusCodes";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        // İş Kodları
        public static class JobCodes
        {
            public const string Default = GroupName + ".Types.JobCodes";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        // Kimlik Türleri
        public static class IdentityTypes
        {
            public const string Default = GroupName + ".Types.IdentityTypes";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        // Müşteri Hareket Kodları
        public static class CustomerMovementCodes
        {
            public const string Default = GroupName + ".Types.CustomerMovementCodes";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }

    // Lokasyonlar
    public static class Locations
    {
        public static class Countries
        {
            public const string Default = GroupName + ".Locations.Countries";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        public static class Cities
        {
            public const string Default = GroupName + ".Locations.Cities";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

        public static class Districts
        {
            public const string Default = GroupName + ".Locations.Districts";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }
    }
}

