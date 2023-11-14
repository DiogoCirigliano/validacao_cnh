Classe para validar CNH


A carteira de motorista é composta por 11 dígitos, onde os 2 últimos dígitos são chamados de dígitos verificadores. Os 9 primeiros dígitos são dígitos entre 0 e 9.

Você vai pegar os 9 primeiros dígitos da sua habilitação e multiplicar cada dígito por 2, 3, 4, 5, 6, 7, 8, 9, 10. No exemplo abaixo, usamos de exemplo os 9 primeiros dígitos da CNH como 1, 2, 3, 4, 5, 6, 7, 8, 9.

1	2	3	4	5	6	7	8	9
2	3	4	5	6	7	8	9	10

Depois de multiplicar todas as colunas de nosso exemplo e somar cada uma, obtemos o valor: 330. Agora devemos fazer a divisão por 11 e guardar o resto da divisão. Em nosso exemplo, o valor seria: 0. Agora pegue o valor 11 e subtraia de 0, se este resultado for maior que 9, nosso primeiro dígito deve ser 0, caso contrário, nosso primeiro dígito será o valor encontrado anteriormente, guarde este valor. Em nosso exemplo, nosso primeiro dígito verificador será 0.

Agora o que você precisa fazer é multiplicar todos os 9 primeiros dígitos por 3, 4, 5, 6, 7, 8, 9, 10, 11. Ficando assim:

1	2	3	4	5	6	7	8	9
3	4	5	6	7	8	9	10	11

Depois de multiplicar todas as colunas de nosso exemplo e somar cada um, obtemos o valor: 375. Agora devemos multiplicar nosso primeiro dígito verificador por 2 e acrescentar a soma total, em nosso caso que é 0, nada muda. Depois de realizar essa soma, devemos obter o valor do resto da divisão por 11. Se esse valor for maior que 9 e esse valor subtraído de 2 for menor que 0, devemos somar 9 ao valor encontrado do resto da divisão. Agora se o valor for maior que 9 e esse valor subtraído de 2 for maior ou igual a 0, devemos subtrair 2 do valor encontrado do resto da divisão. Para finalizar e encontrar nosso segundo dígito verificador de nossa habilitação, precisamos fazer mais 2 operações:

Iremos subtrair 11 menos o valor que encontramos do resto da divisão das operações anteriores. Se esse valor for maior que 9, nosso segundo dígíto verificador será 0, caso contrário, será o resultado da operação de subtração que acabamos de realizar. Para o nosso exemplo, nosso segundo dígito verificador será igual a 0, obtendo a CNH: 12345678900.
