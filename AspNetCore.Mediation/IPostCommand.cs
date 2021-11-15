using MediatR;

namespace AspNetCore.Mediation
{
    /// <summary>
    /// Post Command Interface
    /// </summary>
    /// <typeparam name="TId">ID type of entity being created</typeparam>
    public interface IPostCommand<TId> : IRequest<OperationResult<TId>>
        where TId : IComparable, IComparable<TId>, IEquatable<TId>
    {
    }
}
