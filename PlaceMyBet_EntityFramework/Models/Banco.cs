using System;

namespace PlaceMyBet_EntityFramework.Models
{
    public class Banco
    {
        public Banco()
        {

        }

        public Banco(int bancoId, double saldo, string nombre, int numTarjeta, string usuarioId)
        {
            BancoId = bancoId;
            Saldo = saldo;
            Nombre = nombre;
            NumTarjeta = numTarjeta;
            UsuarioId = usuarioId;
        }

        public int BancoId { get; set; }
        public double Saldo { get; set; }
        public string Nombre { get; set; }
        public int NumTarjeta { get; set; }
        public Usuario Usuario { get; set; }
        public string UsuarioId { get; set; }

    }
}