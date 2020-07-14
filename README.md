# Exemplo-Observer
Breve exemplo criado a partir do projeto utilizado no exemplo de builders para demonstrar o padrão Observer. Outros Patterns também serão utilizados.
Note que este exemplo além do observer implementa o padrão chain of responsability. Este último padrão, é implementado por meio da classe abstrata CheckoutObserverActionChain, que também implementa a interface CheckoutObserver. 
Esta implementação parece um tanto quanto confusa mas permite que classes exclusivamente observadoras e prontas para gerar uma cadeia sejam criadas, e que classes previamente existentes, como DAOs, também possam ter ações em cadeia executadas a partir de uma lista de classes que implementam a interface do observer.
Não estou certo de que é uma boa prática manter os dois padrões, mas do jeito que estão construídos, ambos podem ser utilizados separadamente, e classe abstrata do chain of responsability pode cuidar agregação da lista.
