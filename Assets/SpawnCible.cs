using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCible : MonoBehaviour
{
    [SerializeField] private GameObject cible;
    public static List<GameObject> listcible = new List<GameObject>();
    private int Nbciblemax = 10;
    private void Instantier(){
        Vector3 position = new Vector3(Random.Range(-40,40), 1f, Random.Range(-40,40));
        var obj = Instantiate(cible, position, Quaternion.identity);
        obj.transform.RotateAround(position, new Vector3(0f,0f,1f), 90);
        listcible.Add(obj);
    }
    public IEnumerator Spawn(){
        while(true){
            Debug.Log(listcible.Count);
            if(Nbciblemax > listcible.Count){
                Instantier();
            }
            yield return new WaitForSeconds(0.05f);
        }

    }
    void Update(){
    }
    void Start(){
        StartCoroutine(Spawn());
    }
}
