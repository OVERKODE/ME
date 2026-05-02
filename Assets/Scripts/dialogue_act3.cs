using System.Collections;
using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogue_act3 : MonoBehaviour
{
    public Text txt;
    public CinemachineCamera cam;
    private int count = 0;
    public Collider coll;
    public Transform shadow;
    private bool flag = false;
    public AudioSource audi;
    public Canvas can;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            audi.Play();
            cam.LookAt = shadow;
            flag = true;
            txt.text = "???:\nBasically...";
            Debug.Log("Entered");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            audi.Play();
            count++;
        }
        if (flag == true)
        {
            switch (count) {
            case 1:
                txt.text = "???:\nYour main problem is yourself.";
                break;
            case 2:
                txt.text = "???:\nMost of your time you regret about anything that appears in your head.";
                break;
            case 3:
                SceneManager.LoadScene(6);
                break;
            default:
                txt.text = "???:\nBasically...";
                break;
            }
        }
    }
}
