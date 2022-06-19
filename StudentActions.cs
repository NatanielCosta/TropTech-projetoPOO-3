namespace Projeto3_POO
{
    static class StudentActions
    {
        public static int ExecuteActionsAndUpdatedID(LinkedList<ReplyEmail> responseList, LinkedList<EmailOfQuestion> listOfQuestions, LinkedList<EmailOfQuestion> teacherEmailList, int id)
        {
            string option = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Enviar dúvida\n2 - Visualizar e-mails\n3 - Voltar para o menu principal");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        id = sendQuestionAndUpdatedId(listOfQuestions, teacherEmailList, id);
                        break;
                    case "2":
                        showEmails(responseList, listOfQuestions);
                        break;
                    default:
                        break;
                }
            } while (option != "3");
            
            return id;
        }
        
        static int sendQuestionAndUpdatedId(LinkedList<EmailOfQuestion> listOfQuestions, LinkedList<EmailOfQuestion> teacherEmailList, int id)
        {
            Console.Clear();

            EmailOfQuestion emailOfQuestion = new EmailOfQuestion();

            Console.WriteLine("Escreva a dúvida em forma de pergunta:");
            emailOfQuestion.Question = Console.ReadLine();

            emailOfQuestion.Id = id;
            id++;

            emailOfQuestion.Answered = false;

            listOfQuestions.AddFirst(emailOfQuestion);
            teacherEmailList.AddFirst(emailOfQuestion);

            clickToContinue();
            return id;
        }

        static void showEmails(LinkedList<ReplyEmail> responseList, LinkedList<EmailOfQuestion> listOfQuestions)
        {
            bool thereAreEmails = listOfQuestions.Count > 0;

            Console.Clear();

            if (thereAreEmails)
            {
                foreach (var email in responseList)
                {
                    Console.WriteLine(email.Show());
                }
                foreach (var email in listOfQuestions)
                {
                    Console.WriteLine(email.Show());
                }
            }
            else
            {
                Console.WriteLine("Não há nenhum e-mail para ser mostrado");
            }

            clickToContinue();
        }

        static void clickToContinue()
        {
            Console.WriteLine("Digite qualquer tecla para prosseguir...");
            Console.ReadKey();
        }
    }
}