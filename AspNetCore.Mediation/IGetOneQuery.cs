using MediatR;

namespace AspNetCore.Mediation
{
    /// <summary>
    /// Get One Entity Query Interface
    /// </summary>
    /// <typeparam name="TId">Entity ID type</typeparam>
    /// <typeparam name="TResponseEntity">Reponse entity type</typeparam>
    public interface IGetOneQuery<TId, TResponseEntity> : IRequest<OperationResult<TResponseEntity>>
        where TId : IComparable, IComparable<TId>, IEquatable<TId>
        where TResponseEntity : class
    {
        /// <summary>
        /// Gets the entity ID
        /// </summary>
        TId Id { get; }
    }
}
