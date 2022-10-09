using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleControleur : MonoBehaviour
{
    [SerializeField] private GameObject Balle;
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.layer == LayerMask.NameToLayer("Cible")){
            SpawnCible.listcible.Remove(collision.gameObject);
            Destroy(collision.gameObject);
            Destroy(Balle);
        }
    }
    private IEnumerator DeleteEntity(){
        while(true){
            if(Balle.transform.position.y < -10){
                Destroy(Balle);
            }
            yield return new WaitForSeconds(0.01f);
        }
    }

    void Start(){
        StartCoroutine(DeleteEntity());
    }
}
