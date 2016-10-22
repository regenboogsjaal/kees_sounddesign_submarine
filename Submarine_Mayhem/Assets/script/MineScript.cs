using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MineScript : MonoBehaviour
{

    public GameObject Player;
    public AudioSource Explosion;
    public int MineRadius = 2;

    private bool exploding = false;

	// Update is called once per frame
	void Update ()
    {
	    if (Vector3.Distance(transform.position, Player.transform.position) < MineRadius && !exploding)
	    {
	        exploding = true;
	        foreach (var audioSource in FindObjectsOfType(typeof(AudioSource)) as AudioSource[])
	        {
                audioSource.volume = 0;
	        }
	        Explosion.volume = 1;
	        Explosion.PlayOneShot(Explosion.clip);
	        StartCoroutine(WaitForSound(Explosion.clip));
	    }
	}

    IEnumerator WaitForSound(AudioClip clip)
    {
        yield return new WaitForSeconds(clip.length);
        SceneManager.LoadScene("blabla");
    }
}
