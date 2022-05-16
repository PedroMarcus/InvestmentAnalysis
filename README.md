# InvestmentAnalysis

Para executar o projeto: 
Necessário o angular 10; 
Necessário o .NET Core 3.1; 

Para executar o projeto .NET Core clique em Start dentro do visual Studio ou aperte "F5", será aberto uma página do Swagger com o endpoint de análise de investimento. 
Para executar o projeto Angular, rode o comando "ng serve", será aberto a página inicial da aplicação. 

Foi configurado o CORS na aplicação para liberar as requisições de outras aplicações dentro da API. 

O projeto .NET Core foi desenvolvido com o Clean Archtecture para tentar facilitar modificações futuras, podem se encontrados dentro do projeto algumas pastas como "Entities" que centralizam as entidades que fazem refeerência às tabelas do banco de dados, no caso deste projeto, ou fase do mesmo isso não se aplicou, por isso nãoa pasta nõ tem entidades, mas está presente para simbolizar a possibilidade e a ideia do projeto caso fosse para a frente. 

Temos as divisões de alguns projetos dentro da solução, cada projeto fica devidamente com a sua responsabilidade, o que é a ideia do clena archtecture. 

Realizei devido ao tempo o que foi possível para o projeto, mas ainda existem muitas melhorias a serem realizadas no memso. 
Foram realizados os testes unitários, mas poderiam ser realizados outros, por questão de tempo, poderia ter pensado em outros testes para aplicação.

DICA DE MELHORIA DO TESTE!
Além de colocar as fórmulas de cálculo, poderiam colocar um exemplo de valor esperado de acordo com um parâmetro passado. Pois é um tipo de cálculo bem sensível!
Exemplo: 

Dados de entrada: 
Valor Inicial: 10.
Periodo: 12 meses. 

Valor esperado: 200. 

Facilita a visualização da regra e da atividade, contundo ainda facilita a formação dos testes unitários e demais. Pois dessa forma, nós desenvolvedores possuímos valores paupáveis para realizar a análise e o teste da regra de negócio. 

