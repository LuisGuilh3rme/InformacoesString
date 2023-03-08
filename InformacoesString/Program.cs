using System.Globalization;
using System.Reflection;

Console.WriteLine("Informe o texto:");
string texto = Console.ReadLine();

// Quantidade de caracteres:
int quantCaracter = texto.Length;
Console.WriteLine("[{0}] tem {1} caractere(s)", texto, quantCaracter);

// Quantidade de vogais:
char[] vogais = {'a', 'e', 'i', 'o', 'u'};
int quantVogais = EncontrarQuantidade(texto, vogais);
Console.WriteLine("[{0}] tem {1} vogais)", texto, quantVogais);

// Quantidade de consoantes:
char[] consoantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
int quantConsoantes = EncontrarQuantidade(texto, consoantes);
Console.WriteLine("[{0}] tem {1} consoante(s)", texto, quantConsoantes);

int EncontrarQuantidade (string texto, char[] analises)
{
    string textoFinal = "";
	for (int i = 0; i < analises.Length; i++)
	{
		for (int j = 0; j < texto.Length ; j++)
		{
			if (texto[j] == analises[i])
			{
				textoFinal += texto[j];
			}
		}
	}
    return textoFinal.Length;
}

// Alternar letras, entre maiusculas e minusculas:
string textoAlternado = AlternarLetras(texto);
Console.WriteLine("Texto com alternância: {0}", textoAlternado);
string AlternarLetras (string texto)
{
	string textoFinal = "";
	int alternancia = 0;
	for (int i = 0; i < texto.Length; i++)
	{
		string caracterAtual = texto[i].ToString();
		if (alternancia == 0)
		{
			textoFinal += caracterAtual.ToUpper();
			alternancia = 1;
		}
		else
		{
			textoFinal += caracterAtual.ToLower();
			alternancia = 0;
		}
	}
	return textoFinal;
}

// String espelhada:
string textoInvertido = InverterTexto(texto);
Console.WriteLine("[{0}] invertido é {1}", texto, textoInvertido);

string InverterTexto(string texto)
{
	string textoFinal = "";
	for (int i = (texto.Length - 1); i >= 0; i--)
	{
		textoFinal += texto[i];
	}
	return textoFinal;
}