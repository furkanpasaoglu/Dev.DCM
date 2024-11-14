namespace Dev.DCM.Web.Menus;

public class DCMMenus
{
    private const string Prefix = "DCM";

    // Ana Menü
    public const string Home = Prefix + ".Home";

    // Türler Menüsü
    public const string Types = Prefix + ".Types";
    public const string ServiceTypes = Prefix + ".ServiceTypes";
    public const string LineStatusCodes = Prefix + ".LineStatusCodes";
    public const string CustomerMovementCodes = Prefix + ".CustomerMovementCodes";
    public const string IdentityTypes = Prefix + ".IdentityTypes";
    public const string JobCodes = Prefix + ".JobCodes";

    // Lokasyon Menüsü
    public const string LocationMenu = Prefix + ".Locations";
    public const string Countries = LocationMenu + ".Countries";
    public const string Cities = LocationMenu + ".Cities";
    public const string Districts = LocationMenu + ".Districts";

    // Parametreler Menüsü
    public const string Parameters = Prefix + ".Parameters";

    // Kiracı Detayları Menüsü
    public const string TenantDetails = Prefix + ".TenantDetails";
}

