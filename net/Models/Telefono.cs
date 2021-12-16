namespace net.Models
{
    public class Telefono
    {
         public int Numero { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
    
        public Telefono(int Numero, string Modelo, double Precio)

        {   this.Numero=Numero;
            this.Modelo=Modelo;
            this.Precio=Precio;

            }
    
        public Telefono()
        {

        }
        
    }

}