namespace Vk.Api.Schema.Enums.Wall
{
    /// <summary>
    /// Тип действия при <see cref="SourceType.Vk"/> или <see cref="SourceType.Widget"/>
    /// </summary>
    public enum SourceData
    {
#pragma warning disable 1591
        ProfileActivity,
        ProfilePhoto,
        Comments,
        Like,
        Poll
    }
}