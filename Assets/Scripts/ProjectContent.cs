using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;
using System.IO;

public class ProjectContent : MonoBehaviour
{
    private string description1 = "1. Hobby Project: Developed a robust multiplayer networking platform using Photon and Agora Engine, facilitating a shared virtual environment for multiple users. Implemented seamless entry for users into the same digital space with integrated audio communication, enhancing collaborative experiences and real-time interactions.";
    private string description2 = "2. Hobby Project: Crafted a captivating WebXR AR experience using Unity, merging digital elements seamlessly into the real world. Accessible through web browsers, this project demonstrates my prowess in creating engaging and interactive 3D AR content for a broad audience.";
    private string description3 = "3. Hobby Project: Designed Avatars with ReadyPlayerMe and built a lively WebAR app using Model Viewer, hosted on Glitch. A playful fusion of creativity and technology for an engaging online experience.";
    private string description4 = "4. Jio Tesseract: Developed XRLearn, an educational app for immersive learning. Users access content, quizzes, and notifications powered by Firebase. Proud to contribute to edtech, enhancing diverse educational experiences";
    private string description5 = "5. Jio Tesseract: Developed XRTrainer, transforming remote collaboration with seamless video calls and meetings using Agora and Firebase SDKs. Proud to be part of a team elevating virtual teamwork, overcoming geographical barriers for efficient communication.";
    private string description6 = "6. Hexafair: Developed and maintained this versatile platform, accessible on WebGL,Android, and iOS. It redefines virtual events for trade fairs, summits, and more.";
    private string description7 = "NEXT PROJECTS ARE COMING SOON!";

    [SerializeField]
    private VideoClip video1;
    [SerializeField]
    private VideoClip video2;
    [SerializeField]
    private VideoClip video3;
    [SerializeField]
    private VideoClip video4;
    [SerializeField]
    private VideoClip video5;
    [SerializeField]
    private VideoClip video6;
    [SerializeField]
    private VideoClip video7;

    [SerializeField]
    private TMP_Text description_text;

    [SerializeField] private VideoPlayer videoplayer;

    public int current_page = 0;
    public int last_page = 6;

    [SerializeField]
    private GameObject prevButton;
    [SerializeField]
    private GameObject nextButton;

    public void DisplayContent()
    {
        videoplayer.source = VideoSource.Url;
        switch (current_page)
        {
            case 0:
                //videoplayer.clip = video1;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project1.mp4");
                description_text.text = description1;
                break;
            case 1:
                //videoplayer.clip = video2;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project2.mp4");
                description_text.text = description2;
                break;
            case 2:
                //videoplayer.clip = video3;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project3.mp4");
                description_text.text = description3;
                break;
            case 3:
                //videoplayer.clip = video4;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project4.mp4");
                description_text.text = description4;
                break;
            case 4:
                //videoplayer.clip = video5;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project5.mp4");
                description_text.text = description5;
                break;
            case 5:
                //videoplayer.clip = video6;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project6.mp4");
                description_text.text = description6;
                break;
            case 6:
                //videoplayer.clip = video7;
                videoplayer.url = Path.Combine(Application.streamingAssetsPath, "project7.mp4");
                description_text.text = description7;
                break;
        }

        videoplayer.Stop();
        videoplayer.Play();
        UpdateNavigation();
    }

    private void UpdateNavigation()
    {
        prevButton.SetActive(false);
        nextButton.SetActive(false);

        if (current_page < 1)
        {
            nextButton.SetActive(true);
        }
        else if (current_page == last_page)
        {
            prevButton.SetActive(true);
        }
        else
        {
            nextButton.SetActive(true);
            prevButton.SetActive(true);
        }
    }


    public void OnNextbuttonClick()
    {
        current_page++;
        DisplayContent();
    }

    public void OnPrevbuttonClick()
    {
        current_page--;
        DisplayContent();
    }

    
}
