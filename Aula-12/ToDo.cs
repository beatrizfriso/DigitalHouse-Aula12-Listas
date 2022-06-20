
namespace Aula_12
{
    //internal class ToDo
    static class ToDo
    {
        private static List <string> tarefas = new List<string> ();
        private static string tarefa = "";
        private static string opcao = "";
        private static void AdicionarTarefa()
        {
            Console.WriteLine("Informe o nome da tarefa:");
            tarefa = Console.ReadLine();
            while (String.IsNullOrEmpty(tarefa))
            {
                Console.WriteLine("Informe uma tarefa válida:");
                tarefa = Console.ReadLine();
            }
            tarefas.Add(tarefa);

            // .add
        }
        private static void RemoverTarefa()
        {
            Console.WriteLine("Informe o nome da tarefa a ser removida:");
            tarefa = Console.ReadLine();
            while (String.IsNullOrEmpty(tarefa))
            {
                Console.WriteLine("Informe uma tarefa válida:");
                tarefa = Console.ReadLine();
            }
            if (tarefas.Contains(tarefa))
            {
                tarefas.Remove(tarefa);
            } else
            {
                Console.WriteLine("Essa tarefa não existe na lista.");
            }
            
            // .remove
        }
        private static void AtualizarTarefa ()
        {
            // .add 
            Console.WriteLine("Digite o Indice: ");
            int indice = int.Parse(Console.ReadLine());
            indice -= 1;


            if (tarefas.Count >= indice)
            {
                Console.WriteLine("Indice Encontrado");
                Console.WriteLine("O que deseja Atualizar? ");
                string atualizar = Console.ReadLine();

                tarefas[indice] = atualizar;
                Console.WriteLine("\n Adicionado.....\n");
                ListarTarefas();
            } else {
                Console.WriteLine("Indice Não Encontrado");
            }



        }
        private static void ListarTarefas()
        {
           for(int i=0; i<tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {tarefas[i]}");
            }
        }

        private static void ConsultarTarefaIndice()
        {
            Console.WriteLine("Digite um Número: ");
            int indice = int.Parse(Console.ReadLine());
            indice--;
            
            if (tarefas.Count >= indice)
            {
                Console.WriteLine($"Indice Encontrado!!! {tarefas[indice]}");
            } else
            {
                Console.WriteLine("Indice Não Encontrado ");
            }
            
        }

        private static void ListaMenu()
        {
            Console.WriteLine("Informe a ação desejada:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Remover tarefa");
            Console.WriteLine("3 - Atualizar tarefa");
            Console.WriteLine("4 - Listar todas as tarefas");
            Console.WriteLine("5 - Apresentar uma tarefa a partir do índice");
            Console.WriteLine("0 - Encerrar o programa");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    ListaMenu();
                    break;
                case "2":
                    RemoverTarefa();
                    ListaMenu();
                    break;
                case "3":
                    AtualizarTarefa();
                    ListaMenu();
                    break;
                case "4":
                    ListarTarefas();
                    ListaMenu();
                    break;
                case "5":
                    ConsultarTarefaIndice();
                    ListaMenu();
                    break;
                case "0":
                    Console.WriteLine("Obrigado(a) por utilizar nosso programa!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    ListaMenu();
                    break;
            }
        }

        public static void Inicializa()
        {
            Console.WriteLine("Bem vindo a Lista de Tarefas.Informe a ação desejada:");
            ListaMenu();
        }


    }
}
