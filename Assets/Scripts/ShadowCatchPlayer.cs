using UnityEngine;
using UnityEngine.SceneManagement;

public class ShadowCatchPlayer : MonoBehaviour
{
    public float catchDist = 20.0f;
    public Transform shadow;
    public Transform player;
    void Update()
    {
        string curScene = SceneManager.GetActiveScene().name;
        double dist = Vector3.Distance(player.position, shadow.position);
        if (dist <= catchDist)
        {
            if (curScene == "forest")
            {
                SceneManager.LoadScene(2);
            }
            else if (curScene == "final_act")
            {
                SceneManager.LoadScene(7);
            }
        }
    }
}
