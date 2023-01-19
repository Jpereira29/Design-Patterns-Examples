# Design-Patterns-Examples

## Padrões de Projetos Criacionais
<h3>Lidam com mecanismos de criação de objetos, ou seja, ele tenta criar objetos de uma maneira que seja adequada a uma determinada situação ocultando detalhes da sua implementação</h3>

<h2>Factory</h2>
<p>No padrão Factory, criamos um objeto sem expor a lógica de criação ao cliente e o cliente fará referência ao objeto recém-criado usando uma interface comum.</p>

<h3>Simple Factory</h3>
<ol>
  <li>Cria objetos sem expor a lógica de instanciação ao cliente</li>
  <li>Refere-se ao objeto recém-criado por meio de uma interface comum</li>
</ol>

<h3><a href="https://github.com/Jpereira29/Design-Patterns-Examples/tree/main/Simple%20Factory">Exemplo</a></h3>

<h3>Factory Method</h3>
<ol>
  <li>Definir uma interface para criar objetos, mas permitir que as subclasses decidam qual classe instanciar</li>
  <li>O Factory Method permite que uma classe adie a instanciação que ela usa para as subclasses</li>
  <li>O padrão Factory Method usa herança e depende de uma subclasse para lidar com a instanciação do objeto desejado</li>
</ol>

<h3><a href="https://github.com/Jpereira29/Design-Patterns-Examples/tree/main/Factory%20Method">Exemplo</a></h3>
