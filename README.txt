--Software/tools used and needed
	Visual studio 2019 
	microsoft sql server management studio 18

--setup
	open the script named SqlScript
	run the script
	take note of your connection string
	keep the database open
	open the visual studio program provided in the folder PROG7312POE
	go to the class dbLink.cs and on line 18 youll see the connection string:
private string DBConnectionString = @"Data Source=DESKTOP-R2LMNPF\SQLEXPRESS;Initial Catalog=PROGPOE7312;Integrated Security=True"; 

please change this to your connection string which should look like this the only thing different should just be the name of your pc
where it says Source=
once the connection string is changed you can run the application

--running 
the app is easy to run just press the start button 
-- you can start with making a new user or you can use an existing user
a pre existing user is 
user10 as the username and the password is password  to check  in loginForm.cs lines 21&22


--Help when marking 
App Functionality: Replacing books feature (Task 1) working with feedback incorporated.

App Functionality: Identifying areas feature (Task 2) working with feedback incorporated.

Data: File created containing the data to be read by the application. This is done in the SQL script.

App Functionality: Loading data from the file. This can be found in the dbLink class method called buildtree lines 266-296. 

App Functionality: Quiz allows user to select top‐level item and correctly verifies the choice. this is done with the list box that displays the question.

App Functionality: Quiz correctly handles a correct response by showing the user options from the next level down. This can be seen when the user answers the question correctly.

App Functionality: Quiz correctly handles incorrect answer. when the player answers incorrectly the game resets

App Functionality: Gamification feature implemented. This is done with the point system, currency system, leaderboard system and hint system.

App Logic: Storing data in a tree.  This can be found in the dbLink class method called buildtree lines 266-296. 

Coding Standards: Code is well structured and documented.

Documentation: Readme file provides enough information to run the app.

Other marks: App is easy to use.

Other Marks: Advanced features not covered in class (Bonus Marks).