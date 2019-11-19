# CheckPoint4
check point 4 for 403
This homework focuses on working with Data through the use of a model.

We will continue to use the project created in CheckPoint #3.

Remember that in CheckPoint #3 you had landing page where you would click on the Rental button or a link or a navbar (or something named like that - remember there were multiple ways to complete CheckPoint #3)

When you clicked on that Rental, you were taken to a new view that listed all of the Instruments. From there you either clicked on the instrument and then selected new or used OR you probably clicked on New or Used link for the instrument.

That would display the information for the instrument (either on the same view or a new view).

For this assignment, you will need to add a database (call it whatever you want) and tables for client and instrument. Don't forget your models, connection string, and dbcontext.

Just make sure you include all of the necessary client and instrument information in the tables. For client it will contain ID, firstname, lastname, address, city, state, zip, email, and phone. I would suggest that you include the clientID in the Instrument table (instrumentID, Desc, type for new or used, price and the client ID to link you back to the client table for the sake of making it easier. 

Now we need to add upon the CheckPoint #3 where in if they click on an instrument you will now go to a view where you can Add a new client's information and create that client record and take the clientID and store it to the instrument record. I would suggest making all the id columns as identity columns (auto increment).

After you store the client information and update the instrument table, you will then display a view that will be a Summary view. This should display a message thanking the customer by name for the order/rental and displaying the "order/rental" info including the orderID (use the client ID for this for now), instrument info, type (new or used), instrument description and image, the monthly price, and the total amount paid after 18 months.

You can use the viewbag or the model. Your choice.

There should also be a home page link, an about link, and a contact us link in the navbar.

The home page link should redirect back to the landing page.

The about link should display the About view (you need to code this) describing the history and mission of the company along with a picture of the founder (you can choose any picture).

Add validations to make sure all information for client is input (required), zip is 5 digits, phone is proper format of (xxx) xxx-xxxx, and the email has the “@” sign.

Display associated error messages for breaking the validation rules

Only 1 per team is required.

You will NOT need to meet with the TAs to grade this

