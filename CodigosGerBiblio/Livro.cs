public class Livro : ItemBiblioteca // conceito de herança
{
    public Livro(int id, string titulo, string autor) : base (id, titulo)
    {
        this.Autor = autor;
        Console.WriteLine("Digite uma descrição interna para o livro:");
        this.DescricaoInterna = Console.ReadLine();
    }
    public string Autor { get; set; }
    
    public string ExibirDescricaoInterna()
    {
        return DescricaoInterna;
    }
}