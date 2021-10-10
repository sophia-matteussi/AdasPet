using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdasPet.Areas.Loja.Pages.Carrinho
{
    public class CarrinhoOp
    {
        private static string CarrinhoKey = "_carrinho";
        // Exemplo de carrinho
        // "123,871263,1236785,456,2345"

        //private static string teste = "123,871263,1236785,456,2345";


        //AspNet se encarrega de reconhecer a que usuario a session pertence
        public static ISession AdicionarItem(ISession session, Guid ProdutoId) //Botao add ao carrinho deve chamar essa funcao,  session HttpContext.Session
        {
            string carrinho = session.GetString(CarrinhoKey); // "123,871263,1236785,456,2345"

            if ( ! String.IsNullOrEmpty(carrinho) )
            {
                carrinho += ",";
            }

            carrinho += ProdutoId.ToString();

            session.SetString(CarrinhoKey, carrinho);

            return session;

        }

        //Pega os conteudos do carrinho e retorna eles em uma lista
        public static List<Guid> GetCarrinho(ISession session)
        {
            string carrinho = session.GetString(CarrinhoKey);

            if (String.IsNullOrEmpty(carrinho))
            {
                return new List<Guid>();
            }

            var carrinhoStrings = carrinho.Split(',').ToList();

            List<Guid> ProdutoIds = new List<Guid>(); 


            foreach (string item in carrinhoStrings)
            {
                ProdutoIds.Add(new Guid(item));
            };

            return ProdutoIds;
        }

        //Sera chamada pelo botão de remover item do carrinho
        public static ISession RemoverItem(ISession session, Guid ProdutoId)
        {
            List<Guid> Produtos = GetCarrinho(session);

            foreach (var item in Produtos)
            {
                if (item == ProdutoId)
                {
                    Produtos.Remove(item);
                    break;
                }
            }

            string carrinho = String.Join(",",Produtos);

            session.SetString(CarrinhoKey, carrinho);

            return session;
        }
    }
}
