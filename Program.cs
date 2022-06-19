using System;
using System.Collections.Generic;

namespace Projeto3_POO
{
    class Program
    {
        static void Main()
        {
            string option = string.Empty;
            int id = 1;

            LinkedList<ReplyEmail> responseList = new LinkedList<ReplyEmail>();
            LinkedList<EmailOfQuestion> listOfQuestions = new LinkedList<EmailOfQuestion>();
            LinkedList<EmailOfQuestion> teacherEmailList = new LinkedList<EmailOfQuestion>();

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo ao sistema de e-mail do TropTech!");
                Console.WriteLine("Escolha o modo de execução:");
                Console.WriteLine("1 - Aluno\n2 - Professor\n3 - Sair");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        id = StudentActions.ExecuteActionsAndUpdatedID(responseList, listOfQuestions, teacherEmailList, id);
                        break;
                    case "2":
                        id = TeacherActions.ExecuteActionsAndUpdatedID(responseList, listOfQuestions, teacherEmailList, id);
                        break;
                    default:
                        break;
                }
            } while (option != "3");
        }
    }
}