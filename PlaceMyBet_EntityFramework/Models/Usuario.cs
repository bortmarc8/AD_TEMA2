using System;
using System.Collections.Generic;

namespace PlaceMyBet_EntityFramework.Models
{
    public class Usuario
    {
        public Usuario()
        {
        
        }

        public Usuario(string usuarioId, string nombre, string apellidos, int edad)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public List<Apuesta> Apuestas { get; set; }
        public Banco Banco { get; set; }
    }
}