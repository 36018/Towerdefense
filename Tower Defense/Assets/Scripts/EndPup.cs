
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndPup : MonoBehaviour
{
    [SerializeField] private float maxHealth = 1000;
    private float currentHealth;

    [SerializeField] private Slider healthSlider;
    [SerializeField] private GameObject Endpup;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            float damage = other.gameObject.GetComponent<Enemy>().EnemyDamage;
            Debug.Log(damage);
            TakeDamage(damage);
            Destroy(other.gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        Debug.Log(currentHealth);
        currentHealth -= damage;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();

            //back to main menu of win screen
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadSceneAsync("Lose Screen");
    }
}
