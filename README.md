# Previsão do Tempo

Exercício de desenvolvimento de frontend + backend para exibição da previsão do tempo.

Sendo:
* 3 cidades mais quentes no dia
* 3 cidades mais frias no dia
* Opção para selecionar uma cidade e exibir a previsão para os próximos 7 dias

## Ferramentas
  
Foram usados o [**Visual Studio Community**](https://visualstudio.microsoft.com/pt-br/vs/older-downloads/) e [**SQL Server Express**](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

Os arquivos para a estrutura da base de dados estão na pasta "extras".

## Detalhes do backend

.NetFramework 4.6.1

Microsoft.AspNet.Mvc 5.2.7

Entity Framework 

SQL Server 


## Detalhes do frontend

Bootstrap

JQuery

Select2 + Ajax - para load da previsão dos próximos 7 dias da cidade selecionada

## Execução

* Criar base de dados e tabelas conforme estrutura em arquivos contidos na pasta "extras"
* Inserir registros (aleatórios e manualmente) nas tabelas (respeitando as restrições de chaves estrangeiras e primárias)
* Abrir o projeto no Visual Studio
* Rodar o projeto clicando em Depuração > Iniciar sem depurar (Ctrl + F5). O sistema deverá apresentar uma tela como a "captura.png" que se encontra na pasta "extras", [**conforme exemplo**](https://github.com/marciopuntel/previsao-tempo/blob/main/extras/Captura.PNG)  
