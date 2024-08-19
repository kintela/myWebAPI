namespace KintelaAPI.DTOs
{
    public class GrupoDTO
    {
        public GrupoDTO(int grupoId, string nombre)
        {
            GrupoId = grupoId;
            Nombre = nombre;
        }
        public int GrupoId { get; init; }
        public string Nombre { get; init; }
    }
}
