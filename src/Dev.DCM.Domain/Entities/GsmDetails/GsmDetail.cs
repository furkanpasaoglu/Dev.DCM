using Dev.DCM.Entities.Lines;

namespace Dev.DCM.Entities.GsmDetails
{
    /// <summary>
    /// GSM
    /// </summary>
    public class GsmDetail : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// GSM_ONCEKI_HAT_NUMARASI
        /// </summary>
        public string? PreviousGsmNumber { get; set; }

        /// <summary>
        /// GSM_DONDURULMA_TARIHI
        /// </summary>
        public DateTime? FrozenDate { get; set; }

        /// <summary>
        /// GSM_KISITLAMA_TARIHI
        /// </summary>
        public DateTime? RestrictionDate { get; set; }

        /// <summary>
        /// GSM_YURTDISI_AKTIF
        /// </summary>
        public bool? IsInternationalActive { get; set; }

        /// <summary>
        /// GSM_SESLI_ARAMA_AKTIF
        /// </summary>
        public bool? IsVoiceCallActive { get; set; }

        /// <summary>
        /// GSM_REHBER_AKTIF
        /// </summary>
        public bool? IsDirectoryActive { get; set; }

        /// <summary>
        /// GSM_CLIR_OZELLIGI_AKTIF
        /// </summary>
        public bool? IsClirFeatureActive { get; set; }

        /// <summary>
        /// GSM_DATA_AKTIF
        /// </summary>
        public bool? IsDataActive { get; set; }

        /// <summary>
        /// GSM_ESKART_BILGISI
        /// </summary>
        public string? EsKartInfo { get; set; }

        /// <summary>
        /// GSM_ICCI
        /// </summary>
        public string? Icci { get; set; }

        /// <summary>
        /// GSM_IMSI
        /// </summary>
        public string? Imsi { get; set; }

        /// <summary>
        /// GSM_DUAL_GSM_NO
        /// </summary>
        public string? DualGsmNumber { get; set; }

        /// <summary>
        /// GSM_FAX_NO
        /// </summary>
        public string? FaxNumber { get; set; }

        /// <summary>
        /// GSM_VPN_KISAKOD_ARAMA_AKTIF
        /// </summary>
        public bool IsVpnShortCodeCallActive { get; set; }

        /// <summary>
        /// GSM_SERVIS_NUMARASI
        /// </summary>
        public string? ServiceNumber { get; set; }

        /// <summary>
        /// GSM_BILGI_1
        /// </summary>
        public string? Info1 { get; set; }

        /// <summary>
        /// GSM_BILGI_2
        /// </summary>
        public string? Info2 { get; set; }

        /// <summary>
        /// GSM_BILGI_3
        /// </summary>
        public string? Info3 { get; set; }

        /// <summary>
        /// GSM_ALFANUMERIK_BASLIK
        /// </summary>
        public string? AlphanumericTitle { get; set; }
        
        public Guid LineId { get; set; }
    }
}
