namespace API.BaseProject.Domain.Entities
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public ICollection<Perfil> Perfis { get; set; } = new List<Perfil>();
    }
}
