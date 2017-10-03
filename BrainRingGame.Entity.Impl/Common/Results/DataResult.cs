using BrainRingGame.Entity.Abstract.Common.Results;

namespace BrainRingGame.Entity.Impl.Common.Results
{
    public class DataResult<TData> : IDataResult<TData>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TData Data { get; set; }
    }
}