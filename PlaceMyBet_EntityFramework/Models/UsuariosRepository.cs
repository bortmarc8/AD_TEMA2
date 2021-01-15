using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet_EntityFramework.Models
{
    public class UsuariosRepository
    {
        internal List<Usuario> Retrieve()
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                List<Usuario> usuarios = context
                    .Usuarios
                    .ToList();
                return usuarios;
            }

        }

        internal Usuario Retrieve(string id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Usuario usuario = context
                    .Usuarios
                    .Where(s => s.UsuarioId == id)
                    .FirstOrDefault();

                return usuario;
            }

        }

        internal void Delete(string id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Usuario usuario = context.Usuarios
                .Where(s => s.UsuarioId == id)
                .FirstOrDefault();
                context.Remove(usuario);
                context.SaveChanges();
            }
        }
    }
}