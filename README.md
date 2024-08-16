# ContactProject
Projeto teste de lista de contatos para estudo sobre a abordagem DDD

# Gerenciamento de Informações de Contatos
OBJETIVO: gerenciar informações de contatos (apenas com nome e um email). 

FUNÇÃO: consulta, exibição, criação e atualização de contatos (CRUD básico). 

OBS: Este projeto segue as diretrizes apresentadas no artigo [Utilizando o DDD com ASP.NET Core - Uma Visão Geral]
(https://www.macoratti.net/20/07/aspnc_ucddd1.htm) do Macoratti.

## Arquitetura do Projeto
A aplicação será construída com base em uma arquitetura genérica, dividida em quatro camadas principais: Apresentação, Aplicação, Domínio e Infraestrutura. Cada camada tem responsabilidades distintas, conforme descrito abaixo.

### 1. Apresentação
**Responsabilidade:** Gerenciar a interação com o usuário final.

- Nesta camada, podemos ter diferentes tipos de projetos, como:
  - Aplicação Web (MVC, Razor Pages, etc.)
  - Aplicação Mobile (React Native, Xamarin, etc.)
  - Web API (para fornecer serviços RESTful)
  - Aplicação Desktop (WPF, Windows Forms, etc.)

### 2. Aplicação
**Responsabilidade:** Comunicar-se com a camada de Domínio.

- Elementos principais:
  - **Classes de Serviços:** Gerenciam operações específicas da aplicação.
  - **Interfaces:** Definem contratos para a comunicação com a camada de Domínio.
  - **DTOs (Data Transfer Objects):** Objetos para transferir dados entre camadas.

### 3. Domínio
**Responsabilidade:** Representar o núcleo do negócio.

- Elementos principais:
  - **Entidades:** Representam os objetos de negócio (neste caso, o contato).
  - **Interfaces:** Definem contratos para serviços de domínio.
  - **Classes de Serviços:** Implementam a lógica de negócio.
  - **Validações:** Garantem a consistência das regras de negócio.

### 4. Infraestrutura
**Responsabilidade:** Suporte geral às demais camadas, com foco na persistência e comunicação entre as camadas.

- Elementos principais:
  - **Repositórios:** Gerenciam o acesso aos dados e a persistência.
  - **Persistência:** Configuração e gerenciamento do banco de dados.
  - **Mapeamentos:** Configuração de ORM (Entity Framework, Dapper, etc.) para mapear entidades para o banco de dados.