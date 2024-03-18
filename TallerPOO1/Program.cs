class Cuenta
{
    public string nombre;
    public int saldo;
    public Cuenta(int saldoInicial)
    {
        if (saldoInicial >= 0)
        {
            saldo = saldoInicial;
        }
        else
        {
            saldo = 0;
            Console.WriteLine("Error: El saldo inicial es inválido. Se estableció el saldo en 0.");
        }
    }

    public void Credit(int monto)
    {
        saldo += monto;
    }

    public void cargar(int monto)
    {
        if (monto <= saldo)
        {
            saldo -= monto;
        }
        else
        {
            Console.WriteLine("El monto a cargar excede el saldo de la cuenta.");
        }
    }

    public void ObtenerSaldo()
    {
        Console.WriteLine("Su saldo es " + saldo);
    }
    static void Main()
    {
        Cuenta cuenta1 = new Cuenta(100);
        cuenta1.Credit(50);
        cuenta1.cargar(25);
        cuenta1.ObtenerSaldo();

        Cuenta cuenta2 = new Cuenta(250);
        cuenta2.Credit(75);
        cuenta2.cargar(400);
        cuenta2.ObtenerSaldo();
    }
}
/*1. Cree una clase llamada Cuenta que podría ser utilizada por un banco para
representar las cuentas bancarias de sus clientes. Incluya un miembro de datos de
tipo int para representar el saldo de la cuenta.
a. Proporcione un constructor que reciba un saldo inicial y lo utilice para inicializar
el miembro de dato. El constructor debe validar el saldo inicial para asegurar
que sea mayor o igual que 0. De no ser así, establezca el saldo en 0 y muestre
un mensaje de error, indicando que el saldo inicial era inválido.
b. Proporcione tres funciones miembros.
i. La función miembro credit debe agregar un monto al saldo actual.
ii. La función miembro cargar deberá retirar dinero el objeto Cuenta y
asegurarse que el monto a cargar no exceda el saldo de Cuenta. Si lo
hace, el saldo deberá permanecer sin cambio y la función deberá imprimir
un mensaje que indique “El monto a cargar excede el saldo de la cuenta”.
iii. La función miembro obtenerSaldo debe devolver el saldo actual.
c. Cree un programa que cree dos objetos Cuenta y evalué las funciones
miembros de la clase Cuenta.*/