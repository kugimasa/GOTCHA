using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GotchaAnimationManager : MonoBehaviour
{
    private PlayableDirector m_playableDirector;
    
    void Start()
    {
        m_playableDirector = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        // クリックをして離したとき
        if (Input.GetMouseButtonUp(0))
        {
            PlayTimeLine();
        }
    }
    
    public void PlayTimeLine()
    {
        m_playableDirector.Play();
    }
}
