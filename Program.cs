string sair = "tchau";
string pergunta;


Console.WriteLine
    ("--- ChatBot Groot ---");
Console.WriteLine
    ("Digite tchau quando quiser sair\n");

do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;
    Console.WriteLine("            Resposta: Eu sou Groot.");

    if(pergunta == sair)
    {
        Console.WriteLine("Eu sou o Groot!");
    }
}
while(pergunta != sair);