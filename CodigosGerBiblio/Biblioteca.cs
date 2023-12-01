public class Biblioteca
{
    public Biblioteca()
    {
        ColecaoDaBiblioteca = new List<ItemBiblioteca>();
    }

    public List<ItemBiblioteca> ColecaoDaBiblioteca { get; set; }

    public void AdicionarItem()
    {
        int id = ColecaoDaBiblioteca.Count() + 1;
        Console.WriteLine("Titulo do livro:");
        string titulo = Console.ReadLine();
        Console.WriteLine("Autor do livro:");
        string autor = Console.ReadLine();

        Livro livroAdicionado = new(id, titulo, autor);
        ColecaoDaBiblioteca.Add(livroAdicionado);
    } // ainda acho mais jogo fazer sobrecarga nos metodos adicionar e remover, nao nos outros

    public void RemoverItem()
    {
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            Console.WriteLine($"{item.Id} - {item.Titulo}");
        }
        Console.WriteLine();
        Console.WriteLine("Digite o Id do livro que deseja Remover da Biblioteca e pressione enter:");
        int idRemover = Convert.ToInt32(Console.ReadLine());
        ColecaoDaBiblioteca.RemoveAt(idRemover - 1);
        foreach (Livro item2 in ColecaoDaBiblioteca)
        {
            if (item2.Id > idRemover)
            {
                item2.Id--;
            }
        }
        Console.Write($"Livro selecionado removido com sucesso. Pressione enter para voltar ");
        Console.ReadLine();
    }

    public void BuscarItemPorTitulo() // metodo sobrecarregado
    {
        Console.WriteLine("Digite o titulo do livro que você procura:");
        string tituloProcurado = Console.ReadLine();
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (item.Titulo.Contains(tituloProcurado))
            {
                Console.WriteLine($"Id - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
            else
            {
                encontrado = false;
            }
        }
        if (encontrado == false)
        {
            Console.Write("Livro não encontrado. Pressione enter para voltar ");
            Console.ReadKey();
        }
    }
    public void BuscarItemPorTitulo(string titulo)
    {
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (item.Titulo.Contains(titulo))
            {
                Console.WriteLine($"Id - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
            else
            {
                encontrado = false;
            }
        }
        if (encontrado == false)
        {
            Console.Write("Livro não encontrado. Pressione enter para voltar ");
            Console.ReadKey();
        }
    }


    public void BuscarItemPorId() // metodo sobrecarregado
    {
        Console.WriteLine("Digite o id do livro que você procura:");
        int id = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (id == item.Id)
            {
                Console.WriteLine($"Id - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
            else
            {
                encontrado = false;
            }
        }
        if (encontrado == false)
        {
            Console.Write("Livro não encontrado. Pressione enter para voltar ");
            Console.ReadKey();
        }
    }
    public void BuscarItemPorId(int id)
    {
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (id == item.Id)
            {
                Console.WriteLine($"Id - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
            else
            {
                encontrado = false;
            }
        }
        if (encontrado == false)
        {
            Console.Write("Livro não encontrado. Pressione enter para voltar ");
            Console.ReadKey();
        }
    }
}