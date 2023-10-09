using System;
using System.Collections.Generic;

namespace Registro.BL
{
    public class RegistroBL
    {
        private List<Registro> registros; // Supongamos que tienes una lista de registros

        public RegistroBL()
        {
            registros = new List<Registro>();
        }

        // Métodos de la capa de lógica de negocio

        public void AgregarRegistro(Registro registro)
        {
            registros.Add(registro);
        }

        public List<Registro> ObtenerRegistros()
        {
            return registros;
        }

        public Registro ObtenerRegistroPorID(int id)
        {
            return registros.Find(r => r.ID == id);
        }

        public void ActualizarRegistro(Registro registro)
        {
            var registroExistente = registros.FindIndex(r => r.ID == registro.ID);
            if (registroExistente >= 0)
            {
                registros[registroExistente] = registro;
            }
            else
            {
                throw new Exception("El registro no existe");
            }
        }

        public void EliminarRegistro(int id)
        {
            var registroExistente = registros.Find(r => r.ID == id);
            if (registroExistente != null)
            {
                registros.Remove(registroExistente);
            }
            else
            {
                throw new Exception("El registro no existe");
            }
        }

        // Otros métodos y lógica de negocio relacionados con la clase "Registro"
    }
}
