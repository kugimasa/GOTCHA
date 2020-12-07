using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineManager : MonoBehaviour
{
    private PlayableDirector m_playableDirector;
    
    // Start is called before the first frame update
    void Start()
    {
        m_playableDirector = GetComponent<PlayableDirector>();
    }

    public void PlayTimeLine()
    {
        m_playableDirector.Play();
    }
}
