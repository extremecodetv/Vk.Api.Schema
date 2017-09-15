using System.Collections.Generic;

namespace Vk.Api.Schema.Responses
{
    public interface ICollectionResponse<out T>
    {
        int Count { get; }

        IEnumerable<T> Items { get; }
    }
}
