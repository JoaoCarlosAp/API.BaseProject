namespace API.BaseProject.Domain.Entities
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public int ContaId { get; set; }
        public Conta? Conta { get; set; }
    }
}
