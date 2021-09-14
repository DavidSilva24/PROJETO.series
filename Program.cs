using System;

namespace Projeto
{
    class Program
    { 
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {   EntidadeBase minhaClasse = new EntidadeBase();
        Série MeuObjeto = new série ();
        MeuObjeto.id
            Console.WriteLine("Hello World!");
        }

        static void main(string[] args)
        {
          string opcaoUsuario = ObterOpcaoUsuario();
          
          while (opcaoUsuario.ToUpper() != "X")
          { 
              switch (opcaoUsuario)
              {
                  case "1":
                  listaSeries();
                  break;
                  case "2":
                  InserirSerie();
                  break;
                  case "3":
                  AtualizarSerie();
                  break;
                  case "4":
                  ExcluirSerie();
                  break;
                  case "5":
                  VisualizarSerie();
                  break;
                  case "C":
                  console.clear{};
                  break;
                  
                  
              }



          }
        } private static void Listarséries()
        {
            console.WriteLine("listar séries");

            var lista = repositorio.Lista();

            if (lista.count) == 0)
            {
                console.writeline("nenhuma série cadastrada.");
                return;
            }
             foreach(var serie in lista)
             {
                 console.writeline("#ID {0}: - {1}", serie.retornaId(), serie.retornaTítulo());
              }
              private static void InserirSerie()
              {
                  console.writeline("inserir nova série");
                  
                  foreach (int i in enum .getvalues(typeof(genero)))
                  {
                    console.writeline("{0} - {1}", i , enum.getname(typeof(genero), i));

                  }
                  console.write("digite o genêro entre as opções acima: ");
                  int entradaGenero = int.parse(console.readline());

                  console.write("digite o título da Série: ");
                  string entradaTítulo = console.Readline());
                  
                  console.write("digite o ano de Início da Série: ");
                  int entradaAno = int.parse(console.readline());

                  console.write("digite a descrição da Série: ");
                  string entradaDescricao = console.readline();

                  Serie novaSerie = new Serie{id: repositorio.proximoId(),
                                              genero: (genero)entradaGenero,
                                              titulo: entradaTítulo,
                                              ano: entradaAno,
                                              descricai:entradaDescricao);

                 repositorio.Insere(novaSerie);                         
              }


        }
        
        private static string ObterOpcaoUsuario()
        {
            console.WriteLine();
            console.WriteLine("Projeto a seu dispor!!!");
            console.WriteLine("informe a opção desejada:");

            console.WriteLine("1- Listar séries");
            console.WriteLine("2- Inserir nova série");
            console.WriteLine("3- Atualizar série");
            console.WriteLine("4- Excluir série");
            console.WriteLine("5- Visualizar série");
            console.WriteLine("C- Limpar tela");
            console.WriteLine("X- Sair");
            console.WriteLine{};

            string opcaoUsuario = console.readline().ToUpper();
            console.WriteLine{};
            return opcaoUsuario;
        }
    }
}
