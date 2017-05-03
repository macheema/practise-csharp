namespace Generics.Result
{
    public class ResultGenerics<TStateType, TMessageType>
    {
        public TStateType Error { get; set; }
        public TMessageType Data { get; set; }
    }
}
