import chatterbot
from chatterbot import chatbot
from chatterbot.trainers import ListTrainer
 
#creating a new chatbot
chatbot = Chatbot('Lindor')
trainer = ListTrainer(chatbot)
trainer.train([ 'hi, how are you', 'im good', 'What you doing?'])
 
#getting a response from the chatbot
response = chatbot.get_response("I want a course")
print(response)