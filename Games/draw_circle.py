from random import randint
import pygame as py

py.init()
size = (1600, 1600)
screen = py.display.set_mode(size)

while True:
  for ev in py.event.get():
    pos = py.mouse.get_pos()
    r = randint(0, 255)
    g = randint(0, 255)
    b = randint(0, 255)
    col = (r, g, b)
    py.draw.circle(screen, col, pos, 45, 8)
    py.display.update()

