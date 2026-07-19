using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDamage : MonoBehaviour
{
    #region Variables

    [Header("Spikes Variables")]
    [SerializeField] private int amountOfDamage = 10;

    public AudioSource damage;

    #endregion


    // If player collides with spikes, player's health decreases
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            damage.Play();
            other.GetComponent<HealthAndDamage>().HealthDecrease(amountOfDamage);
        }
    }


    // If player collides with spikes for more time, player's health decreases
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            damage.Play();
            other.GetComponent<HealthAndDamage>().HealthDecrease(amountOfDamage);
            
        }
    }

}
