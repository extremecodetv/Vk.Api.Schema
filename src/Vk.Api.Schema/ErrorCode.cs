namespace Vk.Api.Schema
{
    /// <summary>
    ///     Код ошибки
    ///     <para />
    ///     Документация: https://vk.com/dev/errors
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        ///     Произошла неизвестная ошибка
        /// </summary>
        UnknownError = 1,

        /// <summary>
        ///     Приложение выключено
        /// </summary>
        AppDisabled = 2,

        /// <summary>
        ///     Передан неизвестный метод
        /// </summary>
        UnknownMethod = 3,

        /// <summary>
        ///     Неверная подпись
        /// </summary>
        IncorrectSignature = 4,

        /// <summary>
        ///     Авторизация пользователя не удалась
        /// </summary>
        UserAuthFailed = 5,

        /// <summary>
        ///     Слишком много запросов в секунду
        /// </summary>
        TooManyRequests = 6,

        /// <summary>
        ///     Нет прав для выполнения этого действия
        /// </summary>
        PermissionDenied = 7,

        /// <summary>
        ///     Неверный запрос
        /// </summary>
        InvalidRequest = 8,

        /// <summary>
        ///     Слишком много однотипных действий
        /// </summary>
        FloodControl = 9,

        /// <summary>
        ///     Произошла внутренняя ошибка сервера
        /// </summary>
        InternalServerError = 10,

        /// <summary>
        ///     В тестовом режиме приложение должно быть выключено или пользователь должен быть залогинен
        /// </summary>
        TestModeEnabled = 11,

        /// <summary>
        ///     Требуется ввод кода с картинки (Captcha)
        /// </summary>
        CaptchaNeeded = 14,

        /// <summary>
        ///     Доступ запрещен
        /// </summary>
        AccessDenied = 15,

        /// <summary>
        ///     Требуется выполнение запросов по протоколу HTTPS, т.к. пользователь включил настройку, требующую работу через
        ///     безопасное соединение
        /// </summary>
        HttpAuthFailed = 16,

        /// <summary>
        ///     Требуется валидация пользователя
        ///     <para />
        ///     Документация: https://vk.com/dev/need_validation
        /// </summary>
        ValidationRequired = 17,

        /// <summary>
        ///     Страница удалена или заблокирована
        /// </summary>
        UserDeleted = 18,

        /// <summary>
        ///     Данное действие запрещено для не Standalone приложений
        /// </summary>
        DeniedForNonStandalone = 20,

        /// <summary>
        ///     Данное действие разрешено только для Standalone и Open API приложений
        /// </summary>
        OlnyStandalone = 21,

        /// <summary>
        ///     Метод был выключен.
        ///     <para />
        ///     Актуальные методы: https://vk.com/dev/methods
        /// </summary>
        MethodIsDisabled = 23,

        /// <summary>
        ///     Требуется подтверждение со стороны пользователя
        ///     <para />
        ///     Документация: https://vk.com/dev/need_confirmation
        /// </summary>
        ConfirmationRequired = 24,

        /// <summary>
        ///     Ключ доступа сообщества недействителен
        /// </summary>
        GroupAuthFailed = 27,

        /// <summary>
        ///     Ключ доступа приложения недействителен
        /// </summary>
        AppAuthFailed = 28,

        /// <summary>
        ///     Один из необходимых параметров был не передан или неверен
        /// </summary>
        InvalidParameter = 100,

        /// <summary>
        ///     Неверный API ID приложения
        /// </summary>
        InvalidApplicationApiId = 101,

        /// <summary>
        ///     Неверный идентификатор пользователя
        /// </summary>
        InvalidUserId = 113,

        /// <summary>
        ///     Неверный timestamp
        /// </summary>
        InvalidTimestamp = 150,

        /// <summary>
        ///     Доступ к альбому запрещён
        /// </summary>
        AccessToAlbumDenied = 200,

        /// <summary>
        ///     Доступ к аудио запрещен
        /// </summary>
        AccessToAudioDenied = 201,

        /// <summary>
        ///     Доступ к группе запрещён
        /// </summary>
        AccessToGroupDenied = 203,

        /// <summary>
        ///     Альбом переполнен
        /// </summary>
        AlbumFull = 300,

        /// <summary>
        ///     Действие запрещено. Вы должны включить переводы голосов в настройках приложения
        /// </summary>
        VotesProcessingDisabled = 500,

        /// <summary>
        ///     Нет прав на выполнение данных операций с рекламным кабинетом
        /// </summary>
        AdsPermissionDenied = 600,

        /// <summary>
        ///     Ошибка при работе с рекламным кабинетом
        /// </summary>
        AdsError = 603
    }
}