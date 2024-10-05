namespace Dev.DCM.Entities.Lines
{
    /// <summary>
    /// HAT Entity
    /// </summary>
    public class Line : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// HAT_NO
        /// </summary>
        public int? LineNumber { get; set; }

        /// <summary>
        /// HAT_DURUM
        /// </summary>
        public string? LineStatus { get; set; }

        /// <summary>
        /// HAT_DURUM_KODU
        /// </summary>
        public int? LineStatusCode { get; set; }

        /// <summary>
        /// HAT_DURUM_KODU_ACIKLAMA
        /// </summary>
        public string? StatusCodeDescription { get; set; }
    }
}
