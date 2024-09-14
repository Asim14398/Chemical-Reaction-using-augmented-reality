using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using System.Net.Mail;
using Firebase.Auth;
using Firebase.Extensions;
using System;
using EasyUI.Toast;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using System.IO;


public class firebaseauth : MonoBehaviour
{
    public GameObject signinpanel, signuppanel, profilepanel,forgetpannel,listpanel,lecturepanel,targetpanal,firstpanel,feedback;
    public InputField loginemail, loginpassword, signupemail, signuppassword, sigupconfirmpassword,forgetemail;
    // Start is called before the first frame update
    Firebase.Auth.FirebaseAuth auth;
    Firebase.Auth.FirebaseUser user;
    
    private string activePanelKey = "ActivePanel";
    public int val,val2;

    private void Start()
    {
        

        val = PlayerPrefs.GetInt("ScoreToPass", 0);//periodic table
        val2 = PlayerPrefs.GetInt("lecture", 0);// lecture

        Debug.Log(val);
        // Retrieve the stored active panel when the scene starts
        string activePanel = PlayerPrefs.GetString(activePanelKey, "");

        

        if (activePanel == "ProfilePanel")
        {
            Openprofilepanel();
        }
        else if (activePanel == "Listviewpanel")
        {
            if (val == 1)
            {
                Openlistviewpanel();
                PlayerPrefs.SetInt("ScoreToPass", 0);
                PlayerPrefs.Save();
            }
            else
            {

                Openprofilepanel();
            }
        }
        else if (activePanel == "lecturepanel")
        {
            if (val2 == 1)
            {

                Openlecturepanel();
                PlayerPrefs.SetInt("lecture", 0);
                PlayerPrefs.Save();
            }
            else
            {

                Openprofilepanel();
            }
        }
        else if (activePanel == "targetpanel")
        {
            Openprofilepanel();
        }
        else
        {
            // Default behavior if no stored active panel is found
            OpenFirstpanel();
        }
    }


    private void Awake()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                InitializeFirebase();
                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }
    public void OpenFirstpanel()
    {
        firstpanel.SetActive(true);
        signinpanel.SetActive(false);
        signuppanel.SetActive(false);
        lecturepanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);
        feedback.SetActive(false);
        listpanel.SetActive(false);
        
    }
    public void Openfeedback()
    {
        feedback.SetActive(true);
        firstpanel.SetActive(false);
        signinpanel.SetActive(false);
        signuppanel.SetActive(false);
        lecturepanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);
        listpanel.SetActive(false);
    }
    public void OpenLoginpanel()
    {
        feedback.SetActive(false);
   
        signinpanel.SetActive(true);
        signuppanel.SetActive(false);
        lecturepanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);
        firstpanel.SetActive(false);
        listpanel.SetActive(false);
      
    }
    public void Openlistviewpanel()
    {
        feedback.SetActive(false);

        listpanel.SetActive(true);
        signinpanel.SetActive(false);
        signuppanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);

        PlayerPrefs.SetString(activePanelKey, "Listviewpanel");
    }
    public void Openlecturepanel()
    {
        feedback.SetActive(false);

        lecturepanel.SetActive(true);
        listpanel.SetActive(false);
        signinpanel.SetActive(false);
        signuppanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);
        firstpanel.SetActive(false);
        PlayerPrefs.SetString(activePanelKey, "lecturepanel");
    }
    public void Opensignuppanel()
    {  feedback.SetActive(false);
   

        listpanel.SetActive(false);
        signuppanel.SetActive(true);
        profilepanel.SetActive(false);
        lecturepanel.SetActive(false);
        signinpanel.SetActive(false );
        forgetpannel.SetActive(false);
        firstpanel.SetActive(false);
    }
    public void Openprofilepanel()
    {
        listpanel.SetActive(false);
        feedback.SetActive(false);

        targetpanal.SetActive(false);
        profilepanel.SetActive(true);
        signuppanel.SetActive(false);
        lecturepanel.SetActive(false);
        signinpanel.SetActive(false);
        forgetpannel.SetActive(false);
        firstpanel.SetActive(false);
        PlayerPrefs.SetString(activePanelKey, "ProfilePanel");
    }
    public void Openforgetpannel()
    {
        feedback.SetActive(false);

        listpanel.SetActive(false);
        signuppanel.SetActive(false);
        profilepanel.SetActive(false);
        signinpanel.SetActive(false);
        lecturepanel.SetActive(false);
        forgetpannel.SetActive(true);
        firstpanel.SetActive(false);

    }
    public void OpenLoginpanel11()
    {
        feedback.SetActive(false);

        loginemail.text = "";
        loginpassword.text = "";
        auth.SignOut();
        signinpanel.SetActive(true);
        signuppanel.SetActive(false);
        listpanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);
        lecturepanel.SetActive(false);
        firstpanel.SetActive(false);

        PlayerPrefs.SetString(activePanelKey, "LoginPanel");
    }
    public void Opentargetpanel11()
    {
        feedback.SetActive(false);

        targetpanal.SetActive(true);
        signinpanel.SetActive(false);
        signuppanel.SetActive(false);
        listpanel.SetActive(false);
        profilepanel.SetActive(false);
        forgetpannel.SetActive(false);
        lecturepanel.SetActive(false);
        firstpanel.SetActive(false);

        PlayerPrefs.SetString(activePanelKey, "targetpanel");
    }

    void Update()
    {
        // Check for the Android back button press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (firstpanel.active)
            {

                activePanelKey = "ActivePanel";
                Application.Quit();


            }
            else if (profilepanel.active)
            {
                activePanelKey = "ActivePanel";
                Application.Quit();

            }
            else if (signinpanel.active)
            {
                OpenFirstpanel();

                
            }
            else if ( forgetpannel.active)
            {
                OpenLoginpanel();

            }
            else if (signuppanel.active)
            {
                OpenFirstpanel();
            }
            else if (targetpanal.active)
            {
                Openprofilepanel();
            }
            else if (listpanel.active)
            {
                Openprofilepanel();
            }
            else
            {
                Openprofilepanel();
            
            }
        }
    }

  

    public void loginuser()
    {
       
        if (string.IsNullOrEmpty(loginemail.text)&& string.IsNullOrEmpty(loginpassword.text))
        {
            Toast.Show("Alert! please enter email or password");
            return;
        }
        Toast.Show("Wait..");        
            sigininuser(loginemail.text, loginpassword.text);

        

    }
    public void forgetpasswod()
    {

        if (string.IsNullOrEmpty(forgetemail.text) )
        {
            return;
        }
        Toast.Show("Wait..");
        ForgotPassword(forgetemail.text);



    }
    public void sigmupuser()
    {
        if (string.IsNullOrEmpty(signupemail.text) && string.IsNullOrEmpty(signuppassword.text)&&string.IsNullOrEmpty(sigupconfirmpassword.text)  )
        {
            Toast.Show("Alert! please enter email or password");
            return;
        }
        if (signuppassword.text == sigupconfirmpassword.text)
        {
            bool v=ValidateEmail(signupemail.text);
            bool v2=ValidatePassword(signuppassword.text);
            if (v && v2)
            {
                createUser(signupemail.text, signuppassword.text);
            }
            else
            {
                signuppassword.text = "";
                sigupconfirmpassword.text = "";
                signupemail.text = "";
                Toast.Show("Email must have special charater and numbers or Passowrd is weak");
                return;
            }
        }
        else
        {
            signuppassword.text = "";
            sigupconfirmpassword.text = "";
            Toast.Show("Please type correct password ");
        }
    }
 

