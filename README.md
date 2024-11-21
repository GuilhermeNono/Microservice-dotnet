# Microservice-dotnet

Este repositório contém uma implementação de exemplo de uma arquitetura de microsserviços usando o framework .NET, DotNet Aspire e Ocelot.

## Estrutura do Projeto

- **Services**: Contém os diferentes microsserviços, cada um com sua própria lógica de negócio.
- **Gateway**: Implementado com Ocelot, atua como um ponto de entrada único para os microsserviços.
- **Shared**: Contém código compartilhado entre os microsserviços, como modelos e utilitários.

## Tecnologias Utilizadas

- **.NET Framework**: Framework principal usado para construir os microsserviços.
- **DotNet Aspire**: Utilizado para facilitar a criação e configuração dos serviços.
- **Ocelot**: Usado como API Gateway para rotear as requisições entre os microsserviços.
