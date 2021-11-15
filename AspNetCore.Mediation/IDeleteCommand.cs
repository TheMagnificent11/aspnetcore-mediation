using MediatR;

namespace AspNetCore.Mediation
{
    /// <summary>
    /// Delete Command Interface
    /// </summary>
    /// <typeparam name="TId">Entity ID type</typeparam>
    public interface IDeleteCommand<TId> : IRequest<OperationResult>
        where TId : IComparable, IComparable<TId>, IEquatable<TId>
    {
        /// <summary>
        /// Gets the entity ID
        /// </summary>
        TId Id { get; }
    }
}
