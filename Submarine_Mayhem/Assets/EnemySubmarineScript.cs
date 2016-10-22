using UnityEngine;
using System.Collections;

public class EnemySubmarineScript : MonoBehaviour
{
    public int TorpedoTimer = 4;
    public float TorpedoSpeed = 1;
    public GameObject Torpedo;
    public GameObject Player;

	public void Start()
    {
        InvokeRepeating("LaunchTorpedo", 0, TorpedoTimer);
    }

    public void LaunchTorpedo()
    {
        var newTorpedo = Instantiate(Torpedo);

        newTorpedo.GetComponent<Rigidbody>().velocity = (transform.position - Player.transform.position).normalized * TorpedoSpeed;
    }
}
