namespace Projeto3_POO
{
    public class EmailOfQuestion : IExhibitedEmail
    {
        private int _id;
        private string _question;
        private string _answered;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Question
        {
            get
            {
                return this._question;
            }
            set
            {
                this._question = value;
            }
        }

        public bool Answered
        {
            get
            {
                return this._answered == "Sim" ? true : false;
            }
            set
            {
                this._answered = (value == true) ? "Sim" : "Não";
            }
        }



        public string Show()
        {
            return $"============== Dúvida ==============\n[Número de indentificação]: {_id}\n[Pergunta]: {_question}\n[Respondido]: {_answered}\n";
        }
    }
}