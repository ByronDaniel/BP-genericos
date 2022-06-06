public class ArrayGenerico<T>
{
    public ArrayGenerico(int longitud)
    {
        Longitud = longitud;
        Datos = new T[Longitud];
    }
    
    private int Longitud { get; set; }
    private T[] Datos { get; set; }

    public void AgregarDato(int index, T dato)
    {
        if(index >= 0 && index < Longitud)
            Datos[index] = dato;
    }

    public T VerDato(int index)
    {
        if (index >= 0 && index < Longitud)
            return Datos[index];
        else
            return default(T);
    }
}