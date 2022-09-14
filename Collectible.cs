using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Score score;

    [SerializeField]
    private GameObject audioEffect;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }

    private void OnCollisionEnter(Collision otherObjectCollision)
    {
        Destroy(GetComponent<MeshRenderer>());
        Destroy(gameObject, 0.5f);
        audioEffect.SetActive(true);
        score.UpdateScore(1);
    }
}
