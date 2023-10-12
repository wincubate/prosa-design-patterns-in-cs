using System.Collections;

int[] numbers = { 42, 47, 112, 176, 209 };

IEnumerator enumerator = numbers.GetEnumerator();
enumerator.Reset();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}
