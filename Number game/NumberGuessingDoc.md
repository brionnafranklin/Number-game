
| Brionna Franklin |
| :---          	|
| S198017      	|      	
| Number Game |

## I. Requirements
1. You are to create a program that will correctly identify the number a user is thinking.
    - **Name**: Number Guessing Game
    - **Problem Statement**: You are to create a program that will correctly identify the number a user is thinking.
    - **Problem Specifications**: The program will prompt the user to think of a number.

        Once the user has thought of a number the user must tell the computer to begin guessing.

        The computer will begin guessing numbers by printing it's guess to the console.

        After each guess, the user must tell the computer if the guessed number is less than, greater than, or equal to the number the user is thinking.

        The program will finish when either

        The computer has guessed the correct number
        Application is forced to quit.
        Specifications

        Must use the following

        variables
        conditionals
        loops
        Expected Result

        The number that the user is thinking
        Submission Requirements

        Project must be submitted in the form of a .zip file.

        The zip file must contain

        Source files with all your code.
        Standalone executable to run your application without visual studio.

2. Input Information:
    - The user will input their response to the question asked on screen, using 1 or 2.

3. Output Information:
    - **Start**: console tells the user to pick a number 1-100.
    - **Guessing**: generates random number and asks the user if that is their number.
    - **Narrows down range**: The console asks if the printed number is higher or lower and changes the min or max depending on the users response.
    - **Check for Cheating**: the program checks to see if the user is cheating by checking to see if the users number is valid and within the given range.
4. User Interface Information:
    - **Starting prompt**: Asks user to think of a number.
    - **first question**: Asks the user if the generated number is the number they have selected. The user then responds with 1, for yes, or 2 for no.
    - **second question**: Asks the user if their number is higher or lower then number that has been selected. The user then responds with 1, for higher, or 2 for lower.
    - **liar detecter**: Informs the user that the program knows the user has cheated.

## II. Design

1. _System Architecture_
|
|:-----------
Game Function Diagram
|
![User Interface gif](https://i.imgur.com/B8oF4iN.jpg)
2. Object Information

    **Class**: Number_game

    Description: main program; Where all aspects of the game exist

        Attributes:
            - Name: min
            Description: holds the lowest number that it is used for the range of generating the random number.
            Type: int

            - Name: max
            Description: holds the highest number that it is used for the range of generating the random number.
            Type: int

            - Name: choice
            Description: holds the user's input so it can be read as a choice.
            Type: string

            - Name: gameOver
            Description: holds true or false to dertermine wether or not the game is over.
            Type: bool

            - Name: guess
            Description: located within the while loop; holds the generated number.
            Type: int

