# 👩‍💻 Desafio Backend OliSaúde
Projeto onde o objetivo é criar uma API com métodos 
de requisição de criar, listar, editar e obter clientes 
especificos.Com a criação de um endpoint para trazer 
os 10 clientes com maior risco de saúde baseado no cálculo 
abaixo
```  
 sd = soma do grau dos problemas
 score = (1 / (1 + eˆ-(-2.8 + sd ))) * 100
```  
# 📋 Pré-requisitos
<table>
  <tr>
    <th>Tipo</th>
    <th>Componente</th>
    <th>Download em</th>
       <th>Observação</th>
  </tr>
  <tr>
    <th>SDK</th>
    <td>.Net 7</td>
    <td><a href="https://download.visualstudio.microsoft.com/download/pr/a099e4b6-a6a8-4d34-bf95-b00739d35bb7/cdad50779717ba0e56caf89a3ba29ab1/dotnet-sdk-7.0.403-win-x64.exe">Download</a></td>
    <td>Necessário para compilar o projeto local</td>
  </tr>
  <tr>
    <th>Software</th>
    <td>Docker</td>
    <td><a href="https://www.docker.com/">Documentação</a></td>  
    <td>Necessário para compilar o projeto local</td>
  </tr>
</table>

# 🛠️ Construído com

* [ASP.NET Web API](https://dotnet.microsoft.com/pt-br/download/dotnet/7.0) - Framework utilizado para criação de API
* [Nuget](https://www.nuget.org/) - Gerente de Dependências
* [Docker](https://www.docker.com/products/docker-desktop/) - Software utilizado para gerenciamento de containers.


# 📦 Pacotes da Aplicação
<table>
  <tr>
       <th>Tipo</th>
       <th>Componente</th>
       <th>Versão</th>
       <th>Download em</th>
       <th>Observação</th>
  </tr>
  <tr>
        <th>package</th>
        <td>Entity Framework Core</td>
        <td>7.1</td>
        <td>
            <a href="https://download.visualstudio.microsoft.com/download/pr/a099e4b6-a6a8-4d34-bf95-b00739d35bb7/cdad50779717ba0e56caf89a3ba29ab1/dotnet-sdk-7.0.403-win-x64.exe">Tools</a><br>
            <a href="https://download.visualstudio.microsoft.com/download/pr/a099e4b6-a6a8-4d34-bf95-b00739d35bb7/cdad50779717ba0e56caf89a3ba29ab1/dotnet-sdk-7.0.403-win-x64.exe">Tools</a><br>
        </td>
        <td>ORM para gerencimaneto  de dados</td>
  </tr>

</table>

# 📁 Estrutura do Projeto
```  
📁 OliSaude.Domain
  ├── 📁 Entities
  ├── 📁 Interfaces
📁 OliSaude.Application
  ├── 📁 Pages
📁 OliSaude.Infra.CrossCutting
  ├── 
📁 OliSaude.Infra.Data
  ├── 📁 Context
  ├── 📁 Mapping
  ├── 📁 Repository
📁 OliSaude.Service
  ├── 📁 Services
  ├── 📁 Validators

```
# 🔧 Instalação
 
 
