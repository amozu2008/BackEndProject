This is a BackEnd API Assignment using .NetCore framework and C# programming language. 
The Objective of the BackEnd API Assignment is to expose three endpoint that will enable users/customer create an account, 
view all account and view account for a specific user or customer.

The application has two layers. BackEnd layer and Front Web layer. The front web layer talks to the Backend WebAPI layer.
Front Web layer uses Java Script Fetch API to assess the end points. this layer uses a seperate server. The url https://localhost:44309
takes you to the home page. This home page consist of a form that takes customer id and initial credit.

Another url https://localhost:44309/Home/Customer takes you to another web page, where we can search for all customers and customer by their ID.
Please note i only have three existing customers with ID of 1,2 and 3. only these customer can open an account.
I used a List api as my data collection.

I am still in my development ENV. My Back end Web API local server url is https://localhost:44395.

https://localhost:44395/api/account This end point does a POST request which accept two parameters customerid and initialCredit.
The endpoint creates a new account for a specific customer id and also creates a transaction on the newly created account if initial credit is more than zero.
But if the initial creadit is zero no transaction is created for that user.

The second end point is https://localhost:44395/api/account/{customerid}. This end point does a "GET" request which accept a customer id
and displays the customer information and their transactions.

The third end point is https://localhost:44395/api/account. This end poind does a GET request, that return all customer.

i used Azure devop for my build pipeline. https://dev.azure.com/amozudevorganization/BackEndProject/_build

The project can be accessed from https://github.com/amozu2008/BackEndProject


I used Visual Studio 2019 to build the app. Thanks!



