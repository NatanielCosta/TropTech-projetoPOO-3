namespace Projeto3_POO
{
    static class TeacherActions
    {
        public static int ExecuteActionsAndUpdatedID(LinkedList<ReplyEmail> responseList, LinkedList<EmailOfQuestion> listOfQuestions, LinkedList<EmailOfQuestion> teacherEmailList, int id)
        {
            string option = string.Empty;
            bool thereAreEmails = teacherEmailList.Count > 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Visualizar dúvidas\n2 - Enviar resposta\n3 - voltar para o menu principal");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        showEmails(teacherEmailList);
                        break;
                    case "2":
                        if (thereAreEmails)
                            id = sendReplyAndUpdatedId(responseList, listOfQuestions, teacherEmailList, id);
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há nenhum e-mail para ser respondido");
                            clickToContinue();
                        }
                        break;
                    default:
                        break;
                }
            } while (option != "3");

            return id;
        }

        static void showEmails(LinkedList<EmailOfQuestion> teacherEmailList)
        {
            bool thereAreEmails = teacherEmailList.Count > 0;

            Console.Clear();

            if (thereAreEmails)
                foreach (var email in teacherEmailList)
                {
                    Console.WriteLine(email.Show());
                }
            else
                Console.WriteLine("Não há nenhum e-mail para ser respondido");

            clickToContinue();
        }

        static int sendReplyAndUpdatedId(LinkedList<ReplyEmail> responseList, LinkedList<EmailOfQuestion> listOfQuestions, LinkedList<EmailOfQuestion> teacherEmailList, int id)
        {
            ReplyEmail replyEmail = new ReplyEmail();

            Console.Clear();
            Console.WriteLine("Informe o número de indentificação do email que gostaria de responder:");
            replyEmail.IdDoubtEmail = Convert.ToInt32(Console.ReadLine());

            replyEmail.Id = id;
            id++;

            Console.Clear();

            Console.WriteLine("Informe a sua resposta:");
            replyEmail.Reply = Console.ReadLine();

            foreach (var email in listOfQuestions)
            {
                if (email.Id == replyEmail.IdDoubtEmail)
                {
                    email.Answered = true;
                    replyEmail.Doubt = email.Question;
                }
            }

            EmailOfQuestion emailAnswered = new EmailOfQuestion();
            foreach (var email in teacherEmailList)
            {
                if (email.Id == replyEmail.IdDoubtEmail)
                    emailAnswered = email;
            }

            teacherEmailList.Remove(emailAnswered);
            responseList.AddFirst(replyEmail);

            clickToContinue();
            return id;
        }

        static void clickToContinue()
        {
            Console.WriteLine("Digite qualquer tecla para prosseguir...");
            Console.ReadKey();
        }
    }
}