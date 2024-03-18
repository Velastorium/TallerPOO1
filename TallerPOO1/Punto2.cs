using System;
class Factura
{
    private string numpieza;
    private string descripcion;
    private int cantidad;
    private int precio;
    private Factura(string numpieza, string descripcion, int cantidad, int precio)
    {
        this.numpieza = numpieza;
        this.descripcion = descripcion;
        this.cantidad = cantidad;
        this.precio = precio;
    }
    public void EstablecerNumPieza(string numPieza)
    {
        this.numpieza = numPieza;
    }

    public string ObtenerNumPieza()
    {
        return numpieza;
    }
    public void EstablecerDescripcion(string descripcion)
    {
        this.descripcion = descripcion;
    }

    public string ObtenerDescripcion()
    {
        return descripcion;
    }
    public void EstablecerCantidad(int cantidad)
    {
        this.cantidad = cantidad;
    }

    public int ObtenerCantidad()
    {
        return cantidad;
    }

    public void EstablecerPrecio(int precio)
    {
        this.precio = precio;
    }

    public int ObtenerPrecio()
    {
        return precio;
    }

    public int obtenerMontoFactura()
    {
        if (cantidad < 0)
        {
            cantidad = 0;
        }
        if (precio < 0)
        {
            precio = 0;
        }
        return this.cantidad * this.precio;
    }

    static void Main()
    {
        Factura factura1 = new Factura("NA21", "Silla", 45, -100000);
        Console.WriteLine("El valor a pagar es de: " + factura1.obtenerMontoFactura());
    }
}
/*Cree una clase llamada Factura, que una ferretería podría utilizar para
representar una factura por un artículo vendido en la tienda. Una factura debe incluir
cuatro piezas de información como miembros de datos: un número de pieza (string)
la descripción de la pieza (string), la cantidad
de artículos de ese tipo que se van a comprar (int) y el precio por artículo (int).
a. Su clase debe tener un método constructor que inicialice a los cuatro
miembros de datos.
b. Proporcione una función establecer y una función obtener para cada
miembro de datos.
c. Proporcione una función miembro llamada obtenerMontoFactura que calcule
el monto de la factura (es decir, que multiplique la cantidad por el precio del
articulo) y después devuelva ese monto como un valor int.
d. Si la cantidad no es positiva, debe establecerse en 0. 
Si el precio por artículo
no es positivo, debe establecerse en 0.
e. Escriba un programa de prueba que demuestra las capacidades de la clase
Factura.*/