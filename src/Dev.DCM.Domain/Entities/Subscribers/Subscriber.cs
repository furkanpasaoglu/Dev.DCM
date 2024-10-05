namespace Dev.DCM.Entities.Subscribers;

/// <summary>
/// ABONE Entity
/// </summary>
public class Subscriber : FullAuditedEntity<Guid>
{
    /// <summary>
    /// MUSTERI_ID
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// MUSTERI_TIPI
    /// </summary>
    public int? CustomerType { get; set; }

    /// <summary>
    /// ABONE_BASLANGIC
    /// </summary>
    public DateTime? SubscriptionStart { get; set; }

    /// <summary>
    /// ABONE_BITIS
    /// </summary>
    public DateTime? SubscriptionEnd { get; set; }

    /// <summary>
    /// ABONE_ADI
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// ABONE_SOYADI
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// ABONE_TC_KIMLIK_NO
    /// </summary>
    public string? NationalId { get; set; }

    /// <summary>
    /// ABONE_PASAPORT_NO
    /// </summary>
    public string? PassportNumber { get; set; }

    /// <summary>
    /// ABONE_UNVAN
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// ABONE_VERGI_NUMARASI
    /// </summary>
    public string? TaxNumber { get; set; }

    /// <summary>
    /// ABONE_MERSIS_NUMARASI
    /// </summary>
    public string? MersisNumber { get; set; }

    /// <summary>
    /// ABONE_CINSIYET
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// ABONE_UYRUK
    /// </summary>
    public string? Nationality { get; set; }

    /// <summary>
    /// ABONE_BABA_ADI
    /// </summary>
    public string? FatherName { get; set; }

    /// <summary>
    /// ABONE_ANA_ADI
    /// </summary>
    public string? MotherName { get; set; }

    /// <summary>
    /// ABONE_ANNE_KIZLIK_SOYADI
    /// </summary>
    public string? MotherMaidenName { get; set; }

    /// <summary>
    /// ABONE_DOGUM_YERI
    /// </summary>
    public string? BirthPlace { get; set; }

    /// <summary>
    /// ABONE_DOGUM_TARIHI
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// ABONE_MESLEK
    /// </summary>
    public string? Occupation { get; set; }

    /// <summary>
    /// ABONE_TARIFE
    /// </summary>
    public string? Tariff { get; set; }

    /// <summary>
    /// ABONE_KIMLIK
    /// </summary>
    public IdentityDocument? IdentityDocument { get; set; }

    /// <summary>
    /// ABONE_ADRES
    /// </summary>
    public Address? EmailAddress { get; set; }
}
