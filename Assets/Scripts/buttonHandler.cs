using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
public class buttonHandler : MonoBehaviour
{
    bool sentence;
    TrackableBehaviour tb;

    public void ButtonClick()
    {
        if(sentence)
        {
            GameObject.Find("Button").GetComponentInChildren<Text>().text = "Play";

            GameObject.Find("QuadSeta").GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
            GameObject.Find("QuadDoll").GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
            GameObject.Find("QuadCar").GetComponent<UnityEngine.Video.VideoPlayer>().Pause();
            
            sentence = false;
        } else
        {

            GameObject.Find("Button").GetComponentInChildren<Text>().text = "Pause";

            GameObject.Find("QuadSeta").GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            GameObject.Find("QuadDoll").GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            GameObject.Find("QuadCar").GetComponent<UnityEngine.Video.VideoPlayer>().Play();

            sentence = true;
        }
    }
}
