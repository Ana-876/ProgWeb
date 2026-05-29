
use Empresa

/********************** Exercícios *******************************************************/

/* Conectivos */

/*01) Usando os conectivos IN e NOT IN resolva as seguintes consultas:*/

/*02 Mostre a descrição e o preço dos produtos das categorias Bebidas e Confeitos*/

select Descr, Preco from Produtos where CodCategoria in 
	(select CodCategoria from Categorias where descr = 'Bebidas' or descr = 'Confeitos')

/*03 Mostre todos os dados dos pedidos dos clientes da Alemanha*/

select * from Pedidos where CodCli in (select CodCli from Clientes where Pais = 'Alemanha')

/*04 Exiba todos os produtos da categoria Condimentos*/

select * from Produtos where CodCategoria in (select CodCategoria from Categorias where descr = 'Condimentos')

/*05 Mostre a descrição de todos os produtos que NÃO são fornecidos por fornecedores dos EUA */

select Descr from Produtos where CodFor not in (select CodFor from Fornecedores where Pais = 'EUA')

/*06 Mostre a descrição de todos produtos que NÃO fizeram parte dos pedidos de março de 1997 */

select Descr from Produtos where Cod

/*07 Mostre os dados dos clientes que fizeram pedidos em junho de 1997*/

select * from Clientes where 

/*08 Mostre os dados dos produtos dos fornecedores do Reino Unido e da Alemanha*/

/*09 Mostre os dados dos pedidos que tinham produtos da categoria Condimentos*/

/*10 Mostre todos os dados dos pedidos dos clientes que não são da França e da Espanha*/
