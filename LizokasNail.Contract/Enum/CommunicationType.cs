using System.ComponentModel;

namespace LizokasNail.Contract.Enum
{
    /// <summary>
    /// Вид связи
    /// </summary>
    public enum CommunicationType
    {
        /// <summary>
        /// Телефон
        /// </summary>
        [Description("Телефон")]
        Phone = 0,

        /// <summary>
        /// Вотсап
        /// </summary>
        [Description("Вотсап")]
        WhatsUp = 1,

        /// <summary>
        /// Вайбер
        /// </summary>
        [Description("Вайбер")]
        Viber = 2,

        /// <summary>
        /// Инстаграм
        /// </summary>
        [Description("Инстаграм")]
        Instagram = 3,

        /// <summary>
        /// Телеграм
        /// </summary>
        [Description("Телеграм")]
        Telegram = 4,

        /// <summary>
        /// Вконтакте
        /// </summary>
        [Description("Вконтакте")]
        VK = 5,

        /// <summary>
        /// Юла
        /// </summary>
        [Description("Юла")]
        Yula = 6,

        /// <summary>
        /// Другое
        /// </summary>
        [Description("Другое")]
        Other = 7,
    }
}
