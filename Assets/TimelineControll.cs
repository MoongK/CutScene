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
            playCam.gameObject.SetActive(false);
            player.GetComponent<SimplePlayController>().enabled = false;
        }
        else
        {
            eventCam.gameObject.SetActive(false);
            playCam.gameObject.SetActive(true);
            player.GetComponent<SimplePlayController>().enabled = true;
        }
    }
}
