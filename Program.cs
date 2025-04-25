using demopoo;
using demopoo.Equipo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string[] opcionesMenu = {
            "1. Registrar Club",
            "2. Registrar Jugador",
            "3. Listar Clubes",
            "4. Listar Jugadores",
            "5. Salir"
        };
        Console.WriteLine("Sistema de gestión de la Conmebol Libertadores.");
        Utilidades.LeerCaracter("Sistema de gestión de la Libertadores", opcionesMenu);
        // // Crear una instancia de la clase Player
        // List<Club> clubes = new List<Club>();
        // bool continuar = true;
        // Club club;
        // do{
        //     Console.Clear();
        //     Console.WriteLine("Sistema de gestión de la Conmebol Libertadores.");
        //     Console.WriteLine(menu);

        //     club = new Club();
        //     Console.Clear();
        //     Console.WriteLine("Bienvenido al sistema de gestión de jugadores de fútbol.");

        //     Console.WriteLine("Por favor ingrese el Id del Club");
        //     club.Id = Console.ReadLine();
        //     Console.WriteLine("Por favor ingrese el nombre del Club");
        //     club.Nombre = Console.ReadLine()?.ToUpper();

        //     clubes.Add(club);

        //     Console.Write("¿Desea continuar? (S/N): ");
        //     continuar = Utilidades.LeerTecla();

        // }while (continuar);
        // Console.Clear();
        // Console.WriteLine("Lista de clubes registrados:");
        // foreach(Club myClub in clubes){
        //     Console.WriteLine($"Id: {myClub.Id} Nombre: {myClub.Nombre}");
        // }
    }


}
