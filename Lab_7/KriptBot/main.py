import re
import telebot

from view.menu import get_default_menu
from view.commands import mery_cmd
from view import random_phrases as dialog

from brench_communicate.media import send_photo

token = "5005833245:AAEH1npKVl1lPa03Z05UHV1YeyS8OMB0Pxo"
bot = telebot.TeleBot(token, parse_mode=None)


@bot.message_handler(commands=['start'])
def start_command(message):
    text = "Приветствую тебя, <b>{}</b>!".format(message.from_user.username)
    bot.send_message(message.from_user.id, text, parse_mode="HTML")
    bot.send_video(message.from_user.id, open('media/photo/1.jpg', 'rb'))
    text = "Чем сегодня займемся? ( ⓛ ω ⓛ *)"
    bot.send_message(message.from_user.id, text, parse_mode="HTML", reply_markup=get_default_menu())


@bot.message_handler(func=lambda message: True)
def listen_text_message(message):
    msg_text = message.text.lower()

    #  Определение команд для пользователя
    actions = mery_cmd
    for regular, action in actions.items():
        if re.search(regular, msg_text):
            action(message, bot)
            return

    bot.send_message(message.from_user.id, dialog.dont_know(), reply_markup=get_default_menu())


@bot.message_handler(content_types=["photo", "sticker", "audio"])
def listen_photo_message(message):
    send_photo(message, bot)

#@bot.message_handler(content_types=["sticker"])
#def listen_photo_sticker(message):
#    bot.send_sticker(message.chat.id, "CAACAgIAAxkBAAEDgTZhu8TUAz6e2VzUCUCuzPDKMgABIMIAAhwAAzUi_BEtvg6uAQsyLCME")



def main():
    print("Бот запущен")
    bot.polling()


if __name__ == '__main__':
    main()
