<div align="center">

### Repositório para versionamento do código de gerenciamento de biblioteca, feito na cadeira de Laboratório de Programação para explorar os princípios da Programação Orientada a Objetos.
<img height="40px" src="https://cdn-icons-png.flaticon.com/128/6132/6132221.png">

---
### <center>Os 4 pilares da POO</center>

* <div id="abstracao"><strong>Abstração:</strong> conceito de simplificar um objeto, extraindo somente as informações que são relevantes para a execução da aplicação. </div>
* <div id="encapsulamento"><strong>Encapsulamento:</strong> conceito de proteger os dados de acesso de terceiros, podendo acessá-los somente com métodos "get & set", usados respectivamente para coletar uma dado protegido e alterar um dado protegido. </div>
* <div id="heranca"><strong>Herança:</strong> conceito onde uma classe herda e usa os atributos e métodos de uma classe base, neste caso a classe Livro herda da classe ItemBiblioteca seus atributos:Id, Titulo, DescricaoInterna. </div>
</div>
---















Comecei o projeto criando a classe _ItemBiblioteca_, seguindo as seguintes especificações técnicas:
* Deve ser uma classe abstrata.
* Propriedades: _Id_ (int), _Titulo_ (string).
* Propriedade protegida: _DescricaoInterna_ (string).
* Construtor que inicializa _Id_, _Titulo_ e define um valor padrão para _DescricaoInterna_. 

Com ela, apliquei os conceitos de <a href="#abstracao" style="color:lightgray;"><u>abstração</u></a> e <a href="#encapsulamento" style="color:lightgray;"><u>encapsulamento</u></a>.

---
Após, foi criada a classe _Livro_, seguindo as especificações:
* Deve herdar de _ItemBiblioteca_.
* Propriedade adicional: _Autor_ (string).
* Construtor que recebe id, título e autor, e inicializa a _DescricaoInterna_ (o qual interpretei como escrever uma descrição para o livro com ReadLine).
* Método _ExibirDescricaoInterna_ para imprimir a _DescricaoInterna_.

Nesta criação foi usado o conceito de <a href="#heranca" style="color:lightgray;"><u>herança</u></a>.

---
Criada a classe _Biblioteca_, implementando uma lista de elementos ItemBiblioteca, que é inicializada no construtor. criados os métodos _AdicionarItem_ e _RemoverItem_, ambos sem sobrecargas, e os métodos _BuscarItemPorTitulo_ e _BuscarItemPorId_, ambos sobrecarregados (metodo sem parametro e metodo com parametro). para os metodos
