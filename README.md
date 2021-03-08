# C#/RESTFul API Challenge
Ília Digital C#/RESTFul API Challenge.

Hey, what's up? Are you ready to start the challenge? We would like to remember that this step will help us evaluate your performance. Take a deep breath and let’s go! We’re rooting for you. 😁

## Some rules
  1.	**DO NOT** share your answer with others;
  2.	Remember that this challenge is meant to evaluate your skills, you don't necessarily have to finish all the challenge code implementation, we just want to get to know you better. 😁

# Steps
* Using your own Git account, create a repository for this solution;
* Create a branch for this task. Use the following model for naming it: "feature/fulano_de_tal";
* When completed the challenge, share your branch with us so we can check it out;
* After receiving the challenge, you'll have 03 days to complete it. 

# Requirements
*	.NET Core 3.1 or above;
*	Entity Framework for ORM;
*	Use Microsoft SQL Server or a MySQL Server for the database;
*	Your solution must contain its migration's files;
*	Swagger implementation is mandatory (authentication and authorization are optional).

# Instructions
For this challenge, we recommend using Visual Studio or Visual Studio Code. You must create your solution from scratch.
After setting it all up, let's go to the challenge!!! \o/

# Challenge
Considerer a basic RESTFul API application used for recording customer data that follows the given requirements:
* It must be developed using C# with .NET Core 3.1+ framework;
* The customer data to be used as input must obey the following properties:
  * Name;
  * E-mail;
  * Phone contact;
  * Address - it must be structured with, at least, the following components:
    * Street;
    * Number;
    * Zipcode;
    * City;
    * State;
    * Country.
  * Users should be able to:
    * Register more than 01 address to each customer;
    * Register more than 01 phone contact to each customer:
      *  Mobile or local;
    * Register only 01 e-mail to each customer. E-mail's can't be shared between users;
    * Associate customers as if they lived together;
    * Share addresses and local phone contacts between users that live together;
*	The customer’s data must be provided, and registered, by the user, via the Web API routes;
*	The existing data must be accessible in 02 different manners:
    *	As a list;	  
    *	As a detailed object for a single entry.
*	Users must be able to:
    *	Create an entry;
    *	Edit an entry;
    * Delete an entry.
* Some suggestions and guidelines for the development of your solution:
    * Pay attention to the used syntax when naming routes and methods;
    *	We suggest a DDD architecture, but feel free to design your solution as you see fit;
    *	While developing your application, bear in mind 03 things:
          * Keep the code as clean as possible;
          * In the IT World, collaboration means everything. Therefore, keep your code as maintainable as possible;
          *	Documenting is a good code-development practice;
  *	Testing is one of the gateways for a consistent, scalable, and robust solution: feel free to implement testing as you would in the real world;
  *	As we have previously mentioned, you do not need to solve this challenged in its entirety, but we will surely consider your best effort. However, your project’s solution must build successfully.

Happy coding!

