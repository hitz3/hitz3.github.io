using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject ball;
    public int score = 0;

    private bool isDribbling = false;
    private ShootingSkill shootingSkill;
    private DribblingSkill dribblingSkill;

    void Start()
    {
        shootingSkill = GetComponent<ShootingSkill>();
        dribblingSkill = GetComponent<DribblingSkill>();
    }

    void Update()
    {
        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Space) && !isDribbling)
        {
            StartDribbling();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            shootingSkill.ShootBall();
        }
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    void StartDribbling()
    {
        isDribbling = true;
        if (dribblingSkill != null)
        {
            dribblingSkill.StartDribblingChallenge();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
        