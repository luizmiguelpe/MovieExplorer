# 🎬 MovieExplorer - Consulta de Filmes em C#

O **MovieExplorer** é uma aplicação desktop desenvolvida em C# que permite aos utilizadores pesquisar informações detalhadas sobre filmes em tempo real, utilizando dados de uma API externa.

## 🚀 Funcionalidades
* **Pesquisa Dinâmica:** Busca de filmes por título.
* **Integração com API:** Consumo da API **OMDb** (Open Movie Database).
* **Detalhes Completos:** Exibição de poster, ano de lançamento, género e sinopse.
* **Interface Intuitiva:** Criada com Windows Forms (WinForms).

## 🛠️ Tecnologias Utilizadas
* **Linguagem:** C#
* **Framework:** .NET 
* **Comunicação:** HttpClient para requisições REST.
* **Formato de Dados:** JSON (desserialização com Newtonsoft.Json).

## 📝 Como funciona
A aplicação envia um pedido assíncrono para o endpoint da OMDb, recebe os dados do filme em formato JSON e mapeia-os para a classe `OmdbResponse.cs` (que podes ver aqui no repositório), atualizando a interface gráfica automaticamente.

---
*Projeto desenvolvido durante o curso de Técnico Especialista em Tecnologias e Programação de Sistemas de Informação - ATEC.*
