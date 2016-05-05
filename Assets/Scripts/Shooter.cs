using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 1000f;

    void Start () {
        shotPos = GameObject.Find("ShotPos").transform;
    }
	
	public void Projectile () {
        Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
        shot.AddForce(shotPos.forward * shotForce);
    }
}
