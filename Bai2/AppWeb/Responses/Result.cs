using System.Security.Cryptography.Xml;

namespace AppWeb.Responses
{
    public interface IResult<T>
    {
        T Data { get; set; }

        List<string> Messages { get; set; }

        bool Succeeded { get; set; }

        int Code { get; set; }
    }
    public class Result<T> : IResult<T>
    {
        public T Data { get; set; }

        public List<string> Messages { get; set; } = new List<string>();

        public bool Succeeded { get; set; }

        public int Code { get; set; }

        #region Non Async Methods 

        #region Success Methods 
        public static Result<T> Success(string uri, int status201Created)
        {
            return new Result<T>
            {
                Succeeded = true,
                Code = 200,
            };
        }

        public static Result<T> Success(T pData, int pCode)
        {
            return new Result<T>
            {
                Succeeded = true,
                Data = pData,
                Code = pCode
            };
        }

        #endregion


        #region Failure Methods 
        public static Result<T> Failure(int status500InternalServerError)
        {
            return new Result<T>
            {
                Succeeded = false,
                Code = 400,
            };
        }

        public static Result<T> Unauthorized()
        {
            return new Result<T>
            {
                Succeeded = false,
                Code = 401,
                Messages = new List<string>() { "Unauthorized" },
            };
        }

        public static Result<T> Forbidden()
        {
            return new Result<T>
            {
                Succeeded = false,
                Code = 403,
                Messages = new List<string>() { "Forbident" },
            };
        }

        public static Result<T> Failure(string pMessage, int pCode)
        {
            return new Result<T>
            {
                Succeeded = false,
                Messages = new List<string> { pMessage },
                Code = pCode,
            };
        }

        public static Result<T> Failure(List<string> pMessages, int pCode)
        {
            return new Result<T>
            {
                Succeeded = false,
                Messages = pMessages,
                Code = pCode,
            };
        }

        #endregion

        #endregion


        #region Async Methods 

        #region Success Methods 


        #endregion


        #region Failure Methods 



        #endregion

        #endregion
    }
}
