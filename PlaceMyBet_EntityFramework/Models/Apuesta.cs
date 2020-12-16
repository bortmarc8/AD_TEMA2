using System;

namespace PlaceMyBet_EntityFramework.Models
{
    public class Apuesta
    {
        public Apuesta()
        {

        }

        public Apuesta(int apuestaId, double dinero, double cuota, bool tipoApuesta, DateTime fecha, int mercadoId, string usuarioId)
        {
            ApuestaId = apuestaId;
            Dinero = dinero;
            Cuota = cuota;
            TipoApuesta = tipoApuesta;
            Fecha = fecha;
            MercadoId = mercadoId;
            UsuarioId = usuarioId;
        }

        public int ApuestaId { get; set; }
        public double Dinero { get; set; }
        public double Cuota { get; set; }
        public bool TipoApuesta { get; set; }
        public DateTime Fecha { get; set; }
        public Mercado Mercado { get; set; }
        public int MercadoId { get; set; }
        public Usuario Usuario { get; set; }
        public string UsuarioId { get; set; }

    }

}