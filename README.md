<div align="center">

### Repositório para versionamento do código de gerenciamento de biblioteca, feito na cadeira de Laboratório de Programação para explorar os princípios da Programação Orientada a Objetos.
<img height="40px" src="https://cdn-icons-png.flaticon.com/128/6132/6132221.png">

---
### <center>Os 4 pilares da POO utilizados:</center>

* <div id="abstracao"><strong>Abstração:</strong> conceito de simplificar um objeto, extraindo somente as informações que são relevantes para a execução da aplicação. </div>
* <div id="encapsulamento"><strong>Encapsulamento:</strong> conceito de proteger os dados de acesso de terceiros, podendo acessá-los somente com métodos "get & set", usados respectivamente para coletar uma dado protegido e alterar um dado protegido. </div>
* <div id="heranca"><strong>Herança:</strong> conceito onde uma classe herda e usa os atributos e métodos de uma classe base, neste caso a classe Livro herda da classe ItemBiblioteca seus atributos:Id, Titulo, DescricaoInterna. </div>
* <div id="polimorfismo"><strong>Polimorfismo:</strong> conceito de dar várias formas para uma mesma coisa, no caso deste projeto, a sobrecarga de métodos é um polimorfismo, pois cada método age de uma forma diferente, mesmo possuindo o mesmo nome. </div>
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
Como última classe, foi criada a _Biblioteca_, com as especificações:
* Gerencia uma coleção de ItemBiblioteca.
* Métodos: _AdicionarItem_, _RemoverItem_.
* Métodos com sobrecarga: _BuscarItemPorTitulo_ e _BuscarItemPorId_.

 A coleção de ItemBiblioteca foi criada como List, e é inicializada no construtor.
<br>
Os métodos com sobrecarga possuem duas opções: não passando nenhum parâmetro e passando o parâmetro referente (int para o Id e string para Titulo).

Nesta classe foi usado o conceito de <a href="#polimorfismo" style="color:lightgray;"><u>polimorfismo</u></a>.

---
Por fim, na classe _Program_ foi inicializado o objeto da biblioteca e feito um loop para ser o menu, apresentando as opções de ação disponíveis e utilizando um switch para direcionar o código para a ação desejada. 