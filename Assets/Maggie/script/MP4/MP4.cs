using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP4 : MonoBehaviour
public Animator m_Animator;
bool takemp4;
public KeyCode keyToPress;

private void(Input.GetButtonDown(keyToPress));
{
    m_Animator.SetBool("IsMP4Out", true);
    if(takemp4 == false)
    {
        m_Animator.SetBool("IsMP4Out", true);
        Debug.Log("Je sors le MP4");
        takemp4 = true;
    }
    if(takemp4 == true)
    {
        m_Animator.SetBool("IsMP4Out", false);
        Debug.Log("Je range mp4");
        takemp4 = false;
    }
}