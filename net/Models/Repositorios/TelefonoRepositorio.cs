namespace net.Models.Repositorios
{
    public class TelefonoRepositorio
    {
        private static List<Telefono>Lista;
        public static List<Telefono> BuscarTodos()
        {
            return Lista;
        }
        static TelefonoRepositorio()
        {
            Lista = new List<Telefono>();
            Telefono T1 = new Telefono(678403779, "Samsung", 300);
            Telefono T2 = new Telefono(722987899, "xiaomi", 100);

            Lista.Add(T1);
            Lista.Add(T2);
}

        public static void Insertar(Telefono telefono)
        {
            Lista.Add(telefono);
}

         public static Telefono BuscarUna(int numero)

        {
            for (int i = 0; i < Lista.Count; i++)
            {

                if (Lista[i].Numero == numero)
                {
                    return Lista[i];
                }

            }
            return null;

        }
    
             public static void Borrar(int numero)

        {
            for (int i = 0; i < Lista.Count; i++)
            {

                if (Lista[i].Numero == numero)
                {
                    Lista.Remove(Lista[i]);
                    break;

                }

            }


        }
    }

}
