﻿namespace KaiCoreApp.Utilities.Dtos
{
    public class GenericResult
    {
        public GenericResult()
        {
        }

        public GenericResult(bool sucess)
        {
            Success = sucess;
        }

        public GenericResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public GenericResult(bool success, object data)
        {
            Success = success;
            Data = data;
        }

        public object Data { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }

        public object Error { get; set; }
    }
}