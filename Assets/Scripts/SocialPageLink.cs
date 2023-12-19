using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialPageLink : MonoBehaviour
{
    private string linkedInURL = "https://www.linkedin.com/in/senthil-m-47ba8488/";
    private string whatsappURL = "+918220081751";
    private string emailURL = "senthilrakhul95@gmail.com";
    private string gitHubURL = "https://github.com/Senthilrakhul95";
    private string instagramID = "https://www.instagram.com/senthil_95_/";
    private string resumeURL = "https://drive.google.com/file/d/1hY6IkE5nvKwr-t1LNbh2VI4-izNbKktm/view?usp=sharing";
    private string facebookURL = "https://www.facebook.com/senthilrakhul95/";
    private GameObject socialLinkGroup;

    public void OpenLinkedIn()
    {
        Application.OpenURL(linkedInURL);
    }

    public void OpenEmail()
    {
        Application.OpenURL("mailto:" + emailURL);
    }

    public void OpenInstagram()
    {
        Application.OpenURL(instagramID);
    }

    public void OpenWhatsapp()
    {
        Application.OpenURL("https://wa.me/" + whatsappURL);
    }

    public void OpenGithub()
    {
        Application.OpenURL(gitHubURL);
    }

    public void DownloadResume()
    {
        Application.OpenURL(resumeURL);
    }
}
