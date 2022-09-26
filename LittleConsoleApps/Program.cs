// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int v1 = 0;
int v2 = 1;

//Mostramos el primer número el 0.
Console.WriteLine(v1);

//En este caso generamos 30 sucesiones del código Fibonacci.
for (int i = 0; i < 30; i++)
{
    //Almacenamos el valor v1 en una variable temporal para no perderlo.
    int temp = v1;

    //El valor 1 se convierte en el valor 2.
    v1 = v2;

    //Sumamos los valores.
    v2 = temp + v1;

    //Mostramos por pantalla el resultado. 
    Console.WriteLine(v1);
}

