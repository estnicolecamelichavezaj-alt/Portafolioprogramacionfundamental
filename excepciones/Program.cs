//PrimerEjemplo
try
{
    Console.WriteLine("Cantidad de productos");
    int cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("el doble es: " + cantidad * 2);

catch
{
    Console.WriteLine("Agarramos un error" +
        "");
}
finally
{
    Console.WriteLine("Aqui termino la prueba");
}