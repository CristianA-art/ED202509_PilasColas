namespace Listas
{
    internal class Pila
    {
        private List<string> _lista;

        public Pila()
        {
            _lista = new List<string>();
        }

        // Agregar elemento al tope de la pila
        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }

        // Eliminar el elemento del tope de la pila
        public void Eliminar()
        {
            if (_lista.Count == 0)
            {
                throw new Exception("No hay elementos");
            }

            _lista.RemoveAt(_lista.Count - 1);
        }

        // Imprimir todos los elementos desde el fondo hasta el tope
        public string Imprimir()
        {
            string datos = string.Empty;

            foreach (var item in _lista)
            {
                datos += item + Environment.NewLine;
            }

            return datos;
        }

        // Ver el elemento en el tope sin eliminarlo (opcional)
        public string VerTope()
        {
            if (_lista.Count == 0)
            {
                throw new Exception("La pila está vacía");
            }

            return _lista[_lista.Count - 1];
        }
    }

}
