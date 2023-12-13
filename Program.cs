namespace Arrayejercicio2C
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            char[] vocales = { 'a', 'c', 'i', 'o', 'u' };
            char[] fvocales = { 'a', 'e', 'i', 'a', 'a' };
             
             for (int i = 0; i < vocales.Length; i++)
             {
                 for (int j = 0; j < fvocales.Length; j++)
                 {
                    if (vocales[i] != fvocales[j])
                    {
                       a = true;
                       break;
                    }     
                 }
                 if (!a) 
                 {
                    Console.WriteLine(i + " " + vocales[i]);
                 }
             }
        }
    }
}
