namespace MyPortfolio.DAL.Entities
{
    public class Message
    {
        public int MessageId {  get; set; }
        public string NameSurname{  get; set; }
        public string Subject{  get; set; }
        public string Email{  get; set; }
        public string MessageDetail1{  get; set; }
        public DateTime SendDate { get; set; }
        public bool İsReady {  get; set; }
    }
}
