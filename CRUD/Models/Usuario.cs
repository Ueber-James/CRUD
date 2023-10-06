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


    }
}