using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository repositorio = new SerieRepository();
        static void Main(string[] args)
        {
            string optionUser = OptionUser();
            
            while(optionUser.ToUpper() != "7")
            {
                switch (optionUser)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;    
                    case "3":
                        AtualizarSeries();
                        break;   
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;   
                    case "6":
                        Console.Clear();
                        break;   
                    default:
                        throw new ArgumentOutOfRangeException();            
                }
                optionUser = OptionUser();
            }
        }
        
        private static void VisualizarSeries()
        {   
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.ReturnForId(indiceSerie);
            Console.WriteLine(serie);
        }
        private static void ExcluirSeries()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.delete(indiceSerie);
        }
        private static void AtualizarSeries()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach(int i in System.Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Genre), i));
            }
            
            Console.WriteLine("Digite o genêro enrte as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descricao série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: indiceSerie,
            genre: (Genre)entradaGenero,
            title: entradaTitulo,
            age: entradaAno,
            description: entradaDescricao);

            repositorio.update(indiceSerie, novaSerie);
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série: ");

            foreach(int i in System.Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Digite o genêro enrte as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descricao série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.nextId(),
            genre: (Genre)entradaGenero,
            title: entradaTitulo,
            age: entradaAno,
            description: entradaDescricao);

            repositorio.add(novaSerie);
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            
            var list = repositorio.Lista();
            if(list.Count == 0)
            {
                Console.WriteLine("Nenhuma série econtrada");
            }

            foreach (var serie in list)
            {
                var excluido = serie.returnDelete();
                if(!excluido)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.returnId(), serie.returnTitle());
                }
            }
        }
        private static string OptionUser()
        {
            Console.WriteLine();
            Console.WriteLine("Dio séries a seu dispor F");
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar séries");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("6 - Limpar tela");
            Console.WriteLine("7 - Sair F");
            string optionUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return optionUser;
        }
        }
}
