# Device Tracker - Developer's Guide

This documentation provides an overview of the Device Tracker application developed using VB.NET Windows Forms. The application includes a global module containing structures for storing device and booking information, and a login form for user authentication.

## Global Module - GlobalStructures
This module defines several classes and structures to represent different devices and booking information in the application:

1. **Devices**: The base class for various device types, containing common attributes like ID, model, serial number, status, and device type.

    - **Computers**: A subclass of Devices that represents computers. It includes an attribute 'name' for the computer.

        - **Laptops**: A subclass of Computers representing laptops. It includes additional attributes like processor, RAM, and screen size.

        - **Desktops**: Another subclass of Computers representing desktops. It sets the default status to "Non-Bookable."

    - **Cameras**: A subclass of Devices representing cameras. It includes an attribute for camera resolution.

    - **MobilePhones**: A subclass of Devices representing mobile phones. It includes attributes for camera resolution and phone number.

    - **Televisions**: A subclass of Devices representing televisions. It includes attributes for screen size and whether it is a smart TV. It sets the default status to "Non-Bookable."

    - **Printers**: A subclass of Devices representing printers. It includes attributes for ink model and link to ink. It sets the default status to "Non-Bookable."

2. **Bookings**: A structure to hold booking information, including ID, start and end dates, user, description, and the device ID.

3. **Users**: A structure to store user information, including ID, email, name, password, role, admin status, and an encryption key string.

## Global Module - GlobalFunctions
This module contains several global functions and utility methods used in the application:

1. **GetLastID(filename)**: Retrieves the last ID from a file and returns the next value.

2. **loadNewForm(previousForm, newForm)**: Loads a new form while preserving the previous form's state.

3. **displayNavItems(mnuNav)**: Controls the visibility of navigation items based on user roles.

4. **NavigationFunctions**: A nested class containing methods for handling navigation between forms.

5. **isUserAdmin**: A variable to store user admin status.

6. **userName**: A variable to store the user's name.

7. **restrictedForms**: A list of restricted form names for non-admin users.

8. **Simple3Des**: A class for simple TripleDES encryption and decryption.

## Login Form - frmLogin
The login form is responsible for authenticating users. It includes the following functionality:

- **Textboxes (txtEmail and txtPassword)**: These textboxes handle user input for email and password. They have focus-related events, allowing users to enter their credentials.

- **inputLostFocus(textboxControl)**: A method to handle textboxes' lost focus event by restoring placeholder text if necessary.

- **inputGotFocus(textboxControl)**: A method to handle textboxes' got focus event by clearing placeholder text.

- **inputTextbox_TextChanged(sender, e)**: A method that enables the login button when both email and password are provided.

- **launchHome()**: A method to launch the home form with appropriate settings.

- **btnLogin_Click(sender, e)**: Handles the click event of the login button and calls `verifyLoginDetails` to authenticate the user.

- **verifyLoginDetails(email, password)**: Verifies the user's email and password against user data stored in a "users.csv" file. If successful, it sets the user's name and admin status and returns true. If authentication fails, it displays an error message and returns false.

## Additional Notes
The application appears to use a CSV file format for data storage, but specific file structures and data handling are not provided in the code. Additional code and user interfaces for managing devices, bookings, and users may be present in other parts of the application but are not included in this documentation.
