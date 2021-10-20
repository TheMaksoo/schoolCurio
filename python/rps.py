from random import randint
import time
#create a list of play options
t = ["Rock", "Paper", "Scissors"]

#assign a random play to the computer
computer = t[randint(0,2)]

#set player to False
player = False
aiScore = 0
playerScore = 0
scoreList = ""
i = 1
a = 0
b = 0
while player == False:
#set player to True
    player = t[randint(0,2)]#//input("Rock, Paper, Scissors?")
    if player == computer:
        print("Tie!")
        
    elif player == "Rock":
        if computer == "Paper":
            print("You lose!", computer, "covers", player)
            aiScore += 1
        else:
            print("You win!", player, "smashes", computer)
            playerScore += 1
            
    elif player == "Paper":
        if computer == "Scissors":
            print("You lose!", computer, "cut", player)
            aiScore += 1
        else:
            print("You win!", player, "covers", computer)
            playerScore += 1
            

    elif player == "Scissors":
        if computer == "Rock":
            print("You lose...", computer, "smashes", player)
            aiScore += 1
        else:
            print("You win!", player, "cut", computer)
            playerScore += 1
            
    else:
        print("That's not a valid play. Check your spelling!")
    
    if playerScore == 10000:
        print("Simulation Run Ended.\n")
        if playerScore >= aiScore:
            print("Player wins")
            a += 1
        else:
            print("AI wins")
            b += 1
        
        
        scoreList += "\n\nRun {} a:{} | b:{}".format(i, a, b)
        i += 1
        scoreList += "\nPlayer score:{}".format(playerScore)
        scoreList += "\nAI score:{}".format(aiScore)
        print("{}".format(scoreList))
        if (len(str(i)) % 100) == 0:
            time.sleep(10)
        else: 
            time.sleep(4)
        playerScore = 0
        aiScore = 0
        player = False

    else:
        print("\n\nPlayer score:{}\nAI score:{}".format(playerScore, aiScore))
        #player was set to True, but we want it to be False so the loop continues
        player = False
        computer = t[randint(0,2)]
    