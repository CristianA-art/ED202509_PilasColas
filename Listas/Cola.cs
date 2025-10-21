namespace Listas;
internal class Cola
{
    private List<string> _lista;

    public Cola()
    {
        _lista = new List<string>();
    }

    // Agregar al final de la cola
    public void Agregar(string dato)
    {
        _lista.Add(dato);
    }

    // Eliminar del frente de la cola
    public void Eliminar()
    {
        if (_lista.Count == 0)
        {
            throw new Exception("Cola vacía");
        }

        _lista.RemoveAt(0);
    }

    // Imprimir los elementos actuales de la cola
    public string Imprimir()
    {
        string datos = string.Empty;

        foreach (string item in _lista)
        {
            datos += item + Environment.NewLine;
        }

        return datos;
    }
}