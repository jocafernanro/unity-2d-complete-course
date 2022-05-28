using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [Range(0f, 1f)] [SerializeField] float coinPickupSFXVolume = 0.5f;
    [SerializeField] int pointsForCoinPickup = 100;

    bool wasCollected = false;
    

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && !wasCollected) {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position, coinPickupSFXVolume);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
