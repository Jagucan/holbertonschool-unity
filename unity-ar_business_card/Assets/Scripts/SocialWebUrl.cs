using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialWebUrl : MonoBehaviour
{
    public string webURL;

    // redirects to GitHub
    public void GithubURL()
    {
        webURL = "https://github.com/Jagucan";
        Application.OpenURL(webURL);
    }

    // redirects to LinkedIn
    public void linkedinURL()
    {
        webURL = "https://www.linkedin.com/in/jacinto-gutierrez-cantillo-software-developer";
        Application.OpenURL(webURL);
    }

    // redirects to email to send email
    public void SendEmail()
    {
        string email = "jgut.2499@gmail.com";
        string subject = "";
        string body = "";

        webURL = "mailto:" + email +
                    "?subject=" + Uri.EscapeDataString(subject) +
                    "&body=" + Uri.EscapeDataString(body);
        Application.OpenURL(webURL);
    }

}
