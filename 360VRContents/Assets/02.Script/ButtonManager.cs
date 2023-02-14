using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class ButtonManager : MonoBehaviour
{
    public GameObject Sphere;
    public VideoClip Clip01;
    public VideoClip Clip02;
    public void ToVideoScene()
    {
        SceneManager.LoadScene("360Video");
    }

    public void GoIn()
    {
        Sphere.GetComponent<VideoPlayer>().clip = Clip02;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
