using System;
using System.Collections.Generic;
using System.Linq;

namespace InicioSesion.DAL
{
    public class InicioSesionDAL
    {
        private List<InicioSesion> sesiones; // Supongamos que utilizamos una lista en memoria como ejemplo

        public InicioSesionDAL()
        {
            // Inicializamos la lista ficticia de sesiones
            sesiones = new List<InicioSesion>();
        }

        // Métodos de acceso a datos

        public void AgregarSesion(InicioSesion sesion)
        {
            sesion.ID = ObtenerNuevoID(); // Asignar un nuevo ID antes de agregar
            sesiones.Add(sesion);
        }

        public List<InicioSesion> ObtenerTodasLasSesiones()
        {
            return sesiones;
        }

        public InicioSesion ObtenerSesionPorID(int id)
        {
            return sesiones.FirstOrDefault(s => s.ID == id);
        }

        public void ActualizarSesion(InicioSesion sesion)
        {
            var sesionExistente = sesiones.FirstOrDefault(s => s.ID == sesion.ID);
            if (sesionExistente != null)
            {
                // Actualizar los datos de la sesión existente
                sesionExistente.Nombre = sesion.Nombre;
                sesionExistente.Apellido = sesion.Apellido;
                sesionExistente.Correo = sesion.Correo;
                sesionExistente.Contraseña = sesion.Contraseña;
                sesionExistente.Telefono = sesion.Telefono;
                sesionExistente.Direccion = sesion.Direccion;
            }
            else
            {
                throw new Exception("La sesión no existe");
            }
        }

        public void EliminarSesion(int id)
        {
            var sesionExistente = sesiones.FirstOrDefault(s => s.ID == id);
            if (sesionExistente != null)
            {
                sesiones.Remove(sesionExistente);
            }
            else
            {
                throw new Exception("La sesión no existe");
            }
        }

        // Métodos adicionales de acceso a datos según sea necesario

        private int ObtenerNuevoID()
        {
            // En un escenario real, este método debe obtener un nuevo ID de la base de datos
            // o de otro almacenamiento de datos y garantizar su unicidad.
            // Aquí simplemente estamos simulando un nuevo ID para fines de demostración.
            return sesiones.Count > 0 ? sesiones.Max(s => s.ID) + 1 : 1;
        }
    }
}
