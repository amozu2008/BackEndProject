This is a BackEnd API Assignment using .NetCore framework. 
The Objective of BackEnd API Assignment is to expose three endpoint the will enable users/customer create an account, 
view all account and view account for a specific user or customer.

I am still in my development evn. my local server url is https://localhost:44395
https://localhost:44395/api/account this end point does a post request which accept two parameters customerid and initialCredit.
This endpoint creates a new account for a specific customer id and also does a transaction on the newly created account if initial credit is more than zero.

The second end point is https://localhost:44395/api/account/{customerid} this end point does a get request which accept a customer id
and displays the customer information.
