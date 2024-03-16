using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1App1
{
    public class Grifo
    {
        private List<Usuario> usuarios;

        public Grifo()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            foreach (Usuario usuario in usuarios)
            {
                usuario.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
