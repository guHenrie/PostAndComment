using System;
using IntroducaoStringBuilder.Entities;

namespace IntroducaoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando os comentarios da postagem
            Comment comment1 = new Comment("Tenha uma boa viagem!");
            Comment comment2 = new Comment("Que legal!");

            //instanciando o post
            Post post1 = new Post(
                DateTime.Parse("30/08/2021 20:01:34"),
                "Conhecendo um lugar incrível",
                "Um lugar lindo, nunca senti tamanha paz, esse é meu Brasil!",
                67);

            //associando e adicionando os comentarios no post
            post1.AddComment(comment1);
            post1.AddComment(comment2);



            //instanciando os comentarios da postagem
            Comment comment3 = new Comment("Bom diaaa!");
            Comment comment4 = new Comment("Uaal, parabens!!!");

            //instanciando o post
            Post post2 = new Post(
                DateTime.Parse("29/08/2021 07:11:54"),
                "Mais uma manha",
                "Agradecido por mais um amanhacer",
                15);

            //associando e adicionando os comentarios no post
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
