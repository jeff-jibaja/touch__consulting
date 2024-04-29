using System.Runtime.Serialization;

namespace DemoLibrary.Application.Models.Adapters.CarrierDTOs
{
    public class CarrierDTO
    {
        #region Atributos
        [DataMember] public string CodTransportista { get; set; }
        [DataMember] public string NomTransportista { get; set; }
        [DataMember] public string DirTransportista { get; set; }
        [DataMember] public string RucTransportista { get; set; }
        #endregion

        #region Propiedades IDataContract
        [DataMember] public int Options { get; set; }
        [DataMember] public string UserNew { get; set; }
        [DataMember] public DateTime DateNew { get; set; }
        [DataMember] public string UserEdit { get; set; }
        [DataMember] public DateTime DateEdit { get; set; }
        [DataMember] public string Status { get; set; }
        [DataMember] public int PageNumber { get; set; }
        [DataMember] public int NumberOfRecords { get; set; }
        #endregion
    }
}