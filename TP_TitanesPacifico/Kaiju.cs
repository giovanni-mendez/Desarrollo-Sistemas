namespace TP_TitanesPacifico;

public class Kaiju
{
    public string nombre;
    public List<Habilidad> habilidades;
    public Categoria categoria;
    public int peso;
    public int tamanio;

    public Kaiju (string nombre, List<Habilidad> habilidades, Categoria categoria, int peso, int tamanio)
    {
        this.nombre = nombre;
        this.habilidades = habilidades;
        this.categoria = categoria;
        this.peso = peso;
        this.tamanio = tamanio;
    }

    public int danioTotalDeHabilidades(List<Habilidad> habilidades)
    {
        int danioTotal = 0;

        for (int i = 0; i < habilidades.Count; i++)
        {
            danioTotal += habilidades[i].danio;
        }

        return danioTotal;
    }

    public int PoderPelea(Categoria categoria, List<Habilidad> habilidades)
    {
        int danioTotal = danioTotalDeHabilidades(habilidades);

        int PoderPelea = danioTotal * categoria.energia;

        return PoderPelea;
    }
}