using ConsoleApp4;
cola X = new cola();
X.enqueue("pera");
//X.enqueue("manzana");
//X.enqueue("sandia");
X.dequeue();

Console.WriteLine(X.ToString());
Console.WriteLine(X.front());
Console.WriteLine("la cantidad de datos en la cola es " + X.Size());
X.empty();
