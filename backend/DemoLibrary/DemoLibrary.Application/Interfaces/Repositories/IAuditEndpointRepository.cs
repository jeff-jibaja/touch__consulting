namespace DemoLibrary.Application.Interfaces.Repositories
{ 
    public interface IAuditEndpointRepository 
    { 
        /// <summary>
        /// Eliminar registros antiguos por lotes
        /// </summary>
        Task<int> DeleteOlds(CancellationToken cancellationToken = default);
    }
}
