
using UnityEngine;
using UnityEngine.Video;

public class StopButton : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer vidPlayer;
    public static bool isPaused;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        vidPlayer.Pause();
        isPaused = true;
    }
}
