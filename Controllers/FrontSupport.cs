using AdasPet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Controllers
{
    public static class FrontSupport
    {
        private static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D17;Initial Catalog=ADASPET;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        private static SqlCommand Cmd { get; set; } = new SqlCommand("", Connection);


        /// <summary>
        /// Category, Animal
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static List<Produto> Lista(string categoria, string animal)
        {

            //Selecionar 
            List<Produto> lista = new List<Produto>();
            string select = $"SELECT * from dbo.Produto WHERE TipoDeAnimal = '{animal}' and Categoria = '{categoria}'";
            Cmd.CommandText = select;
            Connection.Open();

            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto pr = new Produto()
                {
                    ID = Guid.Parse(dr[0].ToString()),
                    Nome = dr[1].ToString(),
                    Marca = dr[2].ToString(),
                    TipoDeAnimal = dr[3].ToString(),
                    Categoria = dr[4].ToString(),
                    Preco = Convert.ToDouble(dr[5]),
                    QtdEmEstoque = Convert.ToInt32(dr[6]),
                    PrecisaDeCarro = Convert.ToBoolean(dr[7]),
                    Descricao = dr[8].ToString()
                };
                lista.Add(pr);
            }
            dr.Close();
            Connection.Close();
            return lista;
        }
    }
}
