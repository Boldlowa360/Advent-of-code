namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader doc = new StreamReader("C:\\Users\\blanc\\OneDrive\\Bureau\\AdventOfCode\\données.txt");

            int total = 0;
            while (!doc.EndOfStream)
            {
                String ligneLue = doc.ReadLine();
                String nombre = "";
                for(int i  =0; i < ligneLue.Length; i++)
                {
                    if (ligneLue[i] == '0')
                    {
                        nombre += '0';
                    }
                    if (ligneLue[i] == '1')
                    {
                        nombre += '1';
                    }
                    if (ligneLue[i] == '2')
                    {
                        nombre += '2';
                    }
                    if (ligneLue[i] == '3')
                    {
                        nombre += '3';
                    }
                    if (ligneLue[i] == '4')
                    {
                        nombre += '4';
                    }
                    if (ligneLue[i] == '5')
                    {
                        nombre += '5';
                    }
                    if (ligneLue[i] == '6')
                    {
                        nombre += '6';
                    }
                    if (ligneLue[i] == '7')
                    {
                        nombre += '7';
                    }
                    if (ligneLue[i] == '8')
                    {
                        nombre += '8';
                    }
                    if (ligneLue[i] == '9')
                    {
                        nombre += '9';
                    }
                }
                String bonNombre = "";
                bonNombre += nombre[0];
                bonNombre+= nombre[nombre.Length-1];
                    Console.WriteLine(bonNombre);
                total += int.Parse(bonNombre);
                
            }
            Console.WriteLine(total);
        }
    }
}