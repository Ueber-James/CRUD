namespace UsandoViews.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }



        private static List<Usuario> listagem = new List<Usuario>();

        public static IQueryable<Usuario> Listagem
        {
            get
            {
                return listagem.AsQueryable();
            }

        }


        static Usuario()
        {
            Usuario.listagem.Add( new Usuario{ Id = 1, Name = "Fulano", Email = "fulano@email.com"});

            Usuario.listagem.Add( new Usuario{ Id = 2, Name = "Fulano", Email = "fulano@email.com"});

            Usuario.listagem.Add( new Usuario{ Id = 3, Name = "Fulano", Email = "fulano@email.com"});

            Usuario.listagem.Add( new Usuario{ Id = 4, Name = "Fulano", Email = "fulano@email.com"});

            Usuario.listagem.Add( new Usuario{ Id = 5, Name = "Fulano", Email = "fulano@email.com"});
        }

        public static void Salvar(Usuario usuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.Id == usuario.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.Name = usuario.Name;
                usuarioExistente.Email = usuario.Email;
            }
            else{
                int maiorId = Usuario.Listagem.Max(u => u.Id);
                usuario.Id = maiorId + 1;
                Usuario.listagem.Add(usuario);
            }
        }

        public static void Excluir(int id)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.Id == id);
            if (usuarioExistente != null)
            {
                Usuario.listagem.Remove(usuarioExistente);
            }
           
        }



    }
}