var myFloat = 10f;
float meuFloat = 11;

// Conversão de tipo numérico

int myInteger = 100;
meuFloat = (float)myInteger;

decimal myDecimal = Convert.ToDecimal(myInteger);

var MyDouble = 10d;
myDecimal = 10m;

string meuNumero = Convert.ToString(myInteger);
int qtdChars = meuNumeroTexto.Lengh;
for(int i = 0; i < qtdChars; i++)
{
    Console.WriteLine(meuNumeroTexto[i]);
}