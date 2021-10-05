using AdasPet.Data;
using AdasPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdasPet.Controllers
{
    public class Select
    {
        // Precisamos ter uma prop de tipo ApplicationDbContext
        public ApplicationDbContext _context { get; set; }
        // Para acessar o banco de dados o constrtutor precisa ter como parametro "ApplicationDbContext context"
        public Select(ApplicationDbContext context)
        {
            // E atttribuir o context a nossa prop de tipo ApplicationDbContext
            _context = context;
        }

        // Retorna a lista de produtos com a categoria e o tipo de animal dado
        public List<Produto> ProdutosComCategoriaEAnimal(string Categoria, string Animal)
        {
            // Exemplo com comando SQL
            return _context.Produto.FromSqlRaw($"SELECT * FROM dbo.Produto WHERE Categoria = {Categoria} AND TipoDeAnimal = {Animal}").ToList();

        }
    }

    //private static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D17;Initial Catalog=ADASPET;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
    //private static SqlCommand Cmd { get; set; } = new SqlCommand("", Connection);

    //public List<Produto> Seleciona(string animal, string categoria)
    //{
    //    //Selecionar 
    //    List<Produto> lista = new List<Produto>();
    //    string select = $"SELECT * from dbo.Produto WHERE TipoDeAnimal = {animal} and {categoria}";
    //    Cmd.CommandText = select;
    //    Connection.Open();
    //    Cmd.ExecuteNonQuery();
    //    SqlDataReader dr = Cmd.ExecuteReader();
    //    while (dr.Read())
    //    {
    //        Produto pr = new Produto()
    //        {
    //            ID = Guid.Parse(dr[0].ToString()),
    //            Nome = dr[1].ToString(),
    //            Marca = dr[2].ToString(),
    //            TipoDeAnimal = dr[3].ToString(),
    //            Categoria = dr[4].ToString(),
    //            Preco = Convert.ToDouble(dr[5]),
    //            QtdEmEstoque = Convert.ToInt32(dr[6]),
    //            PrecisaDeCarro = Convert.ToBoolean(dr[7]),
    //            Descricao = dr[8].ToString()
    //        };
    //        lista.Add(pr);
    //    }
    //    dr.Close();
    //    Connection.Close();
    //    return lista;
    //}
}
