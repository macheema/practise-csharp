namespace Generics.Result
{
    public class ResultService
    {
        public ResultGenerics<T, M> GetResult<T, M>(T error, M msg)
        {
            return new ResultGenerics<T, M> { Data = msg, Error = error };
        }
        public ResultString GetResultString(bool error, string msg)
        {
            return new ResultString { Data = msg, Error = error };
        }
        public ResultInt GetResultInt(bool error, int msg)
        {
            return new ResultInt { Data = msg, Error = error };
        }

    }
}
