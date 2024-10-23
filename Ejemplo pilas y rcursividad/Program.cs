Console.WriteLine(EsBalanceado(Console.ReadLine(), new Stack<char>()) ? "Balanceado" : "No balanceado");

bool EsBalanceado(string secuencia, Stack<char> pila, int indice = 0)
{
    if (indice == secuencia.Length) return pila.Count == 0;

    char caracter = secuencia[indice];
    if (caracter == '(' || caracter == '{' || caracter == '[') pila.Push(caracter);
    else if (caracter == ')' && (pila.Count == 0 || pila.Pop() != '(') ||
             caracter == '}' && (pila.Count == 0 || pila.Pop() != '{') ||
             caracter == ']' && (pila.Count == 0 || pila.Pop() != '['))
        return false;

    return EsBalanceado(secuencia, pila, indice + 1);
}