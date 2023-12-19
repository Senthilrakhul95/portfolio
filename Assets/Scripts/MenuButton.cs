using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MenuButton : MonoBehaviour
{
    private bool isClicked = false;
    [SerializeField] private GameObject Menupanel;
    [SerializeField] private GameObject homeButton;
    [SerializeField] private GameObject skillButton;
    [SerializeField] private GameObject pluginButton;
    [SerializeField] private GameObject projectButton;
    [SerializeField] private GameObject ContentArea;

    [SerializeField] private GameObject SkillContentArea;
    [SerializeField] private GameObject ProjectContentArea;
    [SerializeField] private GameObject PluginContentArea;
    [SerializeField] private GameObject ProjectContentPopup;

    [SerializeField] private ProjectContent projectContent;


    public Page currentPage;


    public enum Page
    {
        Home,
        Skill,
        Plugin,
        Project,
        None
    }

    public void Start()
    {
        isClicked = true;
        OpenHome();
        currentPage = Page.Home;
    }


    public void OpenCloseMenu()
    {
        if (!isClicked)
        {
            Menupanel.SetActive(true);
            isClicked = true;
        }
        else
        {
            Menupanel.SetActive(false);
            isClicked = false;
        }
        UpdateButtonVisibility();
    }

    private void UpdateButtonVisibility()
    {
        Page thispage = currentPage;
        switch(thispage)
        {
            case Page.Home:
                skillButton.SetActive(true);
                projectButton.SetActive(true);
                pluginButton.SetActive(true);
                homeButton.SetActive(false);
                break;
            case Page.Skill:
                skillButton.SetActive(false);
                projectButton.SetActive(true);
                pluginButton.SetActive(true);
                homeButton.SetActive(true);
                break;
            case Page.Plugin:
                skillButton.SetActive(true);
                projectButton.SetActive(true);
                pluginButton.SetActive(false);
                homeButton.SetActive(true);
                break;
            case Page.Project:
                skillButton.SetActive(true);
                projectButton.SetActive(false);
                pluginButton.SetActive(true);
                homeButton.SetActive(true);
                break;
        }
    }

    public void OpenHome()
    {
        OpenCloseMenu();
        currentPage = Page.Home;
        ContentArea.SetActive(false);
    }

    public void OpenSkill()
    {
        OpenCloseMenu();
        currentPage = Page.Skill;
        ContentArea.SetActive(true);
        ProjectContentPopup.SetActive(false);
        SkillContentArea.SetActive(true);
        ProjectContentArea.SetActive(false);
        PluginContentArea.SetActive(false);
    }

    public void OpenProject()
    {
        OpenCloseMenu();
        currentPage = Page.Project;
        ContentArea.SetActive(true);
        ProjectContentPopup.SetActive(false);
        SkillContentArea.SetActive(false);
        ProjectContentArea.SetActive(true);
        PluginContentArea.SetActive(false);
        PlayVideo();
    }
    public void OpenPlugin()
    {
        OpenCloseMenu();
        currentPage = Page.Plugin;
        ContentArea.SetActive(true);
        ProjectContentPopup.SetActive(false);
        SkillContentArea.SetActive(false);
        ProjectContentArea.SetActive(false);
        PluginContentArea.SetActive(true);
    }


    public void PlayVideo()
    {
        projectContent.current_page = 0;
        projectContent.DisplayContent();
    }
}
