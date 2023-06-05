# testePEAK
Testes para a vaga de Dev Full Stack Jr - Peak Invest

Montar uma aplicação básica com duas camadas: front-end em angular e o back-end deve ser uma API em ASP.NET C#.

Tela de Cadastro
Desenvolver uma Tela de Cadastro que tenha dois campos onde o usuário possa digitar o valor para parcelas (integer) e valor (decimal). 

Ao clicar em um botão Salvar, os dados devem ser enviados através de uma requisição POST para a API no back-end que deve realizar o seguinte cálculo: (valor * parcelas) + 5%. 

Após realizado o cálculo o resultado deve ser enviado novamente para o front-end que deve exibir o valor no formato currency (ex: R$ 99,999).

Tela de Consulta
Desenvolver uma Tela de Consulta onde seja possível digitar um número de 1 a 3 e ao clicar em buscar, o front-end faz uma requisição no formato GET para a API no back-end.

O back-end deve consultar por esse ID em uma lista KeyValuePair (ver exemplo) e retornar para o front-end o nome encontrado.

Exemplo de lista:
            var lista = new List<KeyValuePair<int, string>>();
            lista.Add(new KeyValuePair(1, "João"));
            lista.Add(new KeyValuePair(2, "Maria"));
            lista.Add(new KeyValuePair(3, "Ana"));

O importante é que a comunicação do front-end com o back-end seja feita de forma consistente. Publicar código no github.

  |- README.md