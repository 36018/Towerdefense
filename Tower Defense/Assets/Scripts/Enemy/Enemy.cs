
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float maxHealth = 100f;
    [SerializeField]protected float currentHealth;

    [SerializeField]private Slider healthSlider;
    [SerializeField]private GameObject player;

    [SerializeField]private float enemyDamage = 20f;


    // Start is called before the first frame update

    public float EnemyDamage
    {
        get { return enemyDamage; }
        set { enemyDamage = value; }
    }

    protected void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullethit")
        {
            float damage = other.gameObject.GetComponent<Bullet>().Damage;
            //Debug.Log(damage);
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
            
            //back to main menu of lose screen
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadSceneAsync("Win Screen");
    }
}
