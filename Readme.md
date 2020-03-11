# Authentic-certificate-generation-app-
It is prototype to generate authentic certificates for interns.
Contains UI and backend code in C# .
This prototype will run on visual studio which is connected to flo blockchain(testserver) and sql database.
It also requires flo wallet with flo coins(cryptocurrency) to perform transactions on blockchain.
It has two interface namely employee and intern where you can login as to whatever role you assume.
The intern applies personal details and field of interest where he wants to work in the internship,all these info gets stored in the blockchain and a qr code is generated.
The emlpoyee logins using username and password which is stored in the local database after the internship period to assign grades to the intern.
If the intern crosses the cutoff marks,a certificate is generated on the localhost while returning a transaction ID as it gets uploaded to the blockchain.
If the intern fails to cross the cutoff the certificate isn't generated.
The intern can use his password and qr code to login and check wether he got the certificate or not.
Every transaction on blockchain involves some amount of fees in form of flo coins.
Although the project works on testenet i.e the flo coins do not have actual value,the app can also be used on realnet provided the user already has flo coins or he is a miner.
