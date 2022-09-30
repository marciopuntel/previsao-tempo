namespace ClimaTempoSimples.Models
{
    public class Cidade: Entity
    {
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

    }
}