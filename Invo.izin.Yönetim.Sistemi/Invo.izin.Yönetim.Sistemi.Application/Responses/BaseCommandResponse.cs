namespace Invo.izin.Yönetim.Sistemi.Application.Responses
{
    public class BaseCommandResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }

        public object Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
