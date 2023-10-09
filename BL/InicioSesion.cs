using System;
using System.Collections.Generic;

namespace MiProyecto.BL
{
    public class InicioSesionBL
    {
        private List<InicioSesion> usuarios; // Supongamos que tienes una lista de usuarios

        public InicioSesionBL()
        {
            usuarios = new List<InicioSesion>();
        }

        // Métodos de la capa de lógica de negocio

        public void AgregarUsuario(InicioSesion usuario)
        {
            usuarios.Add(usuario);
        }

        public List<InicioSesion> ObtenerUsuarios()
        {
            return usuarios;
        }

        public InicioSesion ObtenerUsuarioPorID(int id)
        {
            return usuarios.Find(u => u.ID == id);
        }

        public void ActualizarUsuario(InicioSesion usuario)
        {
            var usuarioExistente = usuarios.FindIndex(u => u.ID == usuario.ID);
            if (usuarioExistente >= 0)
            {
                usuarios[usuarioExistente] = usuario;
            }
            else
            {
                throw new Exception("El usuario no existe");
            }
        }

        public void EliminarUsuario(int id)
        {
            var usuarioExistente = usuarios.Find(u => u.ID == id);
            if (usuarioExistente != null)
            {
                usuarios.Remove(usuarioExistente);
            }
            else
            {
                throw new Exception("El usuario no existe");
            }
        }

        // Otros métodos y lógica de negocio relacionados con la clase "InicioSesion"
    }
}
