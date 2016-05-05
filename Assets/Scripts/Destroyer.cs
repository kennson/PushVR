using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Destroy(col.gameObject);
        }

        if  (col.gameObject.tag == "Cube")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
