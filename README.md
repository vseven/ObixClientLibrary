# ObixClientLibrary
Obix Client Library based on the work of TylerJWatson - https://github.com/tylerjwatson/NetBIX for retrieving Obix points from a device, in my case Niagara/Tridium Jace and Web Supervisors.

# Installation
Create a Class Library project within your VS solution called Obix Client Library (or the name of your choosing).  Add the files here to your project.  In your main project add a reference to this library.  

# Basic Usage
### For ease of use add some imports to your code:
```
Imports ObixClientLibrary
Imports ObixClientLibrary.Extensions
Imports ObixClientLibrary.Framework
```

### Basic connection to a Obix server: 
```
Dim obixClient As XmlObixClient = GetClient(ServerAddress, UserName, Password, AuthenticationType)
Dim connectResult As ObixResult = obixClient.Connect()
If connectResult = ObixResult.kObixClientSuccess Then
  msgbox("Connect success!")
Else
  msgbox("Connect failed!  Reason given: " & ObixResult.Message(connectResult))
End If  
```
### Notes:
Most of the above is self explanitory except for AuthenticationType.  That is a integer whcih is 1 for AX Digest, 2 for N4 Digest, and 3 for HTTP Basic.  Defaults to 3 if not supplied.


# Limitations
This only works with HTTP Basic authentication so setup a user with HTTP Basic.  I could not figure out the code for AX or N4 authentication although I have place holders for them in the code that is commented.  If someone sees this and knows please put in a pull request or raise a issue.  
