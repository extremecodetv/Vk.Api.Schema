
namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий информацию для предпросмотра документа
    /// </summary>
    public interface IPreview
    {
        /// <summary>
        /// Изображение для предпросмотра, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IPreviewPhoto Photo { get; }

        /// <summary>
        /// Данные о граффити, если доступно, 
        /// иначе <see langword="null"/>
        /// </summary>
        IPreviewGraffiti Graffiti { get; }

        /// <summary>
        /// Данные об аудиосообщении, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IPreviewAudioMessage AudioMessage { get; }
    }
}
