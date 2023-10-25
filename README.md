# Desafio Backend OliSaúde
Projeto onde o objetivo é criar uma API com métodos 
de requisição de criar, listar, editar e obter clientes 
especificos.Com a criação de um endpoint para trazer 
os 10 clientes com maior risco de saúde baseado no cálculo 
abaixo
```   sd = soma do grau dos problemas
    score = (1 / (1 + eˆ-(-2.8 + sd ))) * 100

📁 OliSaude.Domain
  ├── 📁 Entities
  ├── 📁 Interfaces
📁 OliSaude.Application
  ├── 📁 Interfaces
  ├── 📁 Interfaces
📁 OliSaude.Infra.CrossCutting
  ├── 📁 Entities
  ├── 📁 Interfaces
📁 OliSaude.Infra.Data
  ├── 📁 Entities
  ├── 📁 Interfaces
📁 OliSaude.Service
  ├── 📁 Entities
  ├── 📁 Interfaces

```
# 📋 Pré-requisitos

 
 
