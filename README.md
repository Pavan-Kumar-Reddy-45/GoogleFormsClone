**Project Title:** Windows Desktop Application for Form Submissions

## Overview
This project is a Windows Desktop Application built with Visual Basic using Visual Studio. The application allows users to create and view form submissions, featuring fields for Name, Email, Phone Number, and a GitHub repository link. Additionally, it includes a stopwatch that can be paused and resumed, and supports keyboard shortcuts for quick actions.

## Features
- **Create New Submission:** Opens a form with fields for Name, Email, Phone Number, and GitHub repo link. Includes a stopwatch that can be paused and resumed. Press `Ctrl + S` to submit the form.
- **View Submissions:** Opens a form to view all submissions. Users can navigate through submissions using "Previous" and "Next" buttons.

## Requirements
- Windows Operating System
- Visual Studio (not Visual Studio Code)
- Visual Basic

## Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/Pavan-Kumar-Reddy-45/GoogleFormsClone
    ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the solution to restore NuGet packages and compile the project.

## Usage
1. Run the application.
2. On the main form, choose between:
    - **View Submissions:** Opens the form to navigate through existing submissions.
    - **Create New Submission:** Opens the form to create a new submission.
3. In the **Create New Submission** form:
    - Fill out the fields for Name, Email, Phone Number, and GitHub repo link.
    - Use the Start/Pause button to control the stopwatch.
    - Press `Ctrl + S` to submit the form.
4. In the **View Submissions** form:
    - Use the "Previous" and "Next" buttons to navigate through the submissions.

## Keyboard Shortcuts
- **Ctrl + S:** Submit the form on the Create New Submission page.

## Code Structure
- **CreateSubmissionForm.vb:** Contains the logic for creating new submissions, including form fields and stopwatch functionality.
- **ViewSubmissionsForm.vb:** Contains the logic for viewing and navigating through the submissions.
- **Submission.vb:** Defines the `Submission` class used to store submission data.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License
This project is licensed under the MIT License.

## Author
Bhavanam Pavan Kumar Reddy

## Acknowledgements
- Inspiration: Google Forms
- Tools: Visual Studio, Visual Basic
```

### How to Use the Project

1. **Setting Up the Project:**
   - Clone the repository to your local machine using the command:
     ```bash
     git clone https://github.com/yourusername/your-repo-name.git
     ```
   - Open the solution file (`.sln`) in Visual Studio.
   - Build the project to ensure all dependencies are installed and the project compiles without errors.

2. **Running the Application:**
   - Press `F5` in Visual Studio to run the application.
   - The main form will appear with two buttons: "View Submissions" and "Create New Submission".

3. **Creating a New Submission:**
   - Click on "Create New Submission" to open the submission form.
   - Fill in the required fields: Name, Email, Phone Number, and GitHub repo link.
   - Use the Start/Pause button to control the stopwatch.
   - Press `Ctrl + S` or click the "Submit" button to submit the form.

4. **Viewing Submissions:**
   - Click on "View Submissions" to open the view submissions form.
   - Use the "Previous" and "Next" buttons to navigate through the list of submissions.

### Code Explanation

1. **CreateSubmissionForm:**
   - Contains text fields for user input and a button to control the stopwatch.
   - Includes a Timer control that updates the stopwatch display.
   - Handles form submission and clears the form fields after submission.

2. **ViewSubmissionsForm:**
   - Displays submissions one by one.
   - Allows navigation through submissions using "Previous" and "Next" buttons.

3. **Submission Class:**
   - Defines properties for Name, Email, Phone Number, GitHubLink, and SubmissionTime.
   - Used to store and manage submission data.

### Keyboard Shortcuts

- **Ctrl + S:** Submit the form on the Create New Submission page.
