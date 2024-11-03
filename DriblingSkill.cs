using UnityEngine;

public class DribblingSkill : MonoBehaviour
{
    public Transform[] cones;
    private int currentConeIndex = 0;

    public void StartDribblingChallenge()
    {
        // Posicionar al jugador en el primer cono
        if (currentConeIndex < cones.Length)
        {
            transform.position = cones[currentConeIndex].position;
        }
    }

    public void HitCone()
    {
        if (currentConeIndex < cones.Length)
        {
            currentConeIndex++;
            if (currentConeIndex >= cones.Length)
            {
                Player player = GetComponent<Player>();
                player.AddScore(200);
            }
        }
    }
}
