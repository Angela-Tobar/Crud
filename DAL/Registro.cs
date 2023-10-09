using System;
using System.Collections.Generic;
using System.Linq;


namespace Registro.DAL
{
    public class RegistroDAL
    {
        private List<Registro> registros; // Supongamos que utilizamos una lista en memoria como ejemplo

        public RegistroDAL()
        {
            // Inicializamos la lista ficticia de registros
            registros = new List<Registro>();
        }

        // Métodos de acceso a datos

        public void AgregarRegistro(Registro registro)
        {
            registro.ID = ObtenerNuevoID(); // Asignar un nuevo ID antes de agregar
            registros.Add(registro);
        }

        public List<Registro> ObtenerTodosLosRegistros()
        {
            return registros;
        }

        public Registro ObtenerRegistroPorID(int id)
        {
            return registros.FirstOrDefault(r => r.ID == id);
        }

        public void ActualizarRegistro(Registro registro)
        {
            var registroExistente = registros.FirstOrDefault(r => r.ID == registro.ID);
            if (registroExistente != null)
            {
                // Actualizar los datos del registro existente
                registroExistente.Nombre = registro.Nombre;
                registroExistente.Apellido = registro.Apellido;
                registroExistente.Correo = registro.Correo;
                registroExistente.Contraseña = registro.Contraseña;
                registroExistente.Telefono = registro.Telefono;
                registroExistente.Direccion = registro.Direccion;
            }
            else
            {
                throw new Exception("El registro no existe");
            }
        }

        public void EliminarRegistro(int id)
        {
            var registroExistente = registros.FirstOrDefault(r => r.ID == id);
            if (registroExistente != null)
            {
                registros.Remove(registroExistente);
            }
            else
            {
                throw new Exception("El registro no existe");
            }
        }

        // Métodos adicionales de acceso a datos según sea necesario

        private int ObtenerNuevoID()
        {
            // En un escenario real, este método debe obtener un nuevo ID de la base de datos
            // o de otro almacenamiento de datos y garantizar su unicidad.
            // Aquí simplemente estamos simulando un nuevo ID para fines de demostración.
            return registros.Count > 0 ? registros.Max(r => r.ID) + 1 : 1;
        }
    }
}
