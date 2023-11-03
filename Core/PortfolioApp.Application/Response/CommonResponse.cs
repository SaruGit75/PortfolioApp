﻿namespace PortfolioApp.Application.Response
{
    public class CommonResponse<T>
    {
        public ResponseStatus ResponseStatus  { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }

        public CommonResponse()
        {
            ResponseStatus = ResponseStatus.Fail;
            Message = string.Empty;
            Errors = new List<string>();
            Data = default(T);
        }
    }
}
