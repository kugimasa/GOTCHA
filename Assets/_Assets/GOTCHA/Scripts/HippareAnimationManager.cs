using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HippareAnimationManager : MonoBehaviour
{
    public GameObject HippareText;

    void Update()
    {
        // クリックをして離したとき
        if (Input.GetMouseButtonUp(0))
        {
            HippareText.SetActive(false);
        }
    }
}
