using UnityEngine;

public class DepositItems : MonoBehaviour
{
    public CollectItems cf;
    public CollectibleSpawner cs;
    public CarUnlock vu;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Car"))
        {
            GameObject[] collected = GameObject.FindGameObjectsWithTag("Collected");

            foreach (GameObject delete in collected)
            {

                Destroy(delete);

                cf.collectCount = 0;

                cs.prefabList.RemoveAll(go => go.CompareTag("Collected"));
                vu.totalMetalCollected++;
            }
        }
    }
}