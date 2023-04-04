using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;
public class ValideEmail : MonoBehaviour
{
    [SerializeField] private TMP_InputField email;
    [SerializeField] private TMP_InputField password;
    [SerializeField] private TMP_InputField email1;
    [SerializeField] private TMP_InputField password1;
    [SerializeField] private TMP_InputField search;
    public bool isValid_email;
    public TextMeshProUGUI em;
    public TextMeshProUGUI pass;
    public TextMeshProUGUI em1;
    public TextMeshProUGUI pass1;
    public GameObject emailverify;
    public GameObject passwordverify;
    public GameObject emailverify1;
    public GameObject passwordverify1;
    public GameObject emailPass;
    public GameObject user;
    public GameObject homepanel;
    public GameObject logpanel;
    public GameObject mask;
    public GameObject searcxh;
    public GameObject firstpaneldog;
    public GameObject secondpaneldog;
    public GameObject seemore;

    public const string MatchEmailPattern =
        @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
        + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
        + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
        + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoginButton()//login panel
    {
        bool x1 = validateEmail1(email1.text);
        bool y1 = ValidatePassword1(password1.text);
        if (x1 != true)
        {
            emailverify1.SetActive(true);
            em1.text = "Plasea Enter Valid Email...";
        }
        else
        {
            emailverify1.SetActive(false);
        }
        if (y1 != true)
        {
            pass1.text = "Password Should be 5 Characters..";
            passwordverify1.SetActive(true);
        }
        else
        {
            passwordverify1.SetActive(false);
        }
        if (x1 == true && y1 == true)
        {
            logpanel.SetActive(false);
            homepanel.SetActive(true);

        }
        else
        {
            logpanel.SetActive(true);
            homepanel.SetActive(false);
        }
    
    }
    public void NextButton() //signuppanel
    {
        bool x = validateEmail(email.text);
        bool y = ValidatePassword(password.text);
        if (x != true)
        {
            emailverify.SetActive(true);
            em.text = "Plasea Enter Valid Email...";
        }
        else
        {
            emailverify.SetActive(false);
        }
        if (y != true)
        {
            pass.text = "Password Should be 5 Characters..";
            passwordverify.SetActive(true);
        }
        else
        {
            passwordverify.SetActive(false);
        }
        if(x==true && y == true)
        {
            emailPass.SetActive(false);
            user.SetActive(true);

        }
        else
        {
            emailPass.SetActive(true);
            user.SetActive(false);
        }
    }
    public static bool validateEmail(string email)
    {
        if (email != null)
        {
            Debug.Log("Yes");
            return Regex.IsMatch(email, MatchEmailPattern);
        }
        else
        {
            Debug.Log("No");
            return false;
        }
            
    }
    public bool ValidatePassword(string password)
    {
        if (password.Length < 5)
        {
            
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool validateEmail1(string email)
    {
        if (email != null)
        {
            Debug.Log("Yes");
            return Regex.IsMatch(email, MatchEmailPattern);
        }
        else
        {
            Debug.Log("No");
            return false;
        }

    }
    public bool ValidatePassword1(string password)
    {
        if (password.Length < 5)
        {

            return false;
        }
        else
        {
            return true;
        }
    }
    public void SearchTag()
    {
        if (search.text == "dog" || search.text == "Dog"||search.text=="dogs" || search.text == "Dogs")
        {
            mask.SetActive(true);
            searcxh.SetActive(false);
            firstpaneldog.SetActive(true);
            secondpaneldog.SetActive(false);
            seemore.SetActive(true);
        }
        else
        {
            searcxh.SetActive(true);
            mask.SetActive(false);
        }
    }
    /*private bool ValidEmail(string n)
    {
        
        Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
        isValid_email = false;
        Debug.Log("Enter in valid email");
        isValid_email = check.IsMatch(n);
        if (isValid_email==true)
        {
            em.text = "email valid";
          
            return isValid_email;
            
        }
        else
        {
            em.text = "email not valid";
            return false;
        }
    }*/
}
