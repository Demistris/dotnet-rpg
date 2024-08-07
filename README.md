# Text-Based RPG
A text-based role-playing game where users can register, create characters, add skills and weapons, and engage in battles, all managed through a Swagger interface.

## Features
+ **User Registration**: Register new users with unique usernames
+ **Character Creation**: Create and customize characters with various attributes
+ **Skills and Weapons**: Add skills and weapons to characters
+ **Battles**: Fight against other characters and test your skills
+ **Swagger Integration**: Use Swagger for easy API interaction and testing

## Installation
To set up and run the Text-Based RPG locally, follow these steps:
1. **Clone the repository**: https://github.com/Demistris/dotnet-rpg.git
2. **Open the project**: Open the solution file (_'_**.sln**_'_) in Visual Studio
3. **Restore NuGet packages**: Restore the necessary NuGet packages for the project
4. **Build and run**: Build the solution and run the project

## How to Use
+ **Register a User**:
  + Go to the _POST /Auth/Register_ endpoint.
  + Provide a unique username and password.
  + Execute the request to register a new user.
+ **Create a Character**:
  + Go to the _POST /api/Character_ endpoint.
  + Provide the character details such as name, hit points, strength, defense, inteligence and class
  + Execute the request to create a new character
+ **Add Skills and Weapons**:
  + Go to the _POST /api/Character/Skill_ or _POST /Weapon_ endpoints
  + Provide the skill or weapon details
  + Execute the request to add skills or weapons to the character
+ **Engage in Battle**:
  + Go to the _POST /Fight_ endpoint
  + Provide the details of the characters to fight
  + Execute the request to initiate the battle and view the results
<br>

![rpg](https://github.com/user-attachments/assets/1e7f85f6-67d6-4c56-a4b0-d5dc7bbe4270)
