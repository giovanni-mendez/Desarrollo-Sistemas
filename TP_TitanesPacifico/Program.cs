using TP_TitanesPacifico;


Habilidad habilidad1 = new Habilidad("Rayo de plasma", 50);
Habilidad habilidad2 = new Habilidad("Pulso electromagnético", 30);
Habilidad habilidad3 = new Habilidad("Garra cortante", 20);

List<Habilidad> habilidades = new List<Habilidad> { habilidad1, habilidad2, habilidad3 };

Categoria categoria = new Categoria(dureza: 100, energia: 4, vida: 300);

Kaiju kaiju = new Kaiju(nombre: "Moskov", habilidades: habilidades, categoria: categoria, peso: 3000, tamanio: 80);

int danioTotal = kaiju.danioTotalDeHabilidades(habilidades);
int poderDePelea = kaiju.PoderPelea(categoria, habilidades);

Console.WriteLine($"Kaiju: {kaiju.nombre}");
Console.WriteLine($"Daño total de habilidades: {danioTotal}");
Console.WriteLine($"Poder de pelea: {poderDePelea}");
