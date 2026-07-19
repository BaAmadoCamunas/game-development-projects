using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    #region Variable

    [Header ("Damage Variables")]

    [SerializeField] private int health = 100;
    private bool noDamage = false;
    [SerializeField] private float timeWithoutDamage = 1f;
    [SerializeField] private float timeWithoutSpeed = 0.2f;

    private Animator anim;

    public AudioSource damage;
    public AudioSource collectAudio;
    public AudioSource gameOver;

    [Header("Heart Variables")]

    [SerializeField] private GameObject firstHeart_Complete;
    [SerializeField] private GameObject firstHeart_Half;
    [SerializeField] private GameObject firstHeart_Empty;
    [SerializeField] private GameObject secondHeart_Complete;
    [SerializeField] private GameObject secondHeart_Half;
    [SerializeField] private GameObject secondHeart_Empty;
    [SerializeField] private GameObject thirdHeart_Complete;
    [SerializeField] private GameObject thirdHeart_Half;
    [SerializeField] private GameObject thirdHeart_Empty;

    #endregion



    private void Start()
    {
        anim = GetComponent<Animator>();


        // Activate hearts
        if (this.tag == "FirstHeart")
        {
            firstHeart_Complete.SetActive(true);
            firstHeart_Half.SetActive(false);
            firstHeart_Empty.SetActive(false);
        }
        if (this.tag == "SecondHeart")
        {
            secondHeart_Complete.SetActive(true);
            secondHeart_Half.SetActive(false);
            secondHeart_Empty.SetActive(false);
        }
        if (this.tag == "ThirdHeart")
        {
            thirdHeart_Complete.SetActive(true);
            thirdHeart_Half.SetActive(false);
            thirdHeart_Empty.SetActive(false);
        }
    }

    private void Update()
    {
        // If character dies, stop game time
        if(health == 0)
        {
            Time.timeScale = 0;
        }
    }

    public void HealthDecrease(int amountOfHealth)
    {
        // If health is a positive value and the Invulnerability corrutine isn't active, decrease the amount of health
        if (!noDamage && health >= 0)
        {
            
            health -= amountOfHealth;
            anim.Play("Damage");

            // Start two corrutines: one to block temprorary the damage that the character can recives and the other to make the character slower
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());

            // Update hearts depending of the amount of health
            if(health == 60)
            {
                UpdateFirstHeartComplete();
                UpdateSecondHeartComplete();
                UpdateThirdHeartComplete();
            }
            else if(health == 50)
            {
                UpdateFirstHeartHalf();
                UpdateSecondHeartComplete();
                UpdateThirdHeartComplete();
            }
            else if(health == 40)
            {
                UpdateFirstHeartEmpty();
                UpdateSecondHeartComplete();
                UpdateThirdHeartComplete();
            }
            else if(health == 30)
            {
                UpdateFirstHeartEmpty();
                UpdateSecondHeartHalf();
                UpdateThirdHeartComplete();
            }
            else if (health == 20)
            {
                UpdateFirstHeartEmpty();
                UpdateSecondHeartEmpty();
                UpdateThirdHeartComplete();
            }
            else if (health == 10)
            {
                UpdateFirstHeartEmpty();
                UpdateSecondHeartEmpty();
                UpdateThirdHeartHalf();
            }
            //Death condition
            else if (health == 0)
            {
                UpdateFirstHeartEmpty();
                UpdateSecondHeartEmpty();
                UpdateThirdHeartEmpty();
                GameOver();
            }
        }
    }


    
    public void HealthIncrease(int amountOfHealth)
    {
        // Increase the amount of health
        health += amountOfHealth;

        // Update hearts depending of the amount of health
        if (health == 60)
        {
            UpdateFirstHeartComplete();
            UpdateSecondHeartComplete();
            UpdateThirdHeartComplete();
        }
        else if (health == 50)
        {
            UpdateFirstHeartHalf();
            UpdateSecondHeartComplete();
            UpdateThirdHeartComplete();
        }
        else if (health == 40)
        {
            UpdateFirstHeartEmpty();
            UpdateSecondHeartComplete();
            UpdateThirdHeartComplete();
        }
        else if (health == 30)
        {
            UpdateFirstHeartEmpty();
            UpdateSecondHeartHalf();
            UpdateThirdHeartComplete();
        }
        else if (health == 20)
        {
            UpdateFirstHeartEmpty();
            UpdateSecondHeartEmpty();
            UpdateThirdHeartComplete();
        }
        else if (health == 10)
        {
            UpdateFirstHeartEmpty();
            UpdateSecondHeartEmpty();
            UpdateThirdHeartHalf();
        }
        

    }



    void GameOver()
    {
        // Destroy LevelMusic when the character dies
        GameObject musicObj = GameObject.FindGameObjectWithTag("LevelMusic");
        Destroy(musicObj);
        gameOver.Play();
        StartCoroutine(GameOverWait(0.3f));

        // Change the game state to Game Over
        GameManager.Instance.UpdateGameState(GameState.GameOver);
    }


    // Corrutine to let game over music sounds
    IEnumerator GameOverWait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }


    // Methods for hearts' updating
    public void UpdateFirstHeartComplete()
    {
        firstHeart_Complete.SetActive(true);
        firstHeart_Half.SetActive(false);
        firstHeart_Empty.SetActive(false);
    }

    public void UpdateFirstHeartHalf()
    {
        firstHeart_Complete.SetActive(false);
        firstHeart_Half.SetActive(true);
        firstHeart_Empty.SetActive(false);
    }

    public void UpdateFirstHeartEmpty()
    {
        firstHeart_Complete.SetActive(false);
        firstHeart_Half.SetActive(false);
        firstHeart_Empty.SetActive(true);
    }

    public void UpdateSecondHeartComplete()
    {
        secondHeart_Complete.SetActive(true);
        secondHeart_Half.SetActive(false);
        secondHeart_Empty.SetActive(false);
    }

    public void UpdateSecondHeartHalf()
    {
        secondHeart_Complete.SetActive(false);
        secondHeart_Half.SetActive(true);
        secondHeart_Empty.SetActive(false);
    }

    public void UpdateSecondHeartEmpty()
    {
        secondHeart_Complete.SetActive(false);
        secondHeart_Half.SetActive(false);
        secondHeart_Empty.SetActive(true);
    }

    public void UpdateThirdHeartComplete()
    {
        thirdHeart_Complete.SetActive(true);
        thirdHeart_Half.SetActive(false);
        thirdHeart_Empty.SetActive(false);
    }

    public void UpdateThirdHeartHalf()
    {
        thirdHeart_Complete.SetActive(false);
        thirdHeart_Half.SetActive(true);
        thirdHeart_Empty.SetActive(false);
    }

    public void UpdateThirdHeartEmpty()
    {
        thirdHeart_Complete.SetActive(false);
        thirdHeart_Half.SetActive(false);
        thirdHeart_Empty.SetActive(true);
    }


    
    private void OnTriggerEnter(Collider other)
    {
        // If the character collides with a heart and health isn't complete, increase the amount of health
        if (other.tag == "Heart")
        {
            if(health <= 40)
            {
                HealthIncrease(20);
            }
            else if(health == 50){
                HealthIncrease(10);
            }
            else if(health == 60){
                //Do nothing
            }

            collectAudio.Play();
            other.gameObject.SetActive(false);
        }

        // If the character collides with the Death Zone, start the Death corrutine
        if(other.tag == "DeathZone")
        {
            
            StartCoroutine(Death());
        }
    }


    //Corrutine for making damage to the character progressively if there're a collision with the Death Zone
    IEnumerator Death()
    {
        for(int i = health; i >= 0; i -= 10) 
        {
            HealthDecrease(10);
            damage.Play();
            yield return new WaitForSeconds(1f);
            
        }
        
    }


    //Corrutine for blocking damage during a little period of time
    IEnumerator Invulnerability()
    {
        
        noDamage = true;
        yield return new WaitForSeconds(timeWithoutDamage);
        noDamage = false;
    }


    //Corrutine for stop the character velocity if collides with the spikes
    IEnumerator BrakeSpeed()
    {
        damage.Play();
        var currentVelocity = GetComponent<PlayerController>().speed;
        GetComponent<PlayerController>().speed = 0;
        yield return new WaitForSeconds(timeWithoutSpeed);
        GetComponent<PlayerController>().speed = currentVelocity;
    }
}
