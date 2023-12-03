Biblioteca b1 = new();

while (true)
{
    Console.Clear();
    Console.WriteLine("Digite a opção que deseja executar:");
    Console.WriteLine("1 - Adicionar livro na biblioteca");
    Console.WriteLine("2 - Buscar livro por Id");
    Console.WriteLine("3 - Buscar livro por Titulo");
    Console.WriteLine("4 - Remover livro");
    Console.WriteLine("5 - Fechar aplicação");
    Console.Write("\n opção: ");

    int opcao = Convert.ToInt32(Console.ReadLine());
    while (opcao < 1 || opcao > 5)
    {
        Console.Write("Opção inválida, escolha entre 1 a 5: ");
        opcao = Convert.ToInt32(Console.ReadLine());
    }

    switch (opcao)
    {
        case 1: b1.AdicionarItem(); break;
        case 2: b1.BuscarItemPorId(); break;
        case 3: b1.BuscarItemPorTitulo(); break;
        case 4: b1.RemoverItem(); break;
        case 5: System.Environment.Exit(0); break;
    }
}