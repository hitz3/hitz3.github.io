using UnityEngine;

public class ShootingSkill : MonoBehaviour
{
    public GameObject ball;
    public Transform goal;
    public float power = 10f;

    public void ShootBall()
    {
        Rigidbody ballRb = ball.GetComponent<Rigidbody>();
        Vector3 shootDirection = (goal.position - ball.transform.position).normalized;
        ballRb.AddForce(shootDirection * power, ForceMode.Impulse);
    }

    public int CalculateScore()
    {
        // Lógica para calcular el puntaje del tiro
        return 100;
    }
}
