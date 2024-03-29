using System.Collections.Generic;

namespace CryptoTelegram.Models.Telegram
{   /* ReplyKeyboardMarkup */
    public class TelegramButtons
    {
        public TelegramButtons() => remove_keyboard = true;
        public TelegramButtons(
            List<List<string>> keyboard, 
            bool resize_keyboard = false,
            bool one_time_keybord = true)
        {
            this.keyboard = keyboard;
            this.resize_keyboard = resize_keyboard;
            this.one_time_keybord = one_time_keybord;
        }
        public List<List<string>> keyboard { get; set; }
        public bool resize_keyboard { get; set; }
        public bool one_time_keybord { get; set; }
        /* ReplyKeyboardRemove */
        public bool remove_keyboard { get; set; }
    }
}