public bool ValidateEmail(string email)
{
    string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
    Regex regex = new Regex(pattern);
    return regex.IsMatch(email);
}
    public bool ValidatePassword(string password)
    {
        bool hasUpperCase = false;
        bool hasLowerCase = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUpperCase = true;
            }
            else if (char.IsLower(c))
            {
                hasLowerCase = true;
            }
            else if (char.IsDigit(c))
            {
                hasDigit = true;
            }
        }

        // Check if password meets all criteria
        return password.Length >= 8 && hasUpperCase && hasLowerCase && hasDigit;
    
    }

    public void forgetpass()
    {
        if (string.IsNullOrEmpty(forgetemail.text) )
        {
            Toast.Show("Alert! please enter email ");
            return;
        }
    }
    void createUser(string email,string password)
    {
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWithOnMainThread(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Toast.Show("Error! please type correct format of  Email or password");
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.AuthResult result = task.Result;

            Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                result.User.DisplayName, result.User.UserId);
            Toast.Show("New User Created");
            OpenLoginpanel();
            signupemail.text = "";
            signuppassword.text = "";
            sigupconfirmpassword.text = "";

        });
    }
    public void sigininuser(string email,string password)
    {

        try
        {
            auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWithOnMainThread(task =>
            {
                if (task.IsCanceled)
                {
                    Toast.Show("Error! please type correct Email or password");

                    loginemail.text = "";
                    loginpassword.text = "";

                    Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Toast.Show("Error! please type correct Email or password");

                    loginemail.text = "";
                    loginpassword.text = "";

                    Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                    return;
                }

                Firebase.Auth.AuthResult result = task.Result;

                Debug.LogFormat("User signed in successfully: {0} ({1})",
                    result.User.DisplayName, result.User.UserId);
                Toast.Show("login Successfully");
                
                    Openprofilepanel();
                loginemail.text = "";
                loginpassword.text = "";
                





            });
        }
        catch (Exception ex)
        {
            Debug.LogError($"An exception occurred during sign-in: {ex}");
        }
    }
    void InitializeFirebase()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);
    }

    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if (auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null
                && auth.CurrentUser.IsValid();
            if (!signedIn && user != null)
            {
                Debug.Log("Signed out " + user.UserId);
            }
            user = auth.CurrentUser;
            if (signedIn)
            {
                Debug.Log("Signed in " + user.UserId);

            }
        }
    }

    public void ForgotPassword(string emailAddress)
    {
        auth.SendPasswordResetEmailAsync(emailAddress).ContinueWithOnMainThread(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("Password reset was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError($"Password reset encountered an error: {task.Exception}");
                return;
            }
            Toast.Show("Password reset email sent successfully.");
            Debug.Log("Password reset email sent successfully.");
            forgetemail.text = "";
        });
    }


    void OnDestroy()
    {
        auth.StateChanged -= AuthStateChanged;
        auth = null;
    }
    public void LoadScene2()
    {
        String var = "true";
        PlayerPrefs.SetString("myvariable",var);
        SceneManager.LoadScene("reactionchemical");
    }
    private bool v;
    public void getvariable()
    {

        v= true;

    }
    public void LoadScene3()
    {
        SceneManager.LoadScene("05");
    }
    public void showpassword()
    {
        signuppassword.contentType = InputField.ContentType.Standard;
        signuppassword.DeactivateInputField();
        signuppassword.ActivateInputField();
        Toast.Show("Please type correct password ");
    }
    public void LoadScene4()
    {
        SceneManager.LoadScene("04");
    }
}
