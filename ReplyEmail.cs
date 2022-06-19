namespace Projeto3_POO
{
    public class ReplyEmail : IExhibitedEmail
    {
        private int _idDoubtEmail;
        private int _id;
        private string _doubt;
        private string _reply;

        public int IdDoubtEmail
        {
            get
            {
                return this._idDoubtEmail;
            }
            set
            {
                this._idDoubtEmail = value;
            }
        }

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

        public string Doubt
        {
            get
            {
                return this._doubt;
            }
            set
            {
                this._doubt = value;
            }
        }

        public string Reply
        {
            get
            {
                return this._reply;
            }
            set
            {
                this._reply = value;
            }
        }

        public string Show()
        {
            return $"============= Resposta =============\n[Número de identificação do e-mail de dúvida]: {IdDoubtEmail}\n[Número de identificação]: {Id}\n[Dúvida]: {Doubt}\n[Resposta]: {Reply}\n";
        }
    }
}