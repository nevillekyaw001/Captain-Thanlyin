using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private void Start()
    {
        
        FindObjectOfType<AudioManager>().Play("BGM");
        FindObjectOfType<AudioManager>().Unmute("BGM");
    }


}
