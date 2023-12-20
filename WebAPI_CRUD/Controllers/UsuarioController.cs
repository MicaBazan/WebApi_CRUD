using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPI_CRUD.Data;
using WebAPI_CRUD.Models;

namespace WebAPI_CRUD.Controllers
{
    // Controller: INterfaz que vamos a estar llamando desde nuestra URL
    public class UsuarioController
    {
        // GET api/<controller>
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }

        // GET api/<controller>/5
        public Usuario Get(int id)
        {
            return UsuarioData.Obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Registrar(oUsuario);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.Modificar(oUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return UsuarioData.Eliminar(id);
        }
    }
}