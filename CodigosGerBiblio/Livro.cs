public class Livro : ItemBiblioteca // conceito de herança
{
    public Livro(int id, string titulo, string autor) : base (id, titulo)
    {
        this.Autor = autor;
        Console.Write("Digite uma descrição interna para o livro ou pressione enter para manter o valor padrão:\n ");
        string descricao = Console.ReadLine();
        if (descricao == "")
        {
            this.DescricaoInterna = DescricaoInterna;
        }
        else
        {
            this.DescricaoInterna = descricao;
        }
    } // construtor que leva para o construtor base e declara autor e descrição interna para o livro
    public string Autor { get; set; }
    
    public string ExibirDescricaoInterna()
    {
        return DescricaoInterna;
    } // método que retorna a descrição interna, necessário visto que a descrição interna é um atributo protegido
}