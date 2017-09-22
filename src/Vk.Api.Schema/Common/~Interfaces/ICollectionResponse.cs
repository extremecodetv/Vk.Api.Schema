using System.Collections.Generic;

namespace Vk.Api.Schema.Common
{
    public interface ICollectionResponse<out T>
    {
        int Count { get; }

        IEnumerable<T> Items { get; }
    }
}
