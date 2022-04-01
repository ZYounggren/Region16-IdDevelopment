# **User Stories and Acceptance Criteria**

---

## **Student Advisor**
### **Feature:** Sign In
    As a Student Advisor
	I want to sign-in
	So that I can access the form submission page

    Scenario: Student Advisor sign-in is successful
	    Given the Student Advisor provides valid credentials
	    When the sign in button is clicked
	    Then the Student Advisor is granted access to registration form

    Scenario: Student Advisor sign-in fails
	    Given the Student Advisor provides invalid credentials
	    When the sign in button is clicked
	    Then the Student Advisor is asked to enter credentials again

### **Feature:** Access form submission
	As a Student Advisor
	I want to access the form submission page
	So that I can submit a registration form

    Scenario: Student Advisor accesses form submission
	    Given the Student Advisor sign-in is successful
	    When the Student Advisor is redirected to the form submission page
	    Then access to form submission is achieved

### **Feature:** Submit a form
	As a Student Advisor
	I want to submit a registration form
	So that the attendee database contains the attendee list

    Scenario: Form is verified
	    Given that Student Advisor is on the form submission page
	    When the Student Advisor uploads a .csv registration form
	    Then the form is verified

    Scenario: Form is accepted
	    Given that Student Advisor has submitted a form
	    When the form passes verification
	    Then the form is accepted

    Scenario: Form is rejected
	    Given that Student Advisor has submitted a form
	    When the form does not pass verification
	    Then the form is rejected and Student Advisor must try again

### **Feature:** View submitted forms
	As a Student Advisor
	I want to view submitted forms
	So that I can verify information accuracy

    Scenario: Student Advisor views submitted forms
	    Given that Student Advisor has signed in successfully
	    When the Student Advisor clicks on Submitted Forms button
	    Then a list of submitted forms is displayed

### **Feature:** Update a submitted form
	As a Student Advisor
	I want to update a submitted form
	So that the information is accurate

    Scenario: Student Advisor chooses a submitted form
	    Given that a list of submitted forms is displayed
	    When the Student Advisor chooses a form
	    Then an updatable form is displayed

    Scenario: Student Advisor updates a chosen form
	    Given that the Student Advisor has chosen a form
	    When the Student Advisor updates form information and clicks Update button
	    Then the form is updated and saved

### **Feature:** View list of session topics
	As a Student Advisor
	I want to view a list of session topics
	So that I can inform students of session choices

    Scenario: Session list is viewed
	    Given that the Student Advisor has signed in successfully
	    When the Student Advisor clicks the Sessions button
	    Then a list of sessions is displayed

---
---

## **Speaker**
### **Feature:** Sign-in
	As a Speaker
	I want to sign-in
	So that I can access the form submission page

    Scenario: Speaker sign-in is successful
	    Given the Speaker provides valid credentials
	    When the sign-in button is clicked
	    Then the Speaker is granted access to registration form

    Scenario: Speaker sign-in fails
	    Given the Speaker provides invalid credentials
	    When the sign-in button is clicked
	    Then the Speaker is asked to enter credentials again

### **Feature:** Access form submission
	As a Speaker
	I want to access the form submission page
	So that I can submit a registration form

    Scenario: Speaker accesses form submission
	    Given the Speaker sign-in is successful
	    When the Speaker is redirected to the form submission page
	    Then access to form submission is achieved

### **Feature:** Submit a form
	As a Speaker
	I want to submit a registration form
	So that I can reserve a session slot

    Scenario: Form is verified
	    Given that Speaker is on the form submission page
	    When the Speaker fills out the registration form
	    Then the form fields are verified

    Scenario: Form is accepted
	    Given that Speaker has clicked the Submit Form button
	    When the form passes verification
	    Then the form is accepted

    Scenario: Form is rejected
	    Given that Speaker has clicked the Submit Form button
	    When the form does not pass verification
	    Then the form is rejected and Speaker must try again

### **Feature:** View submitted forms
	As a Speaker
	I want to view submitted forms
	So that I can verify information accuracy

    Scenario: Speaker views submitted forms
	    Given that Speaker has signed in successfully
	    When the Speaker clicks on Submitted Forms button
	    Then a list of submitted forms is displayed

