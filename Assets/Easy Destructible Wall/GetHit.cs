using UnityEngine;

public class GetHit : MonoBehaviour
{
    public GenerateScor scor;

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Debug.Log("lovittttttt");
            scor.IncreaseScore();
            gameObject.SetActive(false);
        }
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
