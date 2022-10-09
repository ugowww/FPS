using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciation : MonoBehaviour
{
    //Parameters
    //[SerializeField] private int vitesse;
    //[SerializeField] private Vector3 position = new Vector3();
    [SerializeField] Transform CameraTransform;
    [SerializeField] private GameObject Balle;
    private Vector3 position = new Vector3((float)0.7, (float)-0.4, 1);
    //[SerializeField] private GameObject centre;
    //[SerializeField] private int NombreObjet;
    //[SerializeField] private int TailleCercle;
    //private int MonTampNbObjet;
    //private int MonTampTailleC;
    //private int monTampVitesse;
    private List<GameObject> objetgeneres = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tirer());
    }

    private IEnumerator Tirer(){
        //
        while(true){
            while(Input.GetButton("Fire1")){
                GameObject boule = Instantiate(Balle, CameraTransform.position, Quaternion.identity); 
                Rigidbody balleRigidBody = boule.GetComponent<Rigidbody>();
                balleRigidBody.AddForce(CameraTransform.forward * 1000);
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(0.05f);

        }
        //centre.transform.position = position;
        //monTampVitesse = vitesse;
        //MonTampTailleC = TailleCercle;
        //MonTampNbObjet = NombreObjet;

    }


    // Update is called once per frame
    void Update()
    {
        //centre.transform.RotateAround(centre.transform.position, new Vector3(0,1,0), Time.deltaTime*vitesse);
    }
}