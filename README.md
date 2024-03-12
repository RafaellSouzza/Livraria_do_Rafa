## GRADUAÇÃO EM ENGENHARIA DE COMPUTAÇÃO

### Matéria: Desenvolvimento Back-End

#### Aluno: Rafael Soares de Souza

## Índice

- [ESTI – ESCOLA SUPERIOR DA TECNOLOGIA DA INFORMAÇÃO](#esti--escola-superior-da-tecnologia-da-informação)
   - [GRADUAÇÃO EM ENGENHARIA DE COMPUTAÇÃO](#graduação-em-engenharia-de-computação)
      - [Matéria: Desenvolvimento Back-End](#matéria-desenvolvimento-back-end)
         - [Professor: Rafael Soares de Souza](#professor-rafael-soares-de-souza)
   - [Índice](#índice)
   - [Introdução](#introdução)
   - [Funcionalidades](#funcionalidades)
   - [Arquitetura da Plataforma](#arquitetura-da-plataforma)
   - [Diagrama de Caso de Uso](#diagrama-de-caso-de-uso)
      - [Usuário](#usuário)
      - [Administrador](#administrador)
   - [Entidades Identificadas](#entidades-identificadas)
   - [Diagrama de Classes](#diagrama-de-classes)
   - [Diagrama de Estados](#diagrama-de-estados)
   - [Diagrama de Atividades](#diagrama-de-atividades)

## Introdução

A Livraria App é uma plataforma online inovadora destinada a apaixonados por livros. Com uma interface amigável e uma gama de funcionalidades intuitivas, a Livraria App permite aos usuários explorar, gerenciar e atualizar uma vasta coleção de títulos literários.

## Funcionalidades

- Lista de Livros: Os usuários podem navegar por uma lista completa de livros disponíveis na Livraria App. A seleção pode ser refinada por gênero para uma experiência personalizada de busca.

- Detalhes do Livro: Cada livro vem acompanhado de detalhes essenciais como nome, preço, capa e informações adicionais, permitindo que o usuário conheça profundamente cada obra antes de tomar uma decisão de compra ou leitura.

- Adicionar Livro: A plataforma oferece a opção de enriquecer a biblioteca adicionando novos títulos. Os usuários podem inserir informações como gênero, nome, preço, capa e detalhes para manter a coleção atualizada e diversificada.

- Remover Livro: Caso seja necessário, livros podem ser facilmente removidos da lista. A interface permite selecionar o título desejado para remoção de maneira simples e rápida.

- Atualizar Livro: A Livraria App compreende a dinâmica do mundo literário e oferece a possibilidade de atualizar as informações dos livros sempre que necessário, garantindo que a base de dados esteja sempre correta e atual.

## Arquitetura da Plataforma

A Livraria App foi desenvolvida com uma arquitetura modular que facilita a navegação e a gestão de conteúdo. O diagrama a seguir ilustra o fluxo de interação entre as diversas funcionalidades da plataforma.
<img src="/assets/img/DiagramaFluxo.png">

## Diagrama de Caso de Uso

### Usuário

- Navegar pela Lista de Livros: O usuário pode explorar a lista completa de livros disponíveis, com a opção de refinar sua seleção por gênero.
- Visualizar Detalhes do Livro: Após escolher um livro, o usuário pode visualizar detalhes como nome, preço, capa e informações adicionais.
- Adicionar Livro: Permite ao usuário inserir um novo livro na lista, fornecendo detalhes como gênero, nome, preço, capa e outras informações relevantes.
- Remover Livro: O usuário pode selecionar e remover um livro da lista.
Atualizar Livro: Permite ao usuário modificar as informações de um livro já listado.


### Administrador

- Gerenciar Lista de Livros: O administrador tem controle sobre a lista de livros, provavelmente com capacidades adicionais além das dos usuários comuns.
- Atualizar Informações do Sistema: Responsável por manter o sistema atualizado, seja em relação ao conteúdo ou à infraestrutura técnica.
- Monitorar Atividades dos Usuários: O administrador pode acompanhar as ações dos usuários para manter a ordem e segurança do sistema.

<img src="/assets/img/DiagramaCasosUso.png">

## Entidades Identificadas

1. **Livro**
- **Descrição:** Representa os detalhes de um livro disponível na Livraria App.
- **Campos:**
- - ID do Livro: um identificador único para o livro.
- - Título: o nome do livro.
- - Autor: o(s) autor(es) do livro.
- - Gênero: a categoria ou gênero literário do livro.
- - Preço: o custo de compra do livro.
- - ISBN: número padrão internacional do livro.
- - Capa: uma imagem ou design da capa do livro.
- - Descrição: uma sinopse ou informações adicionais sobre o livro.
- **Relacionamento:**
- - Está associado a zero ou mais pedidos (através de Itens de Pedido).
- - Pode ser adicionado, removido ou atualizado pelo Usuário ou Administrador.


2. **Usuário**
- **Descrição:** Alguém que usa o Livraria App para explorar e interagir com a lista de livros.
- **Campos:**
- -  ID do Usuário: um identificador único para o usuário.
- -  Nome: o nome completo do usuário.
- -  Email: o endereço de e-mail do usuário para contato.
- -  Senha: uma senha para a conta do usuário.
- **Relacionamento:**
- -  Pode criar, atualizar ou remover um Livro (se tiver permissões).
- -  Pode realizar um Pedido.

3. **Pedido**
- **Descrição:** Registra a aquisição de um ou mais livros por um usuário.
- **Campos:**
- -  ID do Pedido: um identificador único para o pedido.
- -  Data do Pedido: a data e hora em que o pedido foi realizado.
- -  Status: o estado atual do pedido (por exemplo, pendente, pago, enviado).
- -  Usuário ID: o identificador do usuário que realizou o pedido.
- **Relacionamento:**
- -  Associa um ou mais livros ao usuário que fez o pedido (através de Itens de Pedido).
- -  Um usuário pode ter vários Pedidos.

4. **Item de Pedido**
- **Descrição:** Associa um livro específico a um pedido, possibilitando a compra de múltiplos livros em um único pedido.
- **Campos:**
- -  ID do Item de Pedido: um identificador único para o item de pedido.
- Pedido ID: o identificador do pedido ao qual o item pertence.
- -  Livro ID: o identificador do livro que está sendo comprado.
- -  Quantidade: a quantidade do livro pedido.
- - Preço Unitário: o preço de cada livro no momento do pedido.
- **Relacionamento:**
- -  Associa um Livro a um Pedido.
- -  Um Pedido pode ter vários Itens de Pedido.

5. **Administrador**
- **Descrição:** Um tipo especial de usuário com permissões avançadas para gerenciar a Livraria App.
- **Campos:**
- -  ID do Administrador: um identificador único para o administrador.
- -  Nome de Usuário: o nome de usuário para o administrador logar no sistema.
- -  Senha: uma senha para a conta do administrador.
- **Relacionamento:**
- -  Tem as permissões para realizar qualquer ação sobre os Livros e Pedidos.
- -  Pode monitorar as atividades dos Usuários.


# Diagrama de Classes

## Livro
Detalha os atributos de um livro, como ID, título, autor, gênero, preço, ISBN, capa e descrição. Está associado a zero ou mais pedidos através de itens de pedido e pode ser modificado por usuários ou administradores.

## Usuário
Representa um usuário da plataforma, com campos como ID, nome, email e senha. Pode criar, atualizar ou remover um livro (se tiver permissões) e realizar pedidos.

## Pedido
Registra os pedidos feitos pelos usuários, incluindo ID do pedido, data, status e ID do usuário. Associa um ou mais livros ao usuário que fez o pedido através de itens de pedido.

## Item de Pedido
Associa livros a pedidos específicos, com campos como ID do item, ID do pedido, ID do livro, quantidade e preço unitário. Cada pedido pode ter vários itens de pedido.

## Administrador
Um tipo especial de usuário com permissões avançadas, incluindo ID, nome de usuário e senha. Tem permissões para realizar qualquer ação sobre os livros e pedidos e pode monitorar as atividades dos usuários.

<img src="/assets/img/DiagramaClasses.png">



# Diagrama de Estados

## Estado do Livro
- O livro começa no estado **"Disponível"**.
- Pode ser **"Adicionado"** à lista.
- Uma vez adicionado, pode ser **"Atualizado"** ou **"Removido"**, retornando ao estado **"Disponível"**.

## Estado do Pedido
- O pedido é **"Criado"** inicialmente.
- Passa para o estado **"Pendente"** após a realização.
- Muda para **"Pago"** após o pagamento.
- Finalmente, torna-se **"Enviado"**, concluindo o ciclo do pedido.

## Estado do Administrador
- O administrador inicia no estado **"Ativo"**.
- Entra no estado **"Gerenciando"** ao gerenciar livros ou pedidos.
- Retorna ao estado **"Ativo"** após concluir o gerenciamento.

<img src="/assets/img/DiagramaEstado.png">


# **Diagrama de Atividades**

## Lista de Livros

Este processo permite ao usuário visualizar todos os livros disponíveis. A partir daqui, o usuário pode realizar duas ações:

### Seleção por Gênero
Filtra a lista de livros de acordo com o gênero desejado.

### Detalhes do Livro
Fornece informações mais específicas sobre um livro selecionado, como nome, preço, capa, entre outros detalhes.

## Adicionar Livro
Esta função possibilita ao usuário inserir um novo livro no sistema, preenchendo as informações necessárias como gênero, nome, preço, capa e outros detalhes relevantes.

## Remover Livro
Permite ao usuário selecionar um livro existente e removê-lo da lista de livros disponíveis.

## Atualizar Livro
Oferece a opção de modificar as informações de um livro já listado.

<img src="/assets/img/DiagramaAtividadeFuncionalidade.png">

## Lista de Livros

### Selecionar Livro
A partir da lista, o usuário seleciona um livro específico para obter mais informações.

### Visualizar Detalhes do Livro
Esta etapa se ramifica em quatro opções distintas, onde o usuário pode visualizar diferentes tipos de informações sobre o livro escolhido:

### Informações Básicas
Detalhes fundamentais do livro, como título, autor e sinopse.

### Preço
O custo do livro.

### Capa
Uma imagem ou representação gráfica da capa do livro.

### Informações Adicionais
Outros dados relevantes que não se enquadram nas categorias anteriores, possivelmente incluindo comentários, avaliações, ano de publicação, etc.

<img src="/assets/img/DiagramaAtividadeDetalhes.png">


