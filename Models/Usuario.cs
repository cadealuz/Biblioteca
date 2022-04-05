using System;

namespace Biblioteca.Models
{
    public class Usuario
    {
        public static int ADMIN = 0;
        public static int PADRAO = 1;
        public int Id{get; set;}
        public String Nome{get; set;}
        public String Login{get; set;}
        public String Senha{get; set;}
        public int Tipo {get; set;}
        
    }
}