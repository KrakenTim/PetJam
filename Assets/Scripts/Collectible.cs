using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int ScoreAmount = 1;
    public Score ScoreManager;
    public AudioSource audioSource;
    [SerializeField] private float maximumSpawnDuration;
    private SphereCollider collider;
    private MeshRenderer model;
    private ParticleSystem particles;

    private void Awake()
    {
        ScoreManager = GameObject.Find("Score").GetComponent<Score>();
        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<SphereCollider>();
        model = GetComponent<MeshRenderer>();
        particles = GetComponent<ParticleSystem>();
    }

    void ToggleVisibility()
    {
        collider.enabled = !collider.enabled;
        model.enabled = !model.enabled;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ScoreManager.AddScore(ScoreAmount);
            audioSource.Play();
            particles.Play();
            StartCoroutine("SpawnAfterLifetime");
        }
      
        
    }

    public IEnumerator SpawnAfterLifetime()
    {
        ToggleVisibility();
        yield return new WaitForSeconds(maximumSpawnDuration);
        ToggleVisibility();
        yield return null;
    }
}
