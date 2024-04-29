
namespace DemoLibrary.Application.Models.Adapters.CarrierDTOs
{
    public class CarrierListDTO
    {
        #region Atributos
        public string CodTransportista { get; set; }
        public string NomTransportista { get; set; }
        public string DirTransportista { get; set; }
        public string RucTransportista { get; set; }
        #endregion

        #region Propiedades IDataContract
        public int OPCION { get; set; }
        public string UserNew { get; set; }
        public DateTime DateNew { get; set; }
        public string UserEdit { get; set; }
        public DateTime DateEdit { get; set; }
        public string Status { get; set; }
        public int PageNumber { get; set; }
        public int NumberOfRecords { get; set; }
        #endregion
    }
}