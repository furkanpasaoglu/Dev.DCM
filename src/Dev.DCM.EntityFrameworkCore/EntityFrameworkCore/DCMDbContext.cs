using Dev.DCM.Entities.Activations;
using Dev.DCM.Entities.Addresses;
using Dev.DCM.Entities.Aihs;
using Dev.DCM.Entities.AuthorizedPersons;
using Dev.DCM.Entities.Branches;
using Dev.DCM.Entities.Cities;
using Dev.DCM.Entities.ContactInfos;
using Dev.DCM.Entities.Countries;
using Dev.DCM.Entities.CustomerMovementCodes;
using Dev.DCM.Entities.CustomerMovements;
using Dev.DCM.Entities.Districts;
using Dev.DCM.Entities.FacilityAddresses;
using Dev.DCM.Entities.FixedLines;
using Dev.DCM.Entities.GsmDetails;
using Dev.DCM.Entities.IdentityDocuments;
using Dev.DCM.Entities.IdentityTypes;
using Dev.DCM.Entities.Institutions;
using Dev.DCM.Entities.InternetServices;
using Dev.DCM.Entities.JobCodes;
using Dev.DCM.Entities.Lines;
using Dev.DCM.Entities.LineStatusCodes;
using Dev.DCM.Entities.Parameters;
using Dev.DCM.Entities.Phones;
using Dev.DCM.Entities.ResidentialAddresses;
using Dev.DCM.Entities.Sales;
using Dev.DCM.Entities.SatellitePhones;
using Dev.DCM.Entities.Satellites;
using Dev.DCM.Entities.ServiceTypes;
using Dev.DCM.Entities.Subscribers;
using Dev.DCM.Entities.TenantDetails;
using Dev.DCM.Entities.Updaters;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Dev.DCM.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class DCMDbContext :
    AbpDbContext<DCMDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    //Entities
    public DbSet<Address> Addresses { get; set; }
    public DbSet<AuthorizedPerson> AuthorizedPersons { get; set; }
    public DbSet<ContactInfo> ContactInfos { get; set; }
    public DbSet<CustomerMovement> CustomerMovements { get; set; }
    public DbSet<FacilityAddress> FacilityAddresses { get; set; }
    public DbSet<FixedLine> FixedLines { get; set; }
    public DbSet<GsmDetail> GsmDetails { get; set; }
    public DbSet<IdentityDocument> IdentityDocuments { get; set; }
    public DbSet<Institution> Institutions { get; set; }
    public DbSet<InternetService> InternetServices { get; set; }
    public DbSet<Line> Lines { get; set; }
    public DbSet<ResidentialAddress> ResidentialAddresses { get; set; }
    public DbSet<SatellitePhone> SatellitePhones { get; set; }
    public DbSet<Satellite> Satellites { get; set; }
    public DbSet<Subscriber> Subscribers { get; set; }
    public DbSet<Aih> Aihs { get; set; }
    public DbSet<Updater> Updaters { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Activation> Activations { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<LineStatusCode> LineStatusCodes { get; set; }
    public DbSet<JobCode> JobCodes { get; set; }
    public DbSet<IdentityType> IdentityTypes { get; set; }
    public DbSet<CustomerMovementCode> CustomerMovementCodes { get; set; }
    public DbSet<Parameter> Parameters { get; set; }
    public DbSet<TenantDetail> TenantDetails { get; set; }

    #endregion

    public DCMDbContext(DbContextOptions<DCMDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        builder.Entity<TenantDetail>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "TenantDetails", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<AuthorizedPerson>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "AuthorizedPersons", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Address>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Addresses", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });
         
        builder.Entity<ContactInfo>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "ContactInfos", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<CustomerMovement>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "CustomerMovements", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
          
        builder.Entity<FacilityAddress>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "FacilityAddresses", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
          
        builder.Entity<GsmDetail>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "GsmDetails", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
        
        builder.Entity<FixedLine>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "FixedLines", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
        
        builder.Entity<IdentityDocument>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "IdentityDocuments", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });
          
        builder.Entity<Institution>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Institutions", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });
          
        builder.Entity<InternetService>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "InternetServices", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });
        
        builder.Entity<Line>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Lines", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<ResidentialAddress>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "ResidentialAddresses", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });  
        
        builder.Entity<SatellitePhone>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "SatellitePhones", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
        
        builder.Entity<Satellite>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Satellites", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
        
        builder.Entity<Subscriber>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Subscribers", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Aih>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Aihs", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        }); 
        
        builder.Entity<Updater>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Updaters", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Branch>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Branches", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Activation>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Activations", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Phone>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Phones", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Sale>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Sales", DCMConsts.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<ServiceType>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "ServiceTypes", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x=>x.No).IsUnique();
            b.HasIndex(x => x.ServiceTypeValue).IsUnique();
        });
        
        builder.Entity<LineStatusCode>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "LineStatusCodes", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x=>x.Code).IsUnique();
        });
        
        builder.Entity<JobCode>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "JobCodes", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x=>x.Code).IsUnique();
            b.HasIndex(x=>x.No).IsUnique();
        });
        
        builder.Entity<IdentityType>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "IdentityTypes", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x=>x.No).IsUnique();
        });
        
        builder.Entity<CustomerMovementCode>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "CustomerMovementCodes", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x=>x.Code).IsUnique();
            b.HasIndex(x => x.Description).IsUnique();
        });

        builder.Entity<Country>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Countries", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x => x.Name).IsUnique();
            b.HasIndex(x => x.Code).IsUnique();
        });

        builder.Entity<City>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Cities", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x => x.Name).IsUnique();
        });

        builder.Entity<District>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Districts", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x => x.Name).IsUnique();
        });
        
        builder.Entity<Parameter>(b =>
        {
            b.ToTable(DCMConsts.DbTablePrefix + "Parameters", DCMConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(x=>x.Name).IsUnique();
        });
    }
}
