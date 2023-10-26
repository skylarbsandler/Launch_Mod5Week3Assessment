# JeffersonCountyLibrary

## Setup
* Fork and Clone this repository
* Run `update-database`

## Exercise (12 points)

Check out a new branch and complete the following tasks **in order**:
* 2 points - There is a bug in our authentication!  Identity looks like it is set up, but we can't register users.  Find and fix this bug! (Hint: this should only take one line of code)
* 2 points - Right now, anyone can 'check out' a book.  Update the application so that only a logged in user can check out a book.
* 4 points - In this application, we have the ability to create new books.  Improve this functionality by:
  * Add a link from the nav-bar to add a book
  * Make sure only Librarians can add a book
* 2 points - Create a descriptive pull request and merge this branch into main
* 2 points - Take a screenshot of a database query result from pgAdmin that clearly shows which users in your database are librarians.  Update this README to include your screenshot below:
  
![image](https://github.com/skylarbsandler/Launch_Mod5Week3Assessment/assets/95989203/8bd689bf-d97a-416e-81e9-9b2e7bd8e2ee)

  

## Questions (6 points)

Answer the questions below in this README.  Answer these questions as if you are in an interview!

1. What are roles and claims as they relate to Authentication and Authorization?
   For Auth, roles and claims help control what a user can do. A role is a group a users can belong to and roles can have different authorization within an application. For example, in a library application, there would be roles like "Librarian" and "User". The Librarian role would have additional access to certain actions and aspects of the application. They would be able to add books to the library's collection, while a "User" would not have this capability. A claim is a piece of information about a user that represents
   a characteristic about them which can also be used to control access within an application. For example, alcohol companies can use a claim such as "isOver21" to grant or deny access to their website based on a user's claim.
   
3. How do cookies play a role in authentication and authorization?
   Cookies play an important role in Auth. For authentication, cookies are necessary to session management. When a user logs in, a session is created and stored in a cookie. This cookies then helps identify the user
   for additional requests to the server. Cookeis also help with persistent login so the user can stay logged in for multiple sessions. For authorization, cookies contain info about a user's roles and permissions, which
   are used to determine what a user is allowed to do within an application. 

4. If asked to implement Auth in a new .NET application, would you use the Identity framework?
   I would use Identity framework to implement Auth in a new .NET application. Identity is many built-in auth features such as login functionality, email confirmation, password reset, two-factor auth, etc.
   All of these features are also highly customizable. It is easy to select which features to implement based on the needs of the application. For C#/.NET applications I have built, using Identity is a seamless choice
   to support auth. Though I could have hand-rolled much of the auth features to achieve a similar result, using Identity simplified the process and allowed me to focus on customizing the auth features even further based on
   my application rather than sending this time building these features from the ground up.

## Rubric

This assessment has a total of 18 points.  Earning 12 or higher is a pass!
