public abstract class ItemBiblioteca // conceito de abstração
{
    public ItemBiblioteca(int id, string titulo)
    {
        this.Id = id;
        this.Titulo = titulo;
        this.DescricaoInterna = "Descrição ainda não alterada (valor padrão)";
    }

    public int Id { get; set; } // conceitos de encapsulamento
    public string Titulo { get; set; }
    protected string DescricaoInterna { get; set; }
}