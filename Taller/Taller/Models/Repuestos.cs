﻿namespace TallerMecanico.Models
{
    public class Repuesto
    {
        public int Id { get; set; }                   
        public string Nombre { get; set; } = string.Empty;  
        public decimal Precio { get; set; }          
        public int Cantidad { get; set; }             
    }
}
