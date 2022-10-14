namespace Repositorio.Entidades
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
