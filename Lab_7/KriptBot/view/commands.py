import re

from brench_communicate import hello, weather

mery_cmd = {
    r"\bпривет|здра?ств|\bку\b": hello.send_hello,
    r"\bкак дела|что делаешь|\bчем занимаешься|как ты": hello.send_how_are_you,
    r"погода|температура|сколько завтра градус": weather.send_weather_yesterday,
    r" анекдот|шутка|прикол": hello.send_joke,
}