using demopoo;
using demopoo.Equipo;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.Clear();
        // string[] opcionesMenu = {
        //     "1. Registrar Club",
        //     "2. Registrar Jugador",
        //     "3. Listar Clubes",
        //     "4. Listar Jugadores",
        //     "5. Salir"
        // };
        // Console.WriteLine("Sistema de gestión de la Conmebol Libertadores.");
        // Utilidades.LeerCaracter("Sistema de gestión de la Libertadores", opcionesMenu);
        
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
        // 
        var players = new List<Player>
        {
            new Player("P001", "Lionel", "Messi", "123456789", "messi@example.com", "Rosario, Argentina", "Delantero", 10, 100_000_000),
            new Player("P002", "Cristiano", "Ronaldo", "987654321", "ronaldo@example.com", "Funchal, Portugal", "Delantero", 7, 90_000_000),
            new Player("P003", "Neymar", "Junior", "456789123", "neymar@example.com", "São Paulo, Brasil", "Delantero", 11, 85_000_000),
            new Player("P004", "Kylian", "Mbappé", "321654987", "mbappe@example.com", "París, Francia", "Delantero", 7, 120_000_000),
            new Player("P005", "Kevin", "De Bruyne", "789456123", "debruyne@example.com", "Gante, Bélgica", "Centrocampista", 17, 95_000_000),
            new Player("P006", "Luka", "Modric", "654123789", "modric@example.com", "Zadar, Croacia", "Centrocampista", 10, 30_000_000),
            new Player("P007", "Virgil", "van Dijk", "741852963", "vandijk@example.com", "Breda, Países Bajos", "Defensor", 4, 75_000_000),
            new Player("P008", "Sergio", "Ramos", "159753486", "ramos@example.com", "Sevilla, España", "Defensor", 4, 25_000_000),
            new Player("P009", "Manuel", "Neuer", "369258147", "neuer@example.com", "Gelsenkirchen, Alemania", "Portero", 1, 20_000_000),
            new Player("P010", "Thibaut", "Courtois", "258369147", "courtois@example.com", "Bree, Bélgica", "Portero", 1, 40_000_000),

            new Player("P011", "Erling", "Haaland", "111222333", "haaland@example.com", "Leeds, Inglaterra", "Delantero", 9, 130_000_000),
            new Player("P012", "Harry", "Kane", "222333444", "kane@example.com", "Londres, Inglaterra", "Delantero", 10, 85_000_000),
            new Player("P013", "Toni", "Kroos", "333444555", "kroos@example.com", "Greifswald, Alemania", "Centrocampista", 8, 30_000_000),
            new Player("P014", "Joshua", "Kimmich", "444555666", "kimmich@example.com", "Rottweil, Alemania", "Centrocampista", 6, 70_000_000),
            new Player("P015", "Jude", "Bellingham", "555666777", "bellingham@example.com", "Stourbridge, Inglaterra", "Centrocampista", 22, 100_000_000),
            new Player("P016", "Pedri", "González", "666777888", "pedri@example.com", "Tegueste, España", "Centrocampista", 8, 80_000_000),
            new Player("P017", "João", "Cancelo", "777888999", "cancelo@example.com", "Barreiro, Portugal", "Defensor", 27, 60_000_000),
            new Player("P018", "Andrew", "Robertson", "888999000", "robertson@example.com", "Glasgow, Escocia", "Defensor", 26, 55_000_000),
            new Player("P019", "Achraf", "Hakimi", "999000111", "hakimi@example.com", "Madrid, España", "Defensor", 2, 65_000_000),
            new Player("P020", "Alisson", "Becker", "000111222", "alisson@example.com", "Novo Hamburgo, Brasil", "Portero", 1, 50_000_000),

            new Player("P021", "Marc-André", "ter Stegen", "101112131", "terstegen@example.com", "Mönchengladbach, Alemania", "Portero", 1, 45_000_000),
            new Player("P022", "Declan", "Rice", "121314151", "rice@example.com", "Londres, Inglaterra", "Centrocampista", 41, 90_000_000),
            new Player("P023", "Bruno", "Fernandes", "131415161", "bruno@example.com", "Maia, Portugal", "Centrocampista", 8, 75_000_000),
            new Player("P024", "Riyad", "Mahrez", "141516171", "mahrez@example.com", "Sarcelles, Francia", "Extremo", 26, 40_000_000),
            new Player("P025", "Raheem", "Sterling", "151617181", "sterling@example.com", "Kingston, Jamaica", "Extremo", 7, 50_000_000),
            new Player("P026", "Vinícius", "Júnior", "161718191", "vinicius@example.com", "São Gonçalo, Brasil", "Extremo", 20, 110_000_000),
            new Player("P027", "Rodri", "Hernández", "171819202", "rodri@example.com", "Madrid, España", "Centrocampista", 16, 85_000_000),
            new Player("P028", "Phil", "Foden", "181920212", "foden@example.com", "Stockport, Inglaterra", "Centrocampista", 47, 95_000_000),
            new Player("P029", "Bernardo", "Silva", "192021222", "bernardo@example.com", "Lisboa, Portugal", "Centrocampista", 20, 70_000_000),
            new Player("P030", "Álvaro", "Morata", "202122232", "morata@example.com", "Madrid, España", "Delantero", 9, 30_000_000)
        };

        // solucion 1

        var jugador = from player in players
                      select new { player.Nombre, player.Apellido };
        foreach (var player in jugador)
        {
            Console.WriteLine($"Jugador {player.Nombre} {player.Apellido}");
        }

        // solucion 2

        var jugador2 = from player in players
                       select player;
        foreach (var player in jugador2)
        {
            Console.WriteLine($"Jugador {player.Nombre} {player.Apellido}");
        }

        // idk

        var jugadorpos = from player in players
                        group player by player.Position into grupo
                        select grupo;

        foreach (var grupo in jugadorpos){
            Console.WriteLine($"Posicion: {grupo.Key}");
            foreach (var player in grupo){
                Console.WriteLine($" - {player.Nombre} {player.Apellido}");
            }
        }
    }


}
