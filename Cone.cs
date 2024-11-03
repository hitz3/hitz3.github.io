using UnityEngine;

public class Cone : MonoBehaviour
{
    private DribblingSkill dribblingSkill;

    void Start()
    {
        dribblingSkill = FindObjectOfType<DribblingSkill>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dribblingSkill.HitCone();
            Destroy(gameObject); // Destruir el cono después de ser golpeado
        }
    }
}
