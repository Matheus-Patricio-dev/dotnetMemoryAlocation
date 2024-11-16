<h1 align="center">Alocação de Memória em .NET</h1>


O C# é uma linguagem gerenciada, o que significa que o gerenciamento de memória é abstraído para o desenvolvedor, em contraste com linguagens como C e C++, onde a alocação e desalocação de memória precisam ser feitas manualmente. O principal responsável por essa gestão automática no C# é o Garbage Collector (GC).

O que é o Garbage Collector?
O Garbage Collector é um sistema de gerenciamento de memória que automaticamente aloca e libera a memória usada por objetos no heap (área de memória usada para objetos dinâmicos) quando estes não são mais referenciados. Isso reduz a necessidade de o programador se preocupar com a alocação e liberação de memória, ajudando a evitar erros como vazamentos de memória ou referências inválidas.

O GC funciona em intervalos específicos, procurando objetos que não têm mais referências ativas em outras partes do programa e liberando o espaço de memória que estavam ocupando.

<h2 align="center">🎲Como a Memória é Alocada em C#?</h1>

Em C#, a memória pode ser alocada de duas maneiras principais: no *heap* ou na *stack*.

<h3>✨Alocação na Stack</h3>
A stack (pilha) é uma área de memória usada para armazenar variáveis locais e objetos de valor, como structs. A alocação na stack é extremamente rápida porque, ao contrário do heap, não há necessidade de buscar o espaço livre. Cada vez que uma nova função é chamada, a memória necessária para suas variáveis locais é automaticamente empurrada para a pilha. Quando a função termina, esse espaço é liberado.

Variáveis armazenadas na stack têm um ciclo de vida muito bem definido e não são gerenciadas pelo GC, o que as torna mais eficientes. No entanto, como a memória na stack é limitada, tipos grandes ou de longo prazo não podem ser armazenados aqui. Um exemplo de tipo que usa a stack é uma variável do tipo int ou uma struct.

<h3>✨Alocação no Heap</h3>
Já o heap é uma área de memória onde são armazenados objetos de referência, como instâncias de classes. A alocação no heap é mais lenta comparada à stack, porque o GC precisa procurar e alocar espaço livre para os objetos. A principal vantagem do heap é que ele pode armazenar grandes blocos de dados, como grandes arrays ou objetos complexos, sem a limitação de espaço que a stack impõe.

Ao contrário das variáveis na stack, objetos no heap precisam ser gerenciados pelo GC, que é responsável por liberar a memória quando o objeto não for mais acessado. Isso implica que, embora a memória seja alocada automaticamente, é importante estar atento a problemas de uso excessivo de memória ou de ciclos de referências que podem levar a vazamentos de memória.

