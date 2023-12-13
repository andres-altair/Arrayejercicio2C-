namespace Arrayejercicio2C
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            char[] fvocales = { 'a', 'c', 'i', 'a', 'a' };
             
             for (int i = 0; i < vocales.Length; i++)
             {
                 for (int j = 0; j < fvocales.Length; j++)
                 {
                    if (vocales[i] != fvocales[j])
                    {
                       a = false;
                       break;
                    }     
                 }
                 if (a) 
                 {
                    Console.WriteLine(i + " " + vocales[i]);
                 }
             }
        }
    }
}
