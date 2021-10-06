from ursina import *

app = Ursina()
window.color = color.black
table = Entity(
  model='cube',
  color=color.white,
  scale=(2,1,3),
  rotation=(95,0,0)
)

ball = Entity(
  model='sphere',
  color=color.green,
  z=-1,
  scale=0.1,
  collider='box'
)

player1 = Entity(
  model='cube',
  color=color.red,
  scale=(0.6,0.1,1),
  position=(0,-1.4,-1),
  collider='box'
)
player2 = Entity(
  model='cube',
  color=color.blue,
  scale=(0.6,0.1,1),
  position=(0,1.4,-1),
  collider='box'
)
speed_x = speed_y = 0.7

def update():
  global speed_x, speed_y
  if player1.x < 0.7:
    player1.x += held_keys['d'] * time.dt
  if player1.x > -0.7:
    player1.x -= held_keys['a'] * time.dt
  if player2.x < 0.7:
    player2.x += held_keys['right arrow'] * time.dt
  if player2.x > -0.7:
    player2.x -= held_keys['left arrow'] * time.dt
  ball.x += speed_x * time.dt
  ball.y += speed_y * time.dt
  if abs(ball.x) > 0.9:
    speed_x = -speed_x
  if abs(ball.y) > 1.4:
    ball.x = ball.y = 0
  if ball.intersects().hit:
    speed_y = -speed_y
    speed_x *= 1
    speed_y *= 1


camera.orthographic = True
camera.fov= 4

app.run()