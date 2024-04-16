# Magic Moonlight Cinema

## Overview
This Magic Moonlight Cinema is a .NET Framework application designed to streamline the process of managing a cinema. It allows for user authentication and authorization, with specific roles allocated different levels of access and functionality.
The system ensures that only logged-in users can create and purchase tickets.

## Features
- **User Authentication and Authorization**: Secure login system that supports different user roles.
- **Roles**:
  - **Default User**: Can buy tickets and check ticket details.
  - **Editor**: Inherits Default User privileges, plus can edit tickets and movie details.
  - **Admin**: Has all the privileges of other roles, plus the ability to add new movies to the database.
- **Ticket Management**: Users can create and purchase tickets after logging in.

## Installation
To install the Cinema Management System, follow these steps:
1. Ensure you have the .NET Framework installed on your system.
2. Clone this repository to your local machine.
3. Open the project in your IDE (Visual Studio recommended) and build the solution.
4. Run the application from the IDE or deploy it to a .NET compatible server.

## Usage
1. Start the application.
2. Log in with your user credentials.
3. Navigate through the application based on your user role:
   - Buy tickets and view details as a Default User.
   - Edit tickets and movies as an Editor.
   - Add new movies to the system as an Admin.

## Contributing
Contributions to the Cinema Management System are welcome. Please fork this repository and submit a pull request with your proposed changes.


