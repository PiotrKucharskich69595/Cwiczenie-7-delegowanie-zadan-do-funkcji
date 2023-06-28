using System;

class Program
{
    static void Main()
    {
        int[] liczby = { 6, 2, 3, 7, 1, 4, 8, 9, 5 };
        int mediana = ObliczMediane(liczby);
        Console.WriteLine($"Mediana wynosi: {mediana}");
    }

    static int ObliczMediane(int[] tablica)
    {
        if (tablica.Length > 100)
        {
            throw new ArgumentException("Rozmiar tablicy przekracza maksymalną wartość 100.");
        }

        int n = tablica.Length;
        int[] posortowanaTablica = new int[n];
        Array.Copy(tablica, posortowanaTablica, n);

        Array.Sort(posortowanaTablica);

        int indeksSrodkowy = n / 2;
        if (n % 2 == 1)
        {
            return posortowanaTablica[indeksSrodkowy];
        }
        else
        {
            int poprzedniIndeks = indeksSrodkowy - 1;
            return (posortowanaTablica[poprzedniIndeks] + posortowanaTablica[indeksSrodkowy]) / 2;
        }
    }
}