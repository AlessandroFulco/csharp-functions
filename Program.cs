///*
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. 
//Potete prendere quella fatta in classe questa mattina

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.

//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] 
//già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale 
//non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati
//*/






//void StampaArrayInteri(int[] array)
//{
//    Console.Write("[");
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i]);
//        if (i != array.Length - 1)
//            Console.Write(", ");
//    }
//    Console.Write("]");
//}

//int Quadrato(int numero)
//{
//    return numero * numero;
//}

//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    int[] nuovoArray = new int[array.Length];
//    for (int i = 0; i < array.Length; i++)
//    {
//        nuovoArray[i] = Quadrato(array[i]);
//    }
//    StampaArrayInteri(nuovoArray);
//    return nuovoArray;
//}

//int SommaElementiArray(int[] array)
//{
//    int somma = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        somma += array[i];
//    }
//    return somma;
//}

////int[] array = { 2, 6, 7, 5, 3, 9 };

//Console.Write("Quanti numeri vuoi scrivere: ");
//int N = Convert.ToInt32(Console.ReadLine());

//int[] array = new int[N];

//for (int i = 0; i < N; i++)
//{
//    Console.Write("Inserisci numero: ");
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}



////stampa dell'array
//StampaArrayInteri(array);
//Console.WriteLine();

////stampa dell'array al quadrato
//int[] arrayQuadrato = ElevaArrayAlQuadrato(array);
//Console.WriteLine();

////stampa dell'array
//StampaArrayInteri(array);
//Console.WriteLine();

////somma degli elementi dell'array
//Console.WriteLine("la somma di tutti i numeri dell'array è: " + SommaElementiArray(array));
////somma elementi array al quadrato
//Console.WriteLine("la somma di tutti i numeri dell'array è: " + SommaElementiArray(arrayQuadrato));



//// Calcolo del fattoriale di un numero


////v1

//Console.Write("Calcola il fattoriale di un numero, inserisci il numero: ");
//int N = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Fattoriale(N));


//int Fattoriale(int numero)
//{
//    int result = 0;
//    int moltiplicazione = numero;

//    int iterazioni = numero;

//    for(int i = iterazioni; i > 1;)
//    {
//        i--;
//        moltiplicazione = moltiplicazione * i;
//        result = moltiplicazione;
//    }

//    return result;
//}




// Calcola la sequenza di fibonacci
//v1

Console.WriteLine(Fibonacci(10));

int Fibonacci(int numero)
{
    int result = 0;

    int somma1 = 0;
    int somma2 = 0;
   
    if (numero == 0)
    {
        Console.WriteLine(0);
    } 
    else if( numero == 1 ) 
    {
        Console.WriteLine(1);
    } else
    {
        int appoggio = 0;
        int inizio = 0;
        int inizio2 = 1;
        for (int i = 1; i < numero; i++)
        {
            appoggio = inizio + inizio2;
            result = appoggio;

            inizio = inizio2;
            inizio2 = result;
            appoggio = 0;
        }
    }


    return result;
}

