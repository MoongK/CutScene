using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineControll : MonoBehaviour {

    public PlayableDirector pd;
    public Camera eventCam, playCam;
    public GameObject player;

    private void Update()
    {
        if (pd.state == PlayState.Playing)
        {
            eventCam.enabled = true;
            playCam.enabled = false;
            player.GetComponent<SimplePlayController>().enabled = false;
            print("event");
        }
        else
        {
            playCam.enabled = true;
            eventCam.enabled = false;
            player.GetComponent<SimplePlayController>().enabled = true;
            print("play");
        }
    }
}