### **Feature:** Update a submitted form
	As a Speaker
	I want to update a submitted form
	So that the information is accurate

    Scenario: Speaker chooses a submitted form
	    Given that a list of submitted forms is displayed
	    When the Speaker chooses a form
	    Then an updatable form is displayed

    Scenario: Speaker updates a chosen form
	    Given that the Speaker has chosen a form
	    When the Speaker updates form information and clicks Update button
	    Then the form is updated and saved

### **Feature:** View list of session topics
	As a Speaker
	I want to view a list of session topics
	So that I can choose a session topic

    Scenario: Session list is viewed
	    Given that the Speaker has signed in successfully
	    When the Speaker clicks the Sessions button
	    Then a list of sessions is displayed

---
---

## **Admin**
### **Feature:** Sign in
	As an Admin
	I want to sign in
	So that I can access all submitted forms

    Scenario: Admin sign-in is successful
	    Given the Admin provides valid credentials
	    When the sign-in button is clicked
	    Then the Admin is granted access to registration form

    Scenario: Speaker sign-in fails
	    Given the Admin provides invalid credentials
	    When the sign-in button is clicked
	    Then the Admin is asked to enter credentials again

### **Feature:** Access submitted form database
	As an Admin
	I want to access submitted form database
	So that I can manage submitted forms

    Scenario: Admin accesses submitted form database page
	    Given the Admin sign-in is successful
	    When the Admin is redirected to the submitted form database page
	    Then access to submitted form database is achieved

### **Feature:** View submitted forms in database
	As an Admin
	I want to view submitted forms in database
	So that I can verify information accuracy

    Scenario: Admin views submitted forms
	    Given that Admin has signed in successfully
	    When the Admin clicks on Submitted Forms Database button
	    Then a list of submitted forms is displayed

### **Feature:** Update a submitted form
	As an Admin
	I want to update a submitted form
	So that the information is accurate

    Scenario: Admin chooses a submitted form
	    Given that a list of submitted forms is displayed
	    When the Admin chooses a form
	    Then an updatable form is displayed

    Scenario: Admin updates a chosen form
	    Given that the Admin has chosen a form
	    When the Admin updates form information and clicks Update button
	    Then the form is updated and saved

### **Feature:** Delete a submitted form
	As an Admin
	I want to delete a submitted form
	So that the information is accurate

    Scenario: Admin chooses a submitted form to delete
	    Given that a list of submitted forms is displayed
	    When the Admin chooses a form
	    Then a form is displayed for deletion

    Scenario: Admin deletes a chosen form
	    Given that the Admin has chosen a form
	    When the Admin clicks the Delete Form button
	    Then the form is deleted

### **Feature:** Create a new session topic
	As an Admin
	I want to create a new session topic
	So that a new session will be available

    Scenario: Admin creates a new session
	    Given that a list of sessions is displayed
	    When the Admin clicks Create New Session and enters session information
	    Then a new session is created

### **Feature:** View list of session topics
	As an Admin
	I want to view a list of session topics
	So that I can verify information accuracy

    Scenario: Session list is viewed
	    Given that the Admin has signed in successfully
	    When the Admin clicks the Sessions button
	    Then a list of sessions is displayed

### **Feature:** Update a session topic
	As an Admin
	I want to update a session topic
	So that the session information is accurate

    Scenario: Admin chooses a session to update
	    Given that a list of sessions is displayed
	    When the Admin chooses a session to update
	    Then an updatable view of chosen session is displayed

    Scenario: Admin updates session information
	    Given that the chosen session is displayed
	    When the Admin updates the information and clicks Update button
	    Then the session information is saved

### **Feature:** Delete a session topic
	As an Admin
	I want to delete a session topic
	So that the session information is accurate

    Scenario: Admin chooses a session to delete
	    Given that a list of sessions is displayed
	    When the Admin chooses a session to delete
	    Then the session to be deleted is displayed

    Scenario: Admin deletes chosen session
	    Given that the chosen session is displayed
	    When the Admin clicks the Delete Session button
	    Then the session is deleted


