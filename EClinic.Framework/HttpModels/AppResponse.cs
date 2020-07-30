namespace EClinic.Framework.HttpModels
{
    public class AppResponse
    {
        public bool IsSuccessful { get; set; }
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
    }

    public class AppResponse<T> : AppResponse
    {
        public T Data { get; set; }
    }
}