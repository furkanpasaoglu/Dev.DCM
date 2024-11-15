using System.ComponentModel.DataAnnotations.Schema;
using Dev.DCM.Entities.Aihs;
using Dev.DCM.Entities.FixedLines;
using Dev.DCM.Entities.GsmDetails;
using Dev.DCM.Entities.InternetServices;

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

        public bool? IsActive { get; set; }

        [ForeignKey(nameof(Subscriber))]
        public Guid SubscriberId { get; set; }
        public Subscriber Subscriber { get; set; } 

        [ForeignKey(nameof(FixedLine))]
        public Guid FixedLineId { get; set; }
        public FixedLine FixedLine { get; set; }
        
        [ForeignKey(nameof(GsmDetail))]
        public Guid GsmDetailId { get; set; }
        public GsmDetail GsmDetail { get; set; }
        
        [ForeignKey(nameof(InternetService))]
        public Guid InternetServiceId { get; set; }
        public InternetService InternetService { get; set; }
        
        [ForeignKey(nameof(Satellite))]
        public Guid SatelliteId { get; set; }
        public Satellite Satellite { get; set; }
        
        [ForeignKey(nameof(Aih))]
        public Guid AihId { get; set; }
        public Aih Aih { get; set; }
    }
}
