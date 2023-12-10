using System.IO.Compression;

Console.WriteLine("--- Quadrante Cartesiano ---");

Console.WriteLine("Entre com o ponto desejado.");

Console.Write("Coordenada x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Coordenada y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) {
  Console.WriteLine($"O ponto ({x}, {y}) fica na origem.");
} else if (x == 0 || y == 0) {
  Console.WriteLine($"O ponto ({x}, {y}) fica no eixo das ordenadas.");
} else if (x > 0 && y > 0) {
  Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 1.");
} else if (x < 0 && y > 0) {
  Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 2.");
} else if (x < 0 && y < 0) {
  Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 3.");
} else if (x > 0 && y < 0) {
  Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 4.");
